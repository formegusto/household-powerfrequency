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
			this.UIDContainer = new MetroFramework.Controls.MetroPanel();
			this.UIDListView = new MetroFramework.Controls.MetroListView();
			this.loading = new MetroFramework.Controls.MetroProgressSpinner();
			this.UIDContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// UIDContainer
			// 
			this.UIDContainer.Controls.Add(this.loading);
			this.UIDContainer.HorizontalScrollbarBarColor = true;
			this.UIDContainer.HorizontalScrollbarHighlightOnWheel = false;
			this.UIDContainer.HorizontalScrollbarSize = 10;
			this.UIDContainer.Location = new System.Drawing.Point(23, 63);
			this.UIDContainer.Name = "UIDContainer";
			this.UIDContainer.Size = new System.Drawing.Size(254, 514);
			this.UIDContainer.TabIndex = 0;
			this.UIDContainer.UseCustomBackColor = true;
			this.UIDContainer.VerticalScrollbarBarColor = true;
			this.UIDContainer.VerticalScrollbarHighlightOnWheel = false;
			this.UIDContainer.VerticalScrollbarSize = 10;
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
			// 
			// loading
			// 
			this.loading.Location = new System.Drawing.Point(102, 232);
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
			this.ClientSize = new System.Drawing.Size(300, 600);
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

		private MetroFramework.Controls.MetroPanel UIDContainer;
		private MetroFramework.Controls.MetroListView UIDListView;
		private MetroFramework.Controls.MetroProgressSpinner loading;
	}
}