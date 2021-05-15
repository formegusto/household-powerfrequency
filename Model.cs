﻿using System;
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
		public DayData[] dayData;
		public List<PowerFrequency>[] powerFrequencies;
		public List<PowerFrequency>[] clusterPowerFrequencies;
		public TimeSlot timeslot;

		public ModelEventArgs(string a)
		{
			this.action = a;
		}

		public ModelEventArgs(string a, DayData[] dd, List<PowerFrequency>[] pf, TimeSlot ts)
		{
			this.action = a;
			this.dayData = dd;
			this.powerFrequencies = pf;
			this.timeslot = ts;
		}

		public ModelEventArgs(string a, DayData[] dd, List<PowerFrequency>[] pf, List<PowerFrequency>[] cpf,TimeSlot ts)
		{
			this.action = a;
			this.dayData = dd;
			this.powerFrequencies = pf;
			this.clusterPowerFrequencies = cpf;
			this.timeslot = ts;
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
		void LoadExcel();
		void RequestDayData(bool isNotify = true);
	}
	public class DayClusterModel: IModel
	{
		public event ModelHandler<DayClusterModel> changed;
		public string keyword;
		public bool isLoaded;
		public Day day;
		public TimeSlot timeslot;
		public Season season;
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
		public async void LoadExcel()
		{
			Console.WriteLine(string.Format("{0} {1} {2} ---- ExcelLoadStart", this.keyword.Trim(), this.season, this.timeslot));
			this.dayStore = new List<DayData>[7];
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
			this.changed.Invoke(this, new ModelEventArgs(COMMON_ACTIONS.STOP_LOADING));
			this.changed.Invoke(this, new ModelEventArgs(MODEL_ACTIONS.LOAD_EXCEL_SUCCESS));
		}
		public void RequestDayData(bool isNotify = true)
		{
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
					this.changed.Invoke(this, new ModelEventArgs(VIEW_ACTIONS.REQUEST_DAYDATA_SUCCESS, this.dayStore[(int)this.day].ToArray(), this.powerFrequencies, this.clusterPowerFrequencies, this.timeslot));
					
			}
		}
	}
}
