namespace hhpf.Atom
{
	partial class ClusterComponent
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
			this.ClusterChart = new LiveCharts.WinForms.CartesianChart();
			this.ChartContainer = new MetroFramework.Controls.MetroPanel();
			this.ChartContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// ClusterChart
			// 
			this.ClusterChart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ClusterChart.Location = new System.Drawing.Point(0, 0);
			this.ClusterChart.Name = "ClusterChart";
			this.ClusterChart.Size = new System.Drawing.Size(454, 400);
			this.ClusterChart.TabIndex = 2;
			this.ClusterChart.Text = "cartesianChart1";
			// 
			// ChartContainer
			// 
			this.ChartContainer.Controls.Add(this.ClusterChart);
			this.ChartContainer.HorizontalScrollbarBarColor = true;
			this.ChartContainer.HorizontalScrollbarHighlightOnWheel = false;
			this.ChartContainer.HorizontalScrollbarSize = 10;
			this.ChartContainer.Location = new System.Drawing.Point(23, 77);
			this.ChartContainer.Name = "ChartContainer";
			this.ChartContainer.Size = new System.Drawing.Size(454, 400);
			this.ChartContainer.TabIndex = 0;
			this.ChartContainer.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.ChartContainer.VerticalScrollbarBarColor = true;
			this.ChartContainer.VerticalScrollbarHighlightOnWheel = false;
			this.ChartContainer.VerticalScrollbarSize = 10;
			// 
			// ClusterComponent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 500);
			this.Controls.Add(this.ChartContainer);
			this.Name = "ClusterComponent";
			this.Resizable = false;
			this.Text = "Cluster Power Frequency";
			this.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.ChartContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private LiveCharts.WinForms.CartesianChart ClusterChart;
		private MetroFramework.Controls.MetroPanel ChartContainer;
	}
}