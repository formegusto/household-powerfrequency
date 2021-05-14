using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hhpf.Common;

namespace hhpf
{
	public delegate void ViewHandler<IView>(IView sender, ViewEventArgs e);
	public class ViewEventArgs: EventArgs
	{
		public string action;
		public string keyword;
		public TimeSlot timeslot;
		public Season season;
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
		public ViewEventArgs(string a, Season s)
		{
			this.action = a;
			this.season = s;
		}
	}
	public interface IView
	{
		event ViewHandler<IView> changed;
		void SetController(IController controller);
	}
}
