namespace hhpf.Atom
{
	partial class UIDComponent
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
			this.UIDListView = new MetroFramework.Controls.MetroListView();
			this.UIDContainer = new MetroFramework.Controls.MetroPanel();
			this.loading = new MetroFramework.Controls.MetroProgressSpinner();
			this.UIDContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// UIDListView
			// 
			this.UIDListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UIDListView.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.UIDListView.FullRowSelect = true;
			this.UIDListView.Location = new System.Drawing.Point(0, 0);
			this.UIDListView.Name = "UIDListView";
			this.UIDListView.OwnerDraw = true;
			this.UIDListView.Size = new System.Drawing.Size(254, 514);
			this.UIDListView.TabIndex = 2;
			this.UIDListView.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.UIDListView.UseCompatibleStateImageBehavior = false;
			this.UIDListView.UseSelectable = true;
			this.UIDListView.View = System.Windows.Forms.View.List;
			this.UIDListView.SelectedIndexChanged += new System.EventHandler(this.UIDListView_SelectedIndexChanged);
			// 
			// UIDContainer
			// 
			this.UIDContainer.Controls.Add(this.loading);
			this.UIDContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.UIDContainer.HorizontalScrollbarBarColor = true;
			this.UIDContainer.HorizontalScrollbarHighlightOnWheel = false;
			this.UIDContainer.HorizontalScrollbarSize = 10;
			this.UIDContainer.Location = new System.Drawing.Point(20, 63);
			this.UIDContainer.Name = "UIDContainer";
			this.UIDContainer.Size = new System.Drawing.Size(460, 517);
			this.UIDContainer.TabIndex = 1;
			this.UIDContainer.UseCustomBackColor = true;
			this.UIDContainer.VerticalScrollbarBarColor = true;
			this.UIDContainer.VerticalScrollbarHighlightOnWheel = false;
			this.UIDContainer.VerticalScrollbarSize = 10;
			// 
			// loading
			// 
			this.loading.Location = new System.Drawing.Point(205, 233);
			this.loading.Maximum = 100;
			this.loading.Name = "loading";
			this.loading.Size = new System.Drawing.Size(50, 50);
			this.loading.TabIndex = 2;
			this.loading.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.loading.UseSelectable = true;
			// 
			// UIDComponent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 600);
			this.Controls.Add(this.UIDContainer);
			this.Name = "UIDComponent";
			this.Resizable = false;
			this.Text = "UIDList";
			this.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Shown += new System.EventHandler(this.UIDComponent_Shown);
			this.UIDContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private MetroFramework.Controls.MetroListView UIDListView;
		private MetroFramework.Controls.MetroPanel UIDContainer;
		private MetroFramework.Controls.MetroProgressSpinner loading;
	}
}