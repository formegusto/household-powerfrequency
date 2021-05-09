using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MetroUI.Common;

namespace MetroUI
{
	public interface IController
	{
		void Dispatch(string action, Dictionary<string, dynamic> payload = null);
	}
	public class DayClusterController: IController
	{
		IView view;
		IModel model;
		public void ViewChanged(IView v, ViewEventArgs e)
		{
			// ViewChanged Response
		}
		public DayClusterController(IView v, IModel m)
		{
			this.view = v;
			this.model = m;
			view.SetController(this);
			model.Attach((IModelObserver)this.view);
			view.changed += new ViewHandler<IView>(this.ViewChanged);
		}
		public void Dispatch(string action, Dictionary<string, dynamic> payload = null)
		{
			Console.WriteLine(string.Format("[View -> Model] {0}", action));
			switch(action)
			{
				case ACTION.LOAD_EXCEL:
					this.model.LoadExcel();

					break;
				default:
					break;
			}
		}
	}
}
