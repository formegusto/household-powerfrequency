using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hhpf.Atom
{
	public partial class UIDComponent : MetroFramework.Forms.MetroForm
	{
		public UIDComponent()
		{
			InitializeComponent();
		}

		public void Load_Household_DataSet()
		{
			Task.Run(() =>
			{
				this.Invoke((System.Action) (() =>
				{
					string path = System.Windows.Forms.Application.StartupPath + @"\household_uid\household_uid.csv";
					StreamReader sr = new StreamReader(path, Encoding.GetEncoding("euc-kr"));
					System.Windows.Forms.ListViewGroup UIDGroup = new System.Windows.Forms.ListViewGroup("UID", System.Windows.Forms.HorizontalAlignment.Left);
					UIDGroup.Header = "UID";
					UIDGroup.Name = "UIDGroup";
					this.UIDListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] { UIDGroup });

					while (!sr.EndOfStream)
					{
						string line = sr.ReadLine();
						System.Windows.Forms.ListViewItem uidItem = new System.Windows.Forms.ListViewItem(line);
						uidItem.Group = UIDGroup;
						this.UIDListView.Items.Add(uidItem);
					}


					sr.Close();
				}));
			});
	
			this.UIDContainer.Controls.Clear();
			this.UIDContainer.Controls.Add(this.UIDListView);
		}
		private void UIDComponent_Shown(object sender, EventArgs e)
		{
			Delay(2000);

			Load_Household_DataSet();
		}

		private static DateTime Delay(int MS)
		{
			DateTime ThisMoment = DateTime.Now;
			TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
			DateTime AfterWards = ThisMoment.Add(duration);

			while (AfterWards >= ThisMoment)
			{
				System.Windows.Forms.Application.DoEvents();
				ThisMoment = DateTime.Now;
			}

			return DateTime.Now;
		}

		private void UIDListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(this.UIDListView.SelectedItems.Count != 0)
				Console.WriteLine(this.UIDListView.SelectedItems[0]);
		}
	}
}
