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
using MetroUI.Utils;
using MetroUI.Atom;

namespace MetroUI
{
	public partial class Component : MetroFramework.Forms.MetroForm, IView, IModelObserver
	{
		public event ViewHandler<IView> changed;
		public List<MetroFramework.Controls.MetroCheckBox> VisibleGroup;
		ClusterComponent clusterComponent;
		IController controller;
		public Component()
		{
			InitializeComponent();

			this.VisibleGroup = new List<MetroFramework.Controls.MetroCheckBox>();
			//
			// VisibleGroup
			//
			this.VisibleGroup.Add(Visible_1);
			this.VisibleGroup.Add(Visible_2);
			this.VisibleGroup.Add(Visible_3);
			this.VisibleGroup.Add(Visible_4);
			this.VisibleGroup.Add(Visible_5);
			this.VisibleGroup.Add(Visible_6);
			this.VisibleGroup.Add(Visible_7);
			this.VisibleGroup.Add(Visible_8);
			//
			// ClusterComponent Init
			//
			this.clusterComponent = null;
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
					this.changed(this, new ViewEventArgs(VIEW_ACTIONS.REQUEST_DAYDATA, this.DayTabs.SelectedIndex));

					break;
				case VIEW_ACTIONS.REQUEST_DAYDATA_SUCCESS:
					this.Chart.AxisX.Clear();
					this.Chart.Series.Clear();
					
					
					Task.Run(() =>
					{
						ConfigChart(e.powerFrequencies, e.clusterPowerFrequencies, e.timeslot);
					});

					this.ChartContainer.Controls.Add(this.Chart);
					
					this.clusterComponent = new ClusterComponent();
					this.clusterComponent.Show();

					break;
				case MODEL_ACTIONS.REQUIRE_RELOAD:
					if (this.clusterComponent != null)
					{
						this.clusterComponent.Close();
						this.clusterComponent.Dispose();
					}
					LoadBtn_Click(null, null);

					break;
				default:
					break;
			}
		}
		public void ConfigChart(List<PowerFrequency>[] pf, List<PowerFrequency>[] cpf, TimeSlot ts)
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
						Title = string.Format("{0}~{1}h Power Frequency", startHours, startHours + TimeSlotUtils.TimeSlotToHours(ts)),
						Values = cv
					};
					this.Chart.Series.Add(ls);
					this.VisibleGroup[p].Checked = true;
					this.VisibleGroup[p].Text = string.Format("{0}~{1}h", startHours, startHours += TimeSlotUtils.TimeSlotToHours(ts));
					this.CheckBoxContainer.Controls.Add(this.VisibleGroup[p]);
				}
				/*
				startHours = 0;
				for (int p = 0; p < cpf.Length; p++)
				{
					ChartValues<ObservablePoint> cv = new ChartValues<ObservablePoint>();
					cpf[p].ForEach((pp) =>
					{
						cv.Add(new ObservablePoint(pp.wh, pp.frequency));
					});

					LineSeries ls = new LineSeries
					{
						Title = string.Format("Cluster {0}~{1}h Power Frequency", startHours, startHours + TimeSlotUtils.TimeSlotToHours(ts)),
						Values = cv
					};

					this.Chart.Series.Add(ls);
				}
				*/
			}));
		}
		private void Clear_Visible() => this.Invoke((System.Action)(() =>
		   {
			   this.VisibleGroup.ForEach((v) =>
			   {
				   if (this.CheckBoxContainer.Controls.Contains(v))
				   {
					   this.CheckBoxContainer.Controls.Remove(v);
				   }
			   });
		   }));
		private void LoadBtn_Click(object sender, EventArgs e) {
			Clear_Visible();
			this.controller.Dispatch(MODEL_ACTIONS.LOAD_EXCEL);
		}
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
		private void SeasonTabs_Selected(object sender, TabControlEventArgs e)
		{
			Season selectedSeason =  Season.ALL;

			switch (e.TabPageIndex)
			{
				case 0:
					selectedSeason = Season.ALL;
					break;
				case 1:
					selectedSeason = Season.SPRING;
					break;
				case 2:
					selectedSeason = Season.SUMMER;
					break;
				case 3:
					selectedSeason = Season.AUTUMN;
					break;
				case 4:
					selectedSeason = Season.WINTER;
					break;
			}

			this.changed(this, new ViewEventArgs(VIEW_ACTIONS.CHANGE_SEASON, selectedSeason));
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
