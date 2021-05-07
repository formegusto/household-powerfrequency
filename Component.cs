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
			switch(e.action)
			{
				case ACTION.LOAD_EXCEL_SUCCESS:
					break;
				default:
					break;
			}
		}
		private void Component_Load(object sender, EventArgs e)
		{
			PrivateFontCollection privateFonts = new PrivateFontCollection();

			string path = @"C:\Users\ykpark\source\repos\MetroUI\Resource\Fonts\Montserrat-SemiBold.ttf";
			privateFonts.AddFontFile(path);
			Font font = new Font(privateFonts.Families[0], 24f);

			this.Sun.Font = font; this.Mon.Font = font; this.Tue.Font = font;
			this.Wed.Font = font; this.Thu.Font = font; this.Fri.Font = font; this.Sat.Font = font;
		}

		private void LoadBtn_Click(object sender, EventArgs e)
		{

			this.controller.Dispatch(ACTION.LOAD_EXCEL);
		}
	}
}
