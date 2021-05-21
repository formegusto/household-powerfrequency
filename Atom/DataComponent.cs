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
	public partial class DataComponent : MetroFramework.Forms.MetroForm
	{
		public DataComponent(string uid, List<PowerFrequency>[] pf, TimeSlot ts)
		{
			InitializeComponent();

			this.Text = uid;

			int startHours = 0;
			for (int p = 0; p < pf.Length; p++)
			{
				ChartValues<ObservablePoint> cv = new ChartValues<ObservablePoint>();
				// cv.Add(new ObservablePoint(0, 0));
				pf[p].ForEach((pp) =>
				{
					cv.Add(new ObservablePoint(pp.wh, pp.frequency));
				});

				LineSeries ls = new LineSeries
				{
					Title = string.Format(uid + " {0}~{1}h Power Frequency", startHours, startHours += TimeSlotUtils.TimeSlotToHours(ts)),
					Values = cv
				};

				this.DataChart.Series.Add(ls);
			}
		}
	}
}
