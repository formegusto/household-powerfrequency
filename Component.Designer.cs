namespace MetroUI
{
	partial class Component
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.Header = new MetroFramework.Controls.MetroPanel();
			this.Footer = new MetroFramework.Controls.MetroPanel();
			this.Body = new MetroFramework.Controls.MetroPanel();
			this.DayTabs = new MetroFramework.Controls.MetroTabControl();
			this.Sun = new MetroFramework.Controls.MetroTabPage();
			this.Mon = new MetroFramework.Controls.MetroTabPage();
			this.Tue = new MetroFramework.Controls.MetroTabPage();
			this.Wed = new MetroFramework.Controls.MetroTabPage();
			this.Thu = new MetroFramework.Controls.MetroTabPage();
			this.Fri = new MetroFramework.Controls.MetroTabPage();
			this.Sat = new MetroFramework.Controls.MetroTabPage();
			this.UIDSearch = new MetroFramework.Controls.MetroTextBox();
			this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
			this.LoadBtn = new MetroFramework.Controls.MetroButton();
			this.Header.SuspendLayout();
			this.Footer.SuspendLayout();
			this.Body.SuspendLayout();
			this.DayTabs.SuspendLayout();
			this.SuspendLayout();
			// 
			// Header
			// 
			this.Header.Controls.Add(this.DayTabs);
			this.Header.Dock = System.Windows.Forms.DockStyle.Top;
			this.Header.HorizontalScrollbarBarColor = true;
			this.Header.HorizontalScrollbarHighlightOnWheel = false;
			this.Header.HorizontalScrollbarSize = 10;
			this.Header.Location = new System.Drawing.Point(20, 60);
			this.Header.Name = "Header";
			this.Header.Size = new System.Drawing.Size(1060, 50);
			this.Header.TabIndex = 0;
			this.Header.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Header.VerticalScrollbarBarColor = true;
			this.Header.VerticalScrollbarHighlightOnWheel = false;
			this.Header.VerticalScrollbarSize = 10;
			// 
			// Footer
			// 
			this.Footer.Controls.Add(this.LoadBtn);
			this.Footer.Controls.Add(this.UIDSearch);
			this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Footer.HorizontalScrollbarBarColor = true;
			this.Footer.HorizontalScrollbarHighlightOnWheel = false;
			this.Footer.HorizontalScrollbarSize = 10;
			this.Footer.Location = new System.Drawing.Point(20, 730);
			this.Footer.Name = "Footer";
			this.Footer.Size = new System.Drawing.Size(1060, 50);
			this.Footer.TabIndex = 2;
			this.Footer.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Footer.VerticalScrollbarBarColor = true;
			this.Footer.VerticalScrollbarHighlightOnWheel = false;
			this.Footer.VerticalScrollbarSize = 10;
			// 
			// Body
			// 
			this.Body.Controls.Add(this.metroProgressSpinner1);
			this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Body.HorizontalScrollbarBarColor = true;
			this.Body.HorizontalScrollbarHighlightOnWheel = false;
			this.Body.HorizontalScrollbarSize = 10;
			this.Body.Location = new System.Drawing.Point(20, 110);
			this.Body.Name = "Body";
			this.Body.Size = new System.Drawing.Size(1060, 620);
			this.Body.TabIndex = 3;
			this.Body.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Body.VerticalScrollbarBarColor = true;
			this.Body.VerticalScrollbarHighlightOnWheel = false;
			this.Body.VerticalScrollbarSize = 10;
			// 
			// DayTabs
			// 
			this.DayTabs.Controls.Add(this.Sun);
			this.DayTabs.Controls.Add(this.Mon);
			this.DayTabs.Controls.Add(this.Tue);
			this.DayTabs.Controls.Add(this.Wed);
			this.DayTabs.Controls.Add(this.Thu);
			this.DayTabs.Controls.Add(this.Fri);
			this.DayTabs.Controls.Add(this.Sat);
			this.DayTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DayTabs.Location = new System.Drawing.Point(0, 0);
			this.DayTabs.Name = "DayTabs";
			this.DayTabs.SelectedIndex = 6;
			this.DayTabs.Size = new System.Drawing.Size(1060, 50);
			this.DayTabs.TabIndex = 2;
			this.DayTabs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.DayTabs.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.DayTabs.UseSelectable = true;
			// 
			// Sun
			// 
			this.Sun.HorizontalScrollbarBarColor = true;
			this.Sun.HorizontalScrollbarHighlightOnWheel = false;
			this.Sun.HorizontalScrollbarSize = 10;
			this.Sun.Location = new System.Drawing.Point(4, 38);
			this.Sun.Name = "Sun";
			this.Sun.Size = new System.Drawing.Size(1052, 8);
			this.Sun.TabIndex = 0;
			this.Sun.Text = "Sun";
			this.Sun.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Sun.VerticalScrollbarBarColor = true;
			this.Sun.VerticalScrollbarHighlightOnWheel = false;
			this.Sun.VerticalScrollbarSize = 10;
			// 
			// Mon
			// 
			this.Mon.HorizontalScrollbarBarColor = true;
			this.Mon.HorizontalScrollbarHighlightOnWheel = false;
			this.Mon.HorizontalScrollbarSize = 10;
			this.Mon.Location = new System.Drawing.Point(4, 38);
			this.Mon.Name = "Mon";
			this.Mon.Size = new System.Drawing.Size(1052, 8);
			this.Mon.TabIndex = 1;
			this.Mon.Text = "Mon";
			this.Mon.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Mon.VerticalScrollbarBarColor = true;
			this.Mon.VerticalScrollbarHighlightOnWheel = false;
			this.Mon.VerticalScrollbarSize = 10;
			// 
			// Tue
			// 
			this.Tue.HorizontalScrollbarBarColor = true;
			this.Tue.HorizontalScrollbarHighlightOnWheel = false;
			this.Tue.HorizontalScrollbarSize = 10;
			this.Tue.Location = new System.Drawing.Point(4, 38);
			this.Tue.Name = "Tue";
			this.Tue.Size = new System.Drawing.Size(1052, 8);
			this.Tue.TabIndex = 2;
			this.Tue.Text = "Tue";
			this.Tue.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Tue.VerticalScrollbarBarColor = true;
			this.Tue.VerticalScrollbarHighlightOnWheel = false;
			this.Tue.VerticalScrollbarSize = 10;
			// 
			// Wed
			// 
			this.Wed.HorizontalScrollbarBarColor = true;
			this.Wed.HorizontalScrollbarHighlightOnWheel = false;
			this.Wed.HorizontalScrollbarSize = 10;
			this.Wed.Location = new System.Drawing.Point(4, 38);
			this.Wed.Name = "Wed";
			this.Wed.Size = new System.Drawing.Size(1052, 8);
			this.Wed.TabIndex = 3;
			this.Wed.Text = "Wed";
			this.Wed.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Wed.VerticalScrollbarBarColor = true;
			this.Wed.VerticalScrollbarHighlightOnWheel = false;
			this.Wed.VerticalScrollbarSize = 10;
			// 
			// Thu
			// 
			this.Thu.HorizontalScrollbarBarColor = true;
			this.Thu.HorizontalScrollbarHighlightOnWheel = false;
			this.Thu.HorizontalScrollbarSize = 10;
			this.Thu.Location = new System.Drawing.Point(4, 38);
			this.Thu.Name = "Thu";
			this.Thu.Size = new System.Drawing.Size(1052, 8);
			this.Thu.TabIndex = 4;
			this.Thu.Text = "Thu";
			this.Thu.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Thu.VerticalScrollbarBarColor = true;
			this.Thu.VerticalScrollbarHighlightOnWheel = false;
			this.Thu.VerticalScrollbarSize = 10;
			// 
			// Fri
			// 
			this.Fri.HorizontalScrollbarBarColor = true;
			this.Fri.HorizontalScrollbarHighlightOnWheel = false;
			this.Fri.HorizontalScrollbarSize = 10;
			this.Fri.Location = new System.Drawing.Point(4, 38);
			this.Fri.Name = "Fri";
			this.Fri.Size = new System.Drawing.Size(1052, 8);
			this.Fri.TabIndex = 5;
			this.Fri.Text = "Fri";
			this.Fri.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Fri.VerticalScrollbarBarColor = true;
			this.Fri.VerticalScrollbarHighlightOnWheel = false;
			this.Fri.VerticalScrollbarSize = 10;
			// 
			// Sat
			// 
			this.Sat.HorizontalScrollbarBarColor = true;
			this.Sat.HorizontalScrollbarHighlightOnWheel = false;
			this.Sat.HorizontalScrollbarSize = 10;
			this.Sat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Sat.Location = new System.Drawing.Point(4, 38);
			this.Sat.Name = "Sat";
			this.Sat.Size = new System.Drawing.Size(1052, 8);
			this.Sat.TabIndex = 6;
			this.Sat.Text = "Sat";
			this.Sat.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Sat.VerticalScrollbarBarColor = true;
			this.Sat.VerticalScrollbarHighlightOnWheel = false;
			this.Sat.VerticalScrollbarSize = 10;
			// 
			// UIDSearch
			// 
			// 
			// 
			// 
			this.UIDSearch.CustomButton.Image = null;
			this.UIDSearch.CustomButton.Location = new System.Drawing.Point(452, 2);
			this.UIDSearch.CustomButton.Name = "";
			this.UIDSearch.CustomButton.Size = new System.Drawing.Size(45, 45);
			this.UIDSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.UIDSearch.CustomButton.TabIndex = 1;
			this.UIDSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.UIDSearch.CustomButton.UseSelectable = true;
			this.UIDSearch.CustomButton.Visible = false;
			this.UIDSearch.Dock = System.Windows.Forms.DockStyle.Left;
			this.UIDSearch.Lines = new string[0];
			this.UIDSearch.Location = new System.Drawing.Point(0, 0);
			this.UIDSearch.MaxLength = 32767;
			this.UIDSearch.Name = "UIDSearch";
			this.UIDSearch.PasswordChar = '\0';
			this.UIDSearch.PromptText = "UID";
			this.UIDSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.UIDSearch.SelectedText = "";
			this.UIDSearch.SelectionLength = 0;
			this.UIDSearch.SelectionStart = 0;
			this.UIDSearch.ShortcutsEnabled = true;
			this.UIDSearch.Size = new System.Drawing.Size(500, 50);
			this.UIDSearch.TabIndex = 2;
			this.UIDSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.UIDSearch.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.UIDSearch.UseSelectable = true;
			this.UIDSearch.WaterMark = "UID";
			this.UIDSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.UIDSearch.WaterMarkFont = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// metroProgressSpinner1
			// 
			this.metroProgressSpinner1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metroProgressSpinner1.Location = new System.Drawing.Point(392, 136);
			this.metroProgressSpinner1.Maximum = 100;
			this.metroProgressSpinner1.Name = "metroProgressSpinner1";
			this.metroProgressSpinner1.Size = new System.Drawing.Size(250, 250);
			this.metroProgressSpinner1.TabIndex = 2;
			this.metroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroProgressSpinner1.UseSelectable = true;
			// 
			// LoadBtn
			// 
			this.LoadBtn.Dock = System.Windows.Forms.DockStyle.Right;
			this.LoadBtn.Location = new System.Drawing.Point(900, 0);
			this.LoadBtn.Name = "LoadBtn";
			this.LoadBtn.Size = new System.Drawing.Size(160, 50);
			this.LoadBtn.TabIndex = 3;
			this.LoadBtn.Text = "로딩 테스트";
			this.LoadBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.LoadBtn.UseSelectable = true;
			// 
			// Component
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1100, 800);
			this.Controls.Add(this.Body);
			this.Controls.Add(this.Footer);
			this.Controls.Add(this.Header);
			this.Name = "Component";
			this.Resizable = false;
			this.Text = "KETI";
			this.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Load += new System.EventHandler(this.Component_Load);
			this.Header.ResumeLayout(false);
			this.Footer.ResumeLayout(false);
			this.Body.ResumeLayout(false);
			this.DayTabs.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroPanel Header;
		private MetroFramework.Controls.MetroPanel Footer;
		private MetroFramework.Controls.MetroPanel Body;
		private MetroFramework.Controls.MetroTabControl DayTabs;
		private MetroFramework.Controls.MetroTabPage Sun;
		private MetroFramework.Controls.MetroTabPage Mon;
		private MetroFramework.Controls.MetroTabPage Tue;
		private MetroFramework.Controls.MetroTabPage Wed;
		private MetroFramework.Controls.MetroTabPage Thu;
		private MetroFramework.Controls.MetroTabPage Fri;
		private MetroFramework.Controls.MetroTabPage Sat;
		private MetroFramework.Controls.MetroTextBox UIDSearch;
		private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
		private MetroFramework.Controls.MetroButton LoadBtn;
	}
}

