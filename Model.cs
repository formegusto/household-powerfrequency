using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using hhpf.Common;

using System.IO;

using hhpf.Entity;
using hhpf.Utils;

namespace hhpf
{
	public delegate void ModelHandler<IModel>(IModel sender, ModelEventArgs e);
	public class ModelEventArgs: EventArgs
	{
		public string action;
		public string keyword;
		public double maxWh;
		public DayData[] dayData;
		public List<SimilarData> similarDatas;
		public List<PowerFrequency>[] powerFrequencies;
		public List<PowerFrequency>[] clusterPowerFrequencies;
		public TimeSlot timeslot;

		public ModelEventArgs(string a)
		{
			this.action = a;
		}

		public ModelEventArgs(string a, string k)
		{
			this.action = a;
			this.keyword = k;
		}

		public ModelEventArgs(string a, string k,List<PowerFrequency>[] pf, TimeSlot ts)
		{
			this.action = a;
			this.keyword = k;
			this.powerFrequencies = pf;
			this.timeslot = ts;
		}

		public ModelEventArgs(string a, DayData[] dd, List<PowerFrequency>[] pf, TimeSlot ts)
		{
			this.action = a;
			this.dayData = dd;
			this.powerFrequencies = pf;
			this.timeslot = ts;
		}

		public ModelEventArgs(string a, DayData[] dd, List<PowerFrequency>[] pf, List<PowerFrequency>[] cpf,TimeSlot ts, double mw)
		{
			this.action = a;
			this.dayData = dd;
			this.powerFrequencies = pf;
			this.clusterPowerFrequencies = cpf;
			this.timeslot = ts;
			this.maxWh = mw;
		}

		public ModelEventArgs(string a, List<SimilarData> sm)
		{
			this.action = a;
			this.similarDatas = sm;
		}
	}
	public interface IModelObserver
	{
		void ModelNotify(IModel model, ModelEventArgs e);
	}
	public interface IModel
	{
		void Attach(IModelObserver observer);
		void ChangeKeyword(string keyword);
		void ChangeDay(Day day);
		void ChangeTimeslot(TimeSlot timeslot);
		void ChangeSeason(Season season);
		void AutoDraw();
		void AutoLoad();
		void AutoLoadNext();
		void LoadExcel(bool isAuto=false, bool isAutoLoad=false);
		void RequestDayData(bool isNotify = true);
		void RequestSimilarData();
		void RequestSimPf();
	}
	public class DayClusterModel: IModel
	{
		public event ModelHandler<DayClusterModel> changed;
		public string keyword;
		public bool isLoaded;
		public Day day;
		public TimeSlot timeslot;
		public Season season;
		public int autoIdx;
		public int autoCount;
		public double maxWh;
		public List<string> households;
		public List<SimilarData> similarDatas;
		public List<DayData>[] dayStore;
		public List<PowerFrequency>[] powerFrequencies;
		public List<PowerFrequency>[] clusterPowerFrequencies;

		public DayClusterModel()
		{
			this.keyword = "";
			this.isLoaded = false;
			this.timeslot = TimeSlot.timeslot_3h;
			this.season = Season.ALL;
			this.day = Day.SUN;
			this.autoIdx = -1;
			this.autoCount = 0;
		}
		public void Attach(IModelObserver imo)
		{
			this.changed += new ModelHandler<DayClusterModel>(imo.ModelNotify);
		}
		public void ChangeKeyword(string k) => this.keyword = k;
		public void ChangeDay(Day d)
		{
			this.day = d;
			if (this.isLoaded)
				this.changed.Invoke(this, new ModelEventArgs(MODEL_ACTIONS.REQUIRE_RELOAD));
		}
		public void ChangeTimeslot(TimeSlot t)
		{
			this.timeslot = t;
			if(this.isLoaded)
				this.changed.Invoke(this, new ModelEventArgs(MODEL_ACTIONS.REQUIRE_RELOAD));
		}
		public void ChangeSeason(Season s) { 
			this.season = s;
			if (this.isLoaded)
				this.changed.Invoke(this, new ModelEventArgs(MODEL_ACTIONS.REQUIRE_RELOAD));
		}
		public void AutoDraw()
		{
			this.changed.Invoke(this, new ModelEventArgs(COMMON_ACTIONS.START_LOADING));

			if(this.households == null)
			{
				this.households = new List<string>();

				string path = System.Windows.Forms.Application.StartupPath + @"\household_uid\household_uid.csv";
				StreamReader sr = new StreamReader(path, Encoding.GetEncoding("euc-kr"));

				while (!sr.EndOfStream)
				{
					string line = sr.ReadLine();
					this.households.Add(line);
				}
				sr.Close();
			}
			/*
			if(this.households.Count() - 1 <= autoIdx)
			{
				this.changed.Invoke(this, new ModelEventArgs(VIEW_ACTIONS.AUTO_DRAW_LAST));
			} else
			{
				this.keyword = this.households[++autoIdx];
				LoadExcel(true);
			}
			*/
			this.keyword = this.households[(new Random()).Next(0, this.households.Count() - 1)];
			LoadExcel(true);
		}

