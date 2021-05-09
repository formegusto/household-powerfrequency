using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MetroUI.Common;

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
		void LoadExcel();
	}
	public class DayClusterModel: IModel
	{
		public event ModelHandler<DayClusterModel> changed;
		public void Attach(IModelObserver imo)
		{
			this.changed += new ModelHandler<DayClusterModel>(imo.ModelNotify);
		}
		public async void LoadExcel()
		{
			await Task.Run(() =>
			{
				for (int i = 0; i < 30000; i++)
					Console.WriteLine(i);
			});
			this.changed.Invoke(this, new ModelEventArgs(ACTION.LOAD_EXCEL_SUCCESS));
		}
	}
}
