using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroUI.Common;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using System.Windows.Threading;

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
					Task.Run(() =>
					{
						ConfigChart(e.powerFrequencies);
					});
					
					break;
				default:
					break;
			}
		}
		public void ConfigChart(List<PowerFrequency>[] pf)
		{
			this.Invoke((System.Action)( () => {
				int startHours = 0;
				for (int p = 0; p < pf.Length; p++)
				{
					ChartValues<ObservablePoint> cv = new ChartValues<ObservablePoint>();
					pf[p].ForEach((pp) =>
					{
						cv.Add(new ObservablePoint(pp.wh, pp.frequency));
					});

					LineSeries ls = new LineSeries
					{
						Title = string.Format("{0}~{1}h Power Frequency", startHours, startHours += 3),
						Values = cv
					};
					this.Chart.Series.Add(ls);
				}
			}));
		}
		private void LoadBtn_Click(object sender, EventArgs e) => this.controller.Dispatch(MODEL_ACTIONS.LOAD_EXCEL);
		private void Timeslot_Changed(object sender, EventArgs e) 
		{
			MetroFramework.Controls.MetroRadioButton actionBtn = ((MetroFramework.Controls.MetroRadioButton)sender);
			if (actionBtn.Checked)
			{
				string tag = actionBtn.Tag.ToString();
				TimeSlot timeslot = (TimeSlot)int.Parse(tag);

				this.changed(this, new ViewEventArgs(VIEW_ACTIONS.CHANGE_TIMESLOT, timeslot));
			}
		}
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
