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
using LiveCharts.Defaults;
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
			ChartValues<ObservablePoint> test = new ChartValues<ObservablePoint>();
			this.Chart.Series = new SeriesCollection
			{
				new LineSeries
				{
					Title = "0~3 Power Frequency",
					Values = new ChartValues<ObservablePoint>
					{
						new ObservablePoint(1,5),
						new ObservablePoint(1.5,7.6),
						new ObservablePoint(2,21),
						new ObservablePoint(5,25),
						new ObservablePoint(10,30),
						new ObservablePoint(17,30),
						new ObservablePoint(19.6,30),
						new ObservablePoint(30,40),
					}
				},
				new LineSeries
				{
					Title = "3~6 Power Frequency",
					Values = new ChartValues<ObservablePoint>
					{
						new ObservablePoint(5,5),
						new ObservablePoint(6.5,7.6),
						new ObservablePoint(7,21),
						new ObservablePoint(19.6,30),
						new ObservablePoint(30,40),
					}
				},
			};

			this.Chart.AxisX = new AxesCollection()
			{
				new LiveCharts.Wpf.Axis()
				{
					Title= "Minutes",
					Separator = new LiveCharts.Wpf.Separator()
					{
						Step = 5.0,
						IsEnabled = false
					}
				}
			};
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
					this.Body.Controls.Add(this.Chart);
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