		public void AutoLoad()
		{
			if (this.autoCount >= 10)
				this.autoCount = 0;

			this.changed.Invoke(this, new ModelEventArgs(COMMON_ACTIONS.START_LOADING));

			if (this.households == null)
			{
				this.households = new List<string>();

				string path = System.Windows.Forms.Application.StartupPath + @"\household_uid\household_uid.csv";
				StreamReader sr = new StreamReader(path, Encoding.GetEncoding("euc-kr"));

				while (!sr.EndOfStream)
				{
					string line = sr.ReadLine();
					this.households.Add(line);
				}
				sr.Close();
			}

			this.keyword = this.households[(new Random()).Next(0, this.households.Count() - 1)];
			LoadExcel(true, true);
		}

		public void AutoLoadNext()
		{
			int powerDistance = 50;
			if (this.isLoaded)
			{
				List<PowerFrequency>[] pfList = new List<PowerFrequency>[TimeSlotUtils.TimeSlotToSize(this.timeslot)];

				for (int p = 0; p < this.dayStore[(int)this.day][0].data.timeSlot.Length; p++)
					pfList[p] = new List<PowerFrequency>();
				

				for (int d = 0; d < this.dayStore[(int)this.day].Count; d++)
				{
					for (int t = 0; t < this.dayStore[(int)this.day][d].data.timeSlot.Length; t++)
					{
						PowerFrequency findPf = pfList[t].Find(
							(pf) => pf.wh == Math.Floor((Math.Round(this.dayStore[(int)this.day][d].data.timeSlot[t] / 10) * 10) / powerDistance) * powerDistance);

						if (findPf == null)
						{
							pfList[t].Add(new PowerFrequency(Math.Floor((Math.Round(this.dayStore[(int)this.day][d].data.timeSlot[t] / 10) * 10) / powerDistance) * powerDistance));
						}
						else
						{
							findPf.IncFrequency();
						}
					}
				}

				for (int p = 0; p < this.dayStore[(int)this.day][0].data.timeSlot.Length; p++)
				{
					pfList[p].Sort();

					if (pfList[p][pfList[p].Count() - 1].wh >= maxWh)
						maxWh = pfList[p][pfList[p].Count() - 1].wh;
				}

				if (++this.autoCount >= 10)
				{
					this.changed.Invoke(this, new ModelEventArgs(COMMON_ACTIONS.STOP_LOADING));
					this.changed.Invoke(this, new ModelEventArgs(VIEW_ACTIONS.AUTO_LOAD_LAST, this.keyword, pfList, this.timeslot));
				}
				else
					this.changed.Invoke(this, new ModelEventArgs(VIEW_ACTIONS.AUTO_LOAD_NEXT_SUCCESS, this.keyword, pfList, this.timeslot));

			}
		}

