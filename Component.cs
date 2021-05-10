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
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;

namespace MetroUI
{
	public partial class Component : MetroFramework.Forms.MetroForm, IView, IModelObserver
	{
		public event ViewHandler<IView> changed;
		IController controller;
		public Component()
		{
			InitializeComponent();
			this.Chart_3.Series = new SeriesCollection
			{
				new LineSeries
				{
					Values = new ChartValues<double> { 3, 5, 7, 4 }
				},
				new LineSeries
				{
					Values = new ChartValues<double> { 5, 6, 2, 7 }
				},
			};

			this.Chart_3.AxisX.Add(new Axis
			{
				Labels = new[]
				{
					"1",
					"2",
					"3",
					"4"
				}
			});
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
					this.Body.Controls.Clear();
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
			this.Body.Controls.Add(this.Spinner);
			this.controller.Dispatch(ACTION.LOAD_EXCEL);
		}

		private void DayTabs_Selected(object sender, TabControlEventArgs e)
		{
			Console.WriteLine(e.TabPage);
			Console.WriteLine(e.TabPageIndex);
		}
	}
}
