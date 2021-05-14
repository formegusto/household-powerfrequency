using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using hhpf.Common;

namespace hhpf
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
			Console.WriteLine(string.Format("[View -> Model:ViewChanged] {0}", e.action));
			switch (e.action)
			{
				case VIEW_ACTIONS.CHANGE_KEYWORD:
					this.model.ChangeKeyword(e.keyword);

					break;
				case VIEW_ACTIONS.CHANGE_TIMESLOT:
					this.model.ChangeTimeslot(e.timeslot);

					break;
				case VIEW_ACTIONS.CHANGE_DAY:
					this.model.ChangeDay(e.day);

					break;
				case VIEW_ACTIONS.CHANGE_SEASON:
					this.model.ChangeSeason(e.season);

					break;
				case VIEW_ACTIONS.REQUEST_DAYDATA:
					this.model.RequestDayData();

					break;
				default:
					break;
			}
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
			Console.WriteLine(string.Format("[View -> Model:ModelChanged] {0}", action));
			switch(action)
			{
				case MODEL_ACTIONS.LOAD_EXCEL:
					this.model.LoadExcel();

					break;
				default:
					break;
			}
		}
	}
}
