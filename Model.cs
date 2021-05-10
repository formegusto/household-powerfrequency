using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MetroUI.Common;

using System.IO;

using MetroUI.Entity;
using MetroUI.Utils;

namespace MetroUI
{
	public delegate void ModelHandler<IModel>(IModel sender, ModelEventArgs e);
	public class ModelEventArgs: EventArgs
	{
		public string action;

		public ModelEventArgs(string a)
		{
			this.action = a;
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
		void LoadExcel();
	}
	public class DayClusterModel: IModel
	{
		public event ModelHandler<DayClusterModel> changed;

		public string keyword;
		public List<DayData>[] dayStore;
		public List<PowerFrequency>[] powerFrequencies;

		public DayClusterModel()
		{
			this.keyword = "";
		}

		public void Attach(IModelObserver imo)
		{
			this.changed += new ModelHandler<DayClusterModel>(imo.ModelNotify);
		}
		public void ChangeKeyword(string k) => this.keyword = k;
		public async void LoadExcel()
		{
			Console.WriteLine(string.Format("{0} ---- ExcelLoadStart", this.keyword.Trim()));
			this.dayStore = new List<DayData>[7];
			this.changed.Invoke(this, new ModelEventArgs(COMMON_ACTIONS.START_LOADING));

			DateTime startDate = new DateTime(2018, 5, 1);
			DateTime endDate = new DateTime(2019, 4, 29);
			List<DateTime> dateList = new List<DateTime>();

			for (int i = 0; i < 7; i++)
				this.dayStore[i] = new List<DayData>();

			for (DateTime day = startDate; day <= endDate; day = day.AddDays(1))
				dateList.Add(day);

			await Task.Run(() =>
			{
				dateList.ForEach(async currentDay =>
				{
					Data clusterTmp = null;
					string path = System.Windows.Forms.Application.StartupPath + @"\data\clustering_" + currentDay.ToString("yyyyMMdd") + ".csv";
					StreamReader sr = new StreamReader(path, Encoding.GetEncoding("euc-kr"));

					while (!sr.EndOfStream)
					{
						string line = await sr.ReadLineAsync();
						string uid = line.Split(',')[0];

						if (uid.Contains("cluster"))
							clusterTmp = new Data(line.Split(',').ToList());

						if (clusterTmp != null && uid == this.keyword)
						{
							this.dayStore[DateUtils.DayToIndex(currentDay)].Add(new DayData(
								clusterTmp,
								new Data(line.Split(',').ToList())
								)
							);

							Console.WriteLine(String.Format("{0} 클러스터에 {1} 존재합니다!", clusterTmp.uid, this.keyword));

							return;
						}
					}

					sr.Close();
				});
			});

			this.changed.Invoke(this, new ModelEventArgs(COMMON_ACTIONS.STOP_LOADING));
			this.changed.Invoke(this, new ModelEventArgs(MODEL_ACTIONS.LOAD_EXCEL_SUCCESS));
		}
	}
}
