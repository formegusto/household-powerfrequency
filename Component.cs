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

using MetroUI.Entity;

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
					Title= "Power",
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
				case COMMON_ACTIONS.START_LOADING:
					this.ChartContainer.Controls.Clear();
					this.ChartContainer.Controls.Add(this.Spinner);

					break;
				case COMMON_ACTIONS.STOP_LOADING:
					this.ChartContainer.Controls.Clear();

					break;
				case MODEL_ACTIONS.LOAD_EXCEL_SUCCESS:
					this.DayTabs.SelectTab(0);
					this.changed(this, new ViewEventArgs(VIEW_ACTIONS.REQUEST_DAYDATA, 0));

					break;
				case VIEW_ACTIONS.REQUEST_DAYDATA_SUCCESS:
					this.Chart.AxisX.Clear();
					this.Chart.Series.Clear();
					this.ChartContainer.Controls.Add(this.Chart);
					ConfigChart(e.powerFrequencies);

					break;
				default:
					break;
			}
		}
		public void ConfigChart(List<PowerFrequency>[] pf)
		{
			int startHours = 0;
			for(int p = 0; p < pf.Length; p++)
			{
				ChartValues<ObservablePoint> cv = new ChartValues<ObservablePoint>();
				pf[p].ForEach((pp) =>
				{
					cv.Add(new ObservablePoint(pp.wh, pp.frequency));
				});
				LineSeries ls = new LineSeries
				{
					Title = string.Format("{0}~{1}h PowerFrequency", startHours, startHours += 3),
					Values = cv
				};
				this.Chart.Series.Add(ls);
			}
		}
		private void LoadBtn_Click(object sender, EventArgs e) => this.controller.Dispatch(MODEL_ACTIONS.LOAD_EXCEL);
		private void UIDSearch_Changed(object sender, EventArgs e) => this.changed(this, new ViewEventArgs(VIEW_ACTIONS.CHANGE_KEYWORD, this.UIDSearch.Text));
		private void DayTabs_Selected(object sender, TabControlEventArgs e) => this.changed(this, new ViewEventArgs(VIEW_ACTIONS.REQUEST_DAYDATA, e.TabPageIndex));
		private void Visible_Toggled(object sender, EventArgs e)
		{
			string tag = ((MetroFramework.Controls.MetroCheckBox) sender).Tag.ToString();
			bool isVisibility = ((LineSeries)this.Chart.Series[int.Parse(tag)]).Visibility == System.Windows.Visibility.Visible;
			((LineSeries) this.Chart.Series[int.Parse(tag)]).Visibility = isVisibility ? 
				System.Windows.Visibility.Hidden
				:
				System.Windows.Visibility.Visible;
		}
	}
}
