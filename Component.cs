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
using hhpf.Common;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using System.Windows.Threading;

using hhpf.Entity;
using hhpf.Utils;
using hhpf.Atom;

namespace hhpf
{
	public partial class Component : MetroFramework.Forms.MetroForm, IView, IModelObserver
	{
		public event ViewHandler<IView> changed;
		public List<MetroFramework.Controls.MetroCheckBox> VisibleGroup;
		public IController controller;
		ClusterComponent clusterComponent;
		UIDComponent uidComponent;
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
						ConfigChart(e.powerFrequencies, e.maxWh,e.timeslot);
					});

					this.ChartContainer.Controls.Add(this.Chart);

					if (this.clusterComponent != null)
					{
						this.clusterComponent.Close();
						this.clusterComponent.Dispose();
					}

					this.clusterComponent = new ClusterComponent(e.clusterPowerFrequencies, e.timeslot);
					this.clusterComponent.Show();

					break;
				case MODEL_ACTIONS.REQUIRE_RELOAD:
					LoadBtn_Click(null, null);

					break;
				case VIEW_ACTIONS.AUTO_DRAW_SUCCESS:
					this.UIDSearch.Text = e.keyword;
					this.AutoDrawBtn.Text = "Next Auto Draw";
					this.changed(this, new ViewEventArgs(VIEW_ACTIONS.REQUEST_DAYDATA, this.DayTabs.SelectedIndex));

					break;
				case VIEW_ACTIONS.AUTO_LOAD_SUCCESS:
					this.changed(this, new ViewEventArgs(VIEW_ACTIONS.AUTO_LOAD_NEXT, this.DayTabs.SelectedIndex));

					break;
				case VIEW_ACTIONS.AUTO_LOAD_LAST:
					DataComponent dc = new DataComponent(e.keyword, e.powerFrequencies, e.timeslot);
					dc.Show();

					break;
				case VIEW_ACTIONS.AUTO_LOAD_NEXT_SUCCESS:
					DataComponent dc2 = new DataComponent(e.keyword, e.powerFrequencies, e.timeslot);
					dc2.Show();

					this.changed(this, new ViewEventArgs(VIEW_ACTIONS.AUTO_LOAD));
					break;
				default:
					break;
			}
		}
		public void ConfigChart(List<PowerFrequency>[] pf, double maxWh, TimeSlot ts)
		{
			this.Invoke((System.Action)( () => {
				int startHours = 0;
				for (int p = 0; p < pf.Length; p++)
				{
					ChartValues<ObservablePoint> cv = new ChartValues<ObservablePoint>();
					// cv.Add(new ObservablePoint(0, 0));
					pf[p].ForEach((pp) =>
					{
						cv.Add(new ObservablePoint(pp.wh, pp.frequency));
					});
					/*
					if (pf[p][pf[p].Count() - 1].wh < maxWh)
						cv.Add(new ObservablePoint(maxWh, 0));
					*/
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
			}));
		}
		public void Change_UIDText(string text)
		{
			this.UIDSearch.Text = text;
			LoadBtn_Click(null, null);
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
		private void UIDBtn_Click(object sender, EventArgs e)
		{
			uidComponent = new UIDComponent();
			uidComponent.UIDFormEvent += Change_UIDText;
			uidComponent.ShowDialog();
		}
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
		private void SeasonTabs_Selected(object sender, TabControlEventArgs e) => this.changed(this, new ViewEventArgs(VIEW_ACTIONS.CHANGE_SEASON, (Season)e.TabPageIndex));
		private void UIDSearch_Changed(object sender, EventArgs e) => this.changed(this, new ViewEventArgs(VIEW_ACTIONS.CHANGE_KEYWORD, this.UIDSearch.Text));
		private void DayTabs_Selected(object sender, TabControlEventArgs e) => this.changed(this, new ViewEventArgs(VIEW_ACTIONS.CHANGE_DAY, (hhpf.Common.Day) e.TabPageIndex));

		private void AutoLoadBtn_Click(object sender, EventArgs e) => this.changed(this, new ViewEventArgs(VIEW_ACTIONS.AUTO_LOAD));
		private void AutoDrawBtn_Click(object sender, EventArgs e) => this.changed(this, new ViewEventArgs(VIEW_ACTIONS.AUTO_DRAW));
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
