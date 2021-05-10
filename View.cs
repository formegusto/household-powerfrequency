using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroUI
{
	public delegate void ViewHandler<IView>(IView sender, ViewEventArgs e);
	public class ViewEventArgs: EventArgs
	{
		public string action;
		public string keyword;
		public int dayIdx;
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
	}
	public interface IView
	{
		event ViewHandler<IView> changed;
		void SetController(IController controller);
	}
}
