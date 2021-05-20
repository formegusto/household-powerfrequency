namespace hhpf.Atom
{
	partial class DataComponent
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.DataChart = new LiveCharts.WinForms.CartesianChart();
			this.metroPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// metroPanel1
			// 
			this.metroPanel1.Controls.Add(this.DataChart);
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 10;
			this.metroPanel1.Location = new System.Drawing.Point(23, 63);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Size = new System.Drawing.Size(554, 514);
			this.metroPanel1.TabIndex = 0;
			this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			// 
			// DataChart
			// 
			this.DataChart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataChart.Location = new System.Drawing.Point(0, 0);
			this.DataChart.Name = "DataChart";
			this.DataChart.Size = new System.Drawing.Size(554, 514);
			this.DataChart.TabIndex = 1;
			this.DataChart.Text = "cartesianChart1";
			// 
			// DataComponent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 600);
			this.Controls.Add(this.metroPanel1);
			this.Name = "DataComponent";
			this.Resizable = false;
			this.Text = "UIDName";
			this.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroPanel metroPanel1;
		private LiveCharts.WinForms.CartesianChart DataChart;
	}
}