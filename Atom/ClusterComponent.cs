using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

using hhpf.Entity;
using hhpf.Common;
using hhpf.Utils;

namespace hhpf.Atom
{
	public partial class ClusterComponent : MetroFramework.Forms.MetroForm
	{
		private List<MetroFramework.Controls.MetroCheckBox> VisibleGrp;
		public ClusterComponent(List<PowerFrequency>[] cpf, TimeSlot ts)
		{
			InitializeComponent();
			this.VisibleGrp = new List<MetroFramework.Controls.MetroCheckBox>() { 
				this.Visible1,
				this.Visible2,
				this.Visible3,
				this.Visible4,
				this.Visible5,
				this.Visible6,
				this.Visible7,
				this.Visible8
			};
			
			int startHours = 0;
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

				this.ClusterChart.Series.Add(ls);
				this.VisibleGrp[p].Text =
					string.Format("{0}~{1}h", startHours, startHours += TimeSlotUtils.TimeSlotToHours(ts));
				this.VisibleGrp[p].Checked = true;
				this.VisibleGrp[p].Click += Visible_Toggled;
				this.VisibleContainer.Controls.Add(this.VisibleGrp[p]);
			}
				
		}
		private void Visible_Toggled(object sender, EventArgs e)
		{
			string tag = ((MetroFramework.Controls.MetroCheckBox)sender).Tag.ToString();
			bool isVisibility = ((LineSeries)this.ClusterChart.Series[int.Parse(tag)]).Visibility == System.Windows.Visibility.Visible;
			((LineSeries)this.ClusterChart.Series[int.Parse(tag)]).Visibility = isVisibility ?
				System.Windows.Visibility.Hidden
				:
				System.Windows.Visibility.Visible;
		}
	}
}
