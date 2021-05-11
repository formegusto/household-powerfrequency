using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroUI.Common;

namespace MetroUI
{
	public delegate void ViewHandler<IView>(IView sender, ViewEventArgs e);
	public class ViewEventArgs: EventArgs
	{
		public string action;
		public string keyword;
		public TimeSlot timeslot;
		public int dayIdx;
		public ViewEventArgs(string a)
		{
			this.action = a;
		}
		public ViewEventArgs(string a, string k)
		{
			this.action = a;
			this.keyword = k;
		}
		public ViewEventArgs(string a, int di)
		{
			this.action = a;
			this.dayIdx = di;
		}
		public ViewEventArgs(string a, TimeSlot t)
		{
			this.action = a;
			this.timeslot = t;
		}
	}
	public interface IView
	{
		event ViewHandler<IView> changed;
		void SetController(IController controller);
	}
}
