using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroUI.Common;

namespace MetroUI
{
	public partial class Component : MetroFramework.Forms.MetroForm, IView, IModelObserver
	{
		public event ViewHandler<IView> changed;
		IController controller;
		public Component()
		{
			InitializeComponent();
		}
		public void SetController(IController controller)
		{
			this.controller = controller;
		}
		public void ModelNotify(IModel model, ModelEventArgs e)
		{
			Console.WriteLine(string.Format("[Model -> View] {0}", e.action));
			switch(e.action)
			{
				case ACTION.LOAD_EXCEL_SUCCESS:
					this.Spinner.Spinning = false;
					break;
				default:
					break;
			}
		}
		private void Component_Load(object sender, EventArgs e)
		{
		}

		private void LoadBtn_Click(object sender, EventArgs e)
		{
			this.Spinner.Spinning = true;
			this.controller.Dispatch(ACTION.LOAD_EXCEL);
		}
	}
}
