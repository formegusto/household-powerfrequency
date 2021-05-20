using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using hhpf.Entity;
using hhpf.Common;

namespace hhpf.Atom
{
	public partial class DataComponent : MetroFramework.Forms.MetroForm
	{
		public DataComponent(string uid, List<PowerFrequency>[] pf, TimeSlot ts)
		{
			InitializeComponent();

			this.Text = uid;


		}
	}
}