		public async void LoadExcel(bool isAuto = false, bool isAutoLoad = false)
		{
			Console.WriteLine(string.Format("{0} {1} {2} ---- ExcelLoadStart", this.keyword.Trim(), this.season, this.timeslot));
			this.dayStore = new List<DayData>[7];

			if (!isAuto)
				this.changed.Invoke(this, new ModelEventArgs(COMMON_ACTIONS.START_LOADING));

			this.isLoaded = false;
			for (int i = 0; i < 7; i++)
				this.dayStore[i] = new List<DayData>();

			await Task.Run(() =>
			{
				SeasonUtils.SeasonToDate(this.season).ForEach(async currentDay =>
				{
					Data clusterTmp = null;
					string path = System.Windows.Forms.Application.StartupPath + @"\" + this.timeslot + @"\clustering_" + currentDay.ToString("yyyyMMdd") + ".csv";
					StreamReader sr = new StreamReader(path, Encoding.GetEncoding("euc-kr"));

					while (!sr.EndOfStream)
					{
						string line = await sr.ReadLineAsync();
						string uid = line.Split(',')[0];

						if (uid.Contains("cluster"))
							clusterTmp = new Data(line.Split(',').ToList());

						if (clusterTmp != null && uid == this.keyword.Trim())
						{
							this.dayStore[DateUtils.DayToIndex(currentDay)].Add(new DayData(
								currentDay,
								clusterTmp,
								new Data(line.Split(',').ToList())
								)
							);

							// Console.WriteLine(String.Format("{0} 클러스터에 {1} 존재합니다!", clusterTmp.uid, this.keyword));

							return;
						}
					}

					sr.Close();
				});
			});

			this.isLoaded = true;
			if(!isAutoLoad)
				this.changed.Invoke(this, new ModelEventArgs(COMMON_ACTIONS.STOP_LOADING));
			if (!isAuto)
				this.changed.Invoke(this, new ModelEventArgs(MODEL_ACTIONS.LOAD_EXCEL_SUCCESS));
			else
			{
				if (!isAutoLoad)
					this.changed.Invoke(this, new ModelEventArgs(VIEW_ACTIONS.AUTO_DRAW_SUCCESS, this.keyword.Trim()));
				else
					this.changed.Invoke(this, new ModelEventArgs(VIEW_ACTIONS.AUTO_LOAD_SUCCESS));
			}
		}
		public void RequestDayData(bool isNotify = true)
		{
			this.maxWh = 0;
			int powerDistance = 50;
			if (this.isLoaded)
			{
				Console.WriteLine(string.Format("{0} --- DayData", this.day));
				List<PowerFrequency>[] pfList = new List<PowerFrequency>[TimeSlotUtils.TimeSlotToSize(this.timeslot)];
				// cluster Power Frequency
				List<PowerFrequency>[] cpfList = new List<PowerFrequency>[TimeSlotUtils.TimeSlotToSize(this.timeslot)];

				for (int p = 0; p < this.dayStore[(int)this.day][0].data.timeSlot.Length; p++) { 
					pfList[p] = new List<PowerFrequency>();
					cpfList[p] = new List<PowerFrequency>();
				}

				for (int d = 0; d < this.dayStore[(int)this.day].Count; d++)
				{
					for (int t = 0; t < this.dayStore[(int)this.day][d].data.timeSlot.Length; t++)
					{
						PowerFrequency findPf = pfList[t].Find(
							(pf) => pf.wh == Math.Floor((Math.Round(this.dayStore[(int)this.day][d].data.timeSlot[t] / 10) * 10) / powerDistance) * powerDistance);

						if (findPf == null)
						{
							pfList[t].Add(new PowerFrequency(Math.Floor((Math.Round(this.dayStore[(int)this.day][d].data.timeSlot[t] / 10) * 10) / powerDistance) * powerDistance));
						}
						else
						{
							findPf.IncFrequency();
						}
					}

					
					for (int t = 0; t < this.dayStore[(int)this.day][d].cluster.timeSlot.Length; t++)
					{
						PowerFrequency findPf = cpfList[t].Find(
							(pf) => pf.wh == Math.Floor((Math.Round(this.dayStore[(int)this.day][d].cluster.timeSlot[t] / 10) * 10) / powerDistance) * powerDistance);

						if (findPf == null)
						{
							cpfList[t].Add(new PowerFrequency(Math.Floor((Math.Round(this.dayStore[(int)this.day][d].cluster.timeSlot[t] / 10) * 10) / powerDistance) * powerDistance));
						}
						else
						{
							findPf.IncFrequency();
						}
					}
					
				}

				for (int p = 0; p < this.dayStore[(int)this.day][0].data.timeSlot.Length; p++) { 
					pfList[p].Sort();
					cpfList[p].Sort();

					if(pfList[p][pfList[p].Count() - 1].wh >= maxWh)
						maxWh = pfList[p][pfList[p].Count() - 1].wh;
				}

				/*
				for (int p = 0; p < this.dayStore[(int)this.day][0].data.timeSlot.Length; p++)
				{
					pfList[p].ForEach((pf) =>
					{
						Console.WriteLine(pf.ToString());
					});
				}
				*/

				this.powerFrequencies = pfList;
				this.clusterPowerFrequencies = cpfList;
				
				if (isNotify)
					this.changed.Invoke(this, new ModelEventArgs(VIEW_ACTIONS.REQUEST_DAYDATA_SUCCESS, this.dayStore[(int)this.day].ToArray(), this.powerFrequencies, this.clusterPowerFrequencies, this.timeslot, this.maxWh));
					
			}
		}
		public async void RequestSimilarData()
		{
			Console.WriteLine(string.Format("{0} {1} {2} ---- RequestSimilarData", this.keyword.Trim(), this.season, this.timeslot));

			List<SimilarData> simData = new List<SimilarData>();

			await Task.Run(async () =>
			{
				for (int d = 0; d < this.dayStore[(int)this.day].Count; d++)
				{
					string path = System.Windows.Forms.Application.StartupPath + @"\" + this.timeslot + @"\clustering_" + this.dayStore[(int)this.day][d].date.ToString("yyyyMMdd") + ".csv";
					StreamReader sr = new StreamReader(path, Encoding.GetEncoding("euc-kr"));

					while (!sr.EndOfStream)
					{
						string line = await sr.ReadLineAsync();
						string uid = line.Split(',')[0];

						if (uid.Contains("cluster") && uid == this.dayStore[(int)this.day][d].cluster.uid)
						{
							string dline = await sr.ReadLineAsync();
							string duid = dline.Split(',')[0];

							while(!duid.Contains("cluster"))
							{
								Console.WriteLine(duid);
								if(duid != this.dayStore[(int)this.day][d].data.uid)
								{
									SimilarData findSim = simData.Find((s) => s.uid == duid);

									if (findSim == null)
									{
										simData.Add(new SimilarData(duid));
									}
									else
									{
										findSim.IncFrequency();
									}
								}
								
								dline = await sr.ReadLineAsync();
								duid = line.Split(',')[0];
							}

							break;
						}
					}
					sr.Close();
				}
			});

			simData.Sort();

			/*
			simData.ForEach((sim) =>
			{
				Console.WriteLine(sim.ToString());
			});
			*/

			this.similarDatas = simData.Count() > 5 ? simData.GetRange(0, 5) : simData;

			this.changed.Invoke(this, new ModelEventArgs(VIEW_ACTIONS.REQUEST_SIMILARDATA_SUCCESS));
		}
		public async void RequestSimPf()
		{
			int powerDistance = 50;
			await Task.Run(() =>
			{
				this.similarDatas.ForEach(async (sm) =>
				{
					List<Data> datas = new List<Data>();

					for (int d = 0; d < this.dayStore[(int)this.day].Count; d++)
					{
						string path = System.Windows.Forms.Application.StartupPath + @"\" + this.timeslot + @"\clustering_" + this.dayStore[(int)this.day][d].date.ToString("yyyyMMdd") + ".csv";
						StreamReader sr = new StreamReader(path, Encoding.GetEncoding("euc-kr"));

						while (!sr.EndOfStream)
						{
							string line = await sr.ReadLineAsync();
							string uid = line.Split(',')[0];
							
							if(uid == sm.uid)
							{
								datas.Add(new Data(line.Split(',').ToList()));
								break;
							}
						}
						sr.Close();
					}

					// datas 가 전부 만들어졌을 거임
					List<PowerFrequency>[] pfList = new List<PowerFrequency>[TimeSlotUtils.TimeSlotToSize(this.timeslot)];
					for (int p = 0; p < datas[0].timeSlot.Length; p++)
					{
						pfList[p] = new List<PowerFrequency>();
					}
					for (int d = 0; d < datas.Count; d++)
					{
						for (int t = 0; t < datas[d].timeSlot.Length; t++)
						{
							PowerFrequency findPf = pfList[t].Find(
								(pf) => pf.wh == Math.Floor((Math.Round(datas[d].timeSlot[t] / 10) * 10) / powerDistance) * powerDistance);

							if (findPf == null)
							{
								pfList[t].Add(new PowerFrequency(Math.Floor((Math.Round(datas[d].timeSlot[t] / 10) * 10) / powerDistance) * powerDistance));
							}
							else
							{
								findPf.IncFrequency();
							}
						}
					}

					for (int p = 0; p < datas[0].timeSlot.Length; p++)
						pfList[p].Sort();

					// PowerFrequency 도 구성 끝!
					this.changed.Invoke(this, new ModelEventArgs(VIEW_ACTIONS.REQUEST_SIMPF_SUCCESS, sm.uid, pfList, this.timeslot));
				});
			});
			
		}
	}
}
