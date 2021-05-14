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

using MetroUI.Entity;
using MetroUI.Common;
using MetroUI.Utils;

namespace MetroUI.Atom
{
	public partial class ClusterComponent : MetroFramework.Forms.MetroForm
	{
		public ClusterComponent(List<PowerFrequency>[] cpf, TimeSlot ts)
		{
			InitializeComponent();

			Console.WriteLine("Cluster Component");
			
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
					Title = string.Format("Cluster {0}~{1}h Power Frequency", startHours, startHours += TimeSlotUtils.TimeSlotToHours(ts)),
					Values = cv
				};

				this.ClusterChart.Series.Add(ls);
			}
				
		}
	}
}
