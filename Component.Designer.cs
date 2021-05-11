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
			this.SeasonPanel = new MetroFramework.Controls.MetroPanel();
			this.SeasonControlTabs = new MetroFramework.Controls.MetroTabControl();
			this.Spring = new MetroFramework.Controls.MetroTabPage();
			this.Summer = new MetroFramework.Controls.MetroTabPage();
			this.Autumn = new MetroFramework.Controls.MetroTabPage();
			this.Winter = new MetroFramework.Controls.MetroTabPage();
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.DayTabs = new MetroFramework.Controls.MetroTabControl();
			this.Sun = new MetroFramework.Controls.MetroTabPage();
			this.Sat = new MetroFramework.Controls.MetroTabPage();
			this.Mon = new MetroFramework.Controls.MetroTabPage();
			this.Tue = new MetroFramework.Controls.MetroTabPage();
			this.Wed = new MetroFramework.Controls.MetroTabPage();
			this.Thu = new MetroFramework.Controls.MetroTabPage();
			this.Fri = new MetroFramework.Controls.MetroTabPage();
			this.Footer = new MetroFramework.Controls.MetroPanel();
			this.LoadBtn = new MetroFramework.Controls.MetroButton();
			this.UIDSearch = new MetroFramework.Controls.MetroTextBox();
			this.Body = new MetroFramework.Controls.MetroPanel();
			this.CheckBoxContainer = new MetroFramework.Controls.MetroPanel();
			this.Timeslot_24h = new MetroFramework.Controls.MetroRadioButton();
			this.Timeslot_12h = new MetroFramework.Controls.MetroRadioButton();
			this.Timeslot_8h = new MetroFramework.Controls.MetroRadioButton();
			this.Timeslot_6h = new MetroFramework.Controls.MetroRadioButton();
			this.Timeslot_4h = new MetroFramework.Controls.MetroRadioButton();
			this.Timeslot_3h = new MetroFramework.Controls.MetroRadioButton();
			this.Visible24H = new MetroFramework.Controls.MetroCheckBox();
			this.Visible21H = new MetroFramework.Controls.MetroCheckBox();
			this.Visible18H = new MetroFramework.Controls.MetroCheckBox();
			this.Visible15H = new MetroFramework.Controls.MetroCheckBox();
			this.Visible12H = new MetroFramework.Controls.MetroCheckBox();
			this.Visible9H = new MetroFramework.Controls.MetroCheckBox();
			this.Visible6H = new MetroFramework.Controls.MetroCheckBox();
			this.Visible3H = new MetroFramework.Controls.MetroCheckBox();
			this.Chart = new LiveCharts.WinForms.CartesianChart();
			this.Spinner = new MetroFramework.Controls.MetroProgressSpinner();
			this.ChartContainer = new MetroFramework.Controls.MetroPanel();
			this.Header.SuspendLayout();
			this.SeasonPanel.SuspendLayout();
			this.SeasonControlTabs.SuspendLayout();
			this.metroPanel1.SuspendLayout();
			this.DayTabs.SuspendLayout();
			this.Footer.SuspendLayout();
			this.Body.SuspendLayout();
			this.CheckBoxContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// Header
			// 
			this.Header.Controls.Add(this.SeasonPanel);
			this.Header.Controls.Add(this.metroPanel1);
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
			// SeasonPanel
			// 
			this.SeasonPanel.Controls.Add(this.SeasonControlTabs);
			this.SeasonPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.SeasonPanel.HorizontalScrollbarBarColor = true;
			this.SeasonPanel.HorizontalScrollbarHighlightOnWheel = false;
			this.SeasonPanel.HorizontalScrollbarSize = 10;
			this.SeasonPanel.Location = new System.Drawing.Point(770, 0);
			this.SeasonPanel.Name = "SeasonPanel";
			this.SeasonPanel.Size = new System.Drawing.Size(290, 50);
			this.SeasonPanel.TabIndex = 5;
			this.SeasonPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.SeasonPanel.VerticalScrollbarBarColor = true;
			this.SeasonPanel.VerticalScrollbarHighlightOnWheel = false;
			this.SeasonPanel.VerticalScrollbarSize = 10;
			// 
			// SeasonControlTabs
			// 
			this.SeasonControlTabs.Controls.Add(this.Spring);
			this.SeasonControlTabs.Controls.Add(this.Summer);
			this.SeasonControlTabs.Controls.Add(this.Autumn);
			this.SeasonControlTabs.Controls.Add(this.Winter);
			this.SeasonControlTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SeasonControlTabs.ItemSize = new System.Drawing.Size(54, 34);
			this.SeasonControlTabs.Location = new System.Drawing.Point(0, 0);
			this.SeasonControlTabs.Name = "SeasonControlTabs";
			this.SeasonControlTabs.SelectedIndex = 3;
			this.SeasonControlTabs.Size = new System.Drawing.Size(290, 50);
			this.SeasonControlTabs.TabIndex = 11;
			this.SeasonControlTabs.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.SeasonControlTabs.UseSelectable = true;
			// 
			// Spring
			// 
			this.Spring.HorizontalScrollbarBarColor = true;
			this.Spring.HorizontalScrollbarHighlightOnWheel = false;
			this.Spring.HorizontalScrollbarSize = 10;
			this.Spring.Location = new System.Drawing.Point(4, 38);
			this.Spring.Name = "Spring";
			this.Spring.Size = new System.Drawing.Size(282, 8);
			this.Spring.TabIndex = 0;
			this.Spring.Text = "Spring";
			this.Spring.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Spring.VerticalScrollbarBarColor = true;
			this.Spring.VerticalScrollbarHighlightOnWheel = false;
			this.Spring.VerticalScrollbarSize = 10;
			// 
			// Summer
			// 
			this.Summer.HorizontalScrollbarBarColor = true;
			this.Summer.HorizontalScrollbarHighlightOnWheel = false;
			this.Summer.HorizontalScrollbarSize = 10;
			this.Summer.Location = new System.Drawing.Point(4, 38);
			this.Summer.Name = "Summer";
			this.Summer.Size = new System.Drawing.Size(282, 8);
			this.Summer.TabIndex = 1;
			this.Summer.Text = "Summer";
			this.Summer.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Summer.VerticalScrollbarBarColor = true;
			this.Summer.VerticalScrollbarHighlightOnWheel = false;
			this.Summer.VerticalScrollbarSize = 10;
			// 
			// Autumn
			// 
			this.Autumn.HorizontalScrollbarBarColor = true;
			this.Autumn.HorizontalScrollbarHighlightOnWheel = false;
			this.Autumn.HorizontalScrollbarSize = 10;
			this.Autumn.Location = new System.Drawing.Point(4, 38);
			this.Autumn.Name = "Autumn";
			this.Autumn.Size = new System.Drawing.Size(282, 8);
			this.Autumn.TabIndex = 2;
			this.Autumn.Text = "Autumn";
			this.Autumn.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Autumn.VerticalScrollbarBarColor = true;
			this.Autumn.VerticalScrollbarHighlightOnWheel = false;
			this.Autumn.VerticalScrollbarSize = 10;
			// 
			// Winter
			// 
			this.Winter.HorizontalScrollbarBarColor = true;
			this.Winter.HorizontalScrollbarHighlightOnWheel = false;
			this.Winter.HorizontalScrollbarSize = 10;
			this.Winter.Location = new System.Drawing.Point(4, 38);
			this.Winter.Name = "Winter";
			this.Winter.Size = new System.Drawing.Size(282, 8);
			this.Winter.TabIndex = 3;
			this.Winter.Text = "Winter";
			this.Winter.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Winter.VerticalScrollbarBarColor = true;
			this.Winter.VerticalScrollbarHighlightOnWheel = false;
			this.Winter.VerticalScrollbarSize = 10;
			// 
			// metroPanel1
			// 
			this.metroPanel1.Controls.Add(this.DayTabs);
			this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 10;
			this.metroPanel1.Location = new System.Drawing.Point(0, 0);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Size = new System.Drawing.Size(768, 50);
			this.metroPanel1.TabIndex = 4;
			this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			// 
			// DayTabs
			// 
			this.DayTabs.Controls.Add(this.Sun);
			this.DayTabs.Controls.Add(this.Sat);
			this.DayTabs.Controls.Add(this.Mon);
			this.DayTabs.Controls.Add(this.Tue);
			this.DayTabs.Controls.Add(this.Wed);
			this.DayTabs.Controls.Add(this.Thu);
			this.DayTabs.Controls.Add(this.Fri);
			this.DayTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DayTabs.Location = new System.Drawing.Point(0, 0);
			this.DayTabs.Name = "DayTabs";
			this.DayTabs.SelectedIndex = 0;
			this.DayTabs.Size = new System.Drawing.Size(768, 50);
			this.DayTabs.TabIndex = 11;
			this.DayTabs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.DayTabs.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.DayTabs.UseSelectable = true;
			this.DayTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.DayTabs_Selected);
			// 
			// Sun
			// 
			this.Sun.HorizontalScrollbarBarColor = true;
			this.Sun.HorizontalScrollbarHighlightOnWheel = false;
			this.Sun.HorizontalScrollbarSize = 10;
			this.Sun.Location = new System.Drawing.Point(4, 38);
			this.Sun.Name = "Sun";
			this.Sun.Size = new System.Drawing.Size(760, 8);
			this.Sun.TabIndex = 0;
			this.Sun.Text = "Sun";
			this.Sun.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Sun.VerticalScrollbarBarColor = true;
			this.Sun.VerticalScrollbarHighlightOnWheel = false;
			this.Sun.VerticalScrollbarSize = 10;
			// 
			// Sat
			// 
			this.Sat.HorizontalScrollbarBarColor = true;
			this.Sat.HorizontalScrollbarHighlightOnWheel = false;
			this.Sat.HorizontalScrollbarSize = 10;
			this.Sat.Location = new System.Drawing.Point(4, 38);
			this.Sat.Name = "Sat";
			this.Sat.Size = new System.Drawing.Size(760, 8);
			this.Sat.TabIndex = 5;
			this.Sat.Text = "Sat";
			this.Sat.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Sat.VerticalScrollbarBarColor = true;
			this.Sat.VerticalScrollbarHighlightOnWheel = false;
			this.Sat.VerticalScrollbarSize = 10;
			// 
			// Mon
			// 
			this.Mon.HorizontalScrollbarBarColor = true;
			this.Mon.HorizontalScrollbarHighlightOnWheel = false;
			this.Mon.HorizontalScrollbarSize = 10;
			this.Mon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Mon.Location = new System.Drawing.Point(4, 38);
			this.Mon.Name = "Mon";
			this.Mon.Size = new System.Drawing.Size(760, 8);
			this.Mon.TabIndex = 6;
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
			this.Tue.Size = new System.Drawing.Size(760, 8);
			this.Tue.TabIndex = 1;
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
			this.Wed.Size = new System.Drawing.Size(760, 8);
			this.Wed.TabIndex = 2;
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
			this.Thu.Size = new System.Drawing.Size(760, 8);
			this.Thu.TabIndex = 3;
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
			this.Fri.Size = new System.Drawing.Size(760, 8);
			this.Fri.TabIndex = 4;
			this.Fri.Text = "Fri";
			this.Fri.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Fri.VerticalScrollbarBarColor = true;
			this.Fri.VerticalScrollbarHighlightOnWheel = false;
			this.Fri.VerticalScrollbarSize = 10;
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
			this.Footer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.Footer.Size = new System.Drawing.Size(1060, 50);
			this.Footer.TabIndex = 2;
			this.Footer.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Footer.VerticalScrollbarBarColor = true;
			this.Footer.VerticalScrollbarHighlightOnWheel = false;
			this.Footer.VerticalScrollbarSize = 10;
			// 
			// LoadBtn
			// 
			this.LoadBtn.Dock = System.Windows.Forms.DockStyle.Right;
			this.LoadBtn.Location = new System.Drawing.Point(900, 10);
			this.LoadBtn.Name = "LoadBtn";
			this.LoadBtn.Size = new System.Drawing.Size(160, 30);
			this.LoadBtn.TabIndex = 3;
			this.LoadBtn.Text = "Excel Load";
			this.LoadBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.LoadBtn.UseSelectable = true;
			this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
			// 
			// UIDSearch
			// 
			// 
			// 
			// 
			this.UIDSearch.CustomButton.Image = null;
			this.UIDSearch.CustomButton.Location = new System.Drawing.Point(1032, 2);
			this.UIDSearch.CustomButton.Name = "";
			this.UIDSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
			this.UIDSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.UIDSearch.CustomButton.TabIndex = 1;
			this.UIDSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.UIDSearch.CustomButton.UseSelectable = true;
			this.UIDSearch.CustomButton.Visible = false;
			this.UIDSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UIDSearch.Lines = new string[0];
			this.UIDSearch.Location = new System.Drawing.Point(0, 10);
			this.UIDSearch.MaxLength = 32767;
			this.UIDSearch.Name = "UIDSearch";
			this.UIDSearch.PasswordChar = '\0';
			this.UIDSearch.PromptText = "UID";
			this.UIDSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.UIDSearch.SelectedText = "";
			this.UIDSearch.SelectionLength = 0;
			this.UIDSearch.SelectionStart = 0;
			this.UIDSearch.ShortcutsEnabled = true;
			this.UIDSearch.Size = new System.Drawing.Size(1060, 30);
			this.UIDSearch.TabIndex = 2;
			this.UIDSearch.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.UIDSearch.UseSelectable = true;
			this.UIDSearch.WaterMark = "UID";
			this.UIDSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.UIDSearch.WaterMarkFont = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UIDSearch.TextChanged += new System.EventHandler(this.UIDSearch_Changed);
			// 
			// Body
			// 
			this.Body.AutoScroll = true;
			this.Body.Controls.Add(this.CheckBoxContainer);
			this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Body.HorizontalScrollbar = true;
			this.Body.HorizontalScrollbarBarColor = false;
			this.Body.HorizontalScrollbarHighlightOnWheel = false;
			this.Body.HorizontalScrollbarSize = 0;
			this.Body.Location = new System.Drawing.Point(20, 110);
			this.Body.MaximumSize = new System.Drawing.Size(1060, 620);
			this.Body.Name = "Body";
			this.Body.Size = new System.Drawing.Size(1060, 620);
			this.Body.TabIndex = 3;
			this.Body.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Body.VerticalScrollbar = true;
			this.Body.VerticalScrollbarBarColor = false;
			this.Body.VerticalScrollbarHighlightOnWheel = false;
			this.Body.VerticalScrollbarSize = 0;
			// 
			// CheckBoxContainer
			// 
			this.CheckBoxContainer.Controls.Add(this.Timeslot_24h);
			this.CheckBoxContainer.Controls.Add(this.Timeslot_12h);
			this.CheckBoxContainer.Controls.Add(this.Timeslot_8h);
			this.CheckBoxContainer.Controls.Add(this.Timeslot_6h);
			this.CheckBoxContainer.Controls.Add(this.Timeslot_4h);
			this.CheckBoxContainer.Controls.Add(this.Timeslot_3h);
			this.CheckBoxContainer.Controls.Add(this.Visible24H);
			this.CheckBoxContainer.Controls.Add(this.Visible21H);
			this.CheckBoxContainer.Controls.Add(this.Visible18H);
			this.CheckBoxContainer.Controls.Add(this.Visible15H);
			this.CheckBoxContainer.Controls.Add(this.Visible12H);
			this.CheckBoxContainer.Controls.Add(this.Visible9H);
			this.CheckBoxContainer.Controls.Add(this.Visible6H);
			this.CheckBoxContainer.Controls.Add(this.Visible3H);
			this.CheckBoxContainer.Dock = System.Windows.Forms.DockStyle.Top;
			this.CheckBoxContainer.HorizontalScrollbarBarColor = true;
			this.CheckBoxContainer.HorizontalScrollbarHighlightOnWheel = false;
			this.CheckBoxContainer.HorizontalScrollbarSize = 10;
			this.CheckBoxContainer.Location = new System.Drawing.Point(0, 0);
			this.CheckBoxContainer.Name = "CheckBoxContainer";
			this.CheckBoxContainer.Size = new System.Drawing.Size(1060, 33);
			this.CheckBoxContainer.TabIndex = 2;
			this.CheckBoxContainer.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.CheckBoxContainer.VerticalScrollbarBarColor = true;
			this.CheckBoxContainer.VerticalScrollbarHighlightOnWheel = false;
			this.CheckBoxContainer.VerticalScrollbarSize = 10;
			// 
			// Timeslot_24h
			// 
			this.Timeslot_24h.AutoSize = true;
			this.Timeslot_24h.Location = new System.Drawing.Point(952, 0);
			this.Timeslot_24h.Name = "Timeslot_24h";
			this.Timeslot_24h.Size = new System.Drawing.Size(90, 15);
			this.Timeslot_24h.TabIndex = 15;
			this.Timeslot_24h.Tag = "24";
			this.Timeslot_24h.Text = "timeslot_24h";
			this.Timeslot_24h.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Timeslot_24h.UseSelectable = true;
			this.Timeslot_24h.CheckedChanged += new System.EventHandler(this.Timeslot_Changed);
			// 
			// Timeslot_12h
			// 
			this.Timeslot_12h.AutoSize = true;
			this.Timeslot_12h.Location = new System.Drawing.Point(862, 0);
			this.Timeslot_12h.Name = "Timeslot_12h";
			this.Timeslot_12h.Size = new System.Drawing.Size(90, 15);
			this.Timeslot_12h.TabIndex = 14;
			this.Timeslot_12h.Tag = "12";
			this.Timeslot_12h.Text = "timeslot_12h";
			this.Timeslot_12h.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Timeslot_12h.UseSelectable = true;
			this.Timeslot_12h.CheckedChanged += new System.EventHandler(this.Timeslot_Changed);
			// 
			// Timeslot_8h
			// 
			this.Timeslot_8h.AutoSize = true;
			this.Timeslot_8h.Location = new System.Drawing.Point(772, 0);
			this.Timeslot_8h.Name = "Timeslot_8h";
			this.Timeslot_8h.Size = new System.Drawing.Size(84, 15);
			this.Timeslot_8h.TabIndex = 13;
			this.Timeslot_8h.Tag = "8";
			this.Timeslot_8h.Text = "timeslot_8h";
			this.Timeslot_8h.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Timeslot_8h.UseSelectable = true;
			this.Timeslot_8h.CheckedChanged += new System.EventHandler(this.Timeslot_Changed);
			// 
			// Timeslot_6h
			// 
			this.Timeslot_6h.AutoSize = true;
			this.Timeslot_6h.Location = new System.Drawing.Point(682, 0);
			this.Timeslot_6h.Name = "Timeslot_6h";
			this.Timeslot_6h.Size = new System.Drawing.Size(84, 15);
			this.Timeslot_6h.TabIndex = 12;
			this.Timeslot_6h.Tag = "6";
			this.Timeslot_6h.Text = "timeslot_6h";
			this.Timeslot_6h.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Timeslot_6h.UseSelectable = true;
			this.Timeslot_6h.CheckedChanged += new System.EventHandler(this.Timeslot_Changed);
			// 
			// Timeslot_4h
			// 
			this.Timeslot_4h.AutoSize = true;
			this.Timeslot_4h.Location = new System.Drawing.Point(592, 0);
			this.Timeslot_4h.Name = "Timeslot_4h";
			this.Timeslot_4h.Size = new System.Drawing.Size(84, 15);
			this.Timeslot_4h.TabIndex = 11;
			this.Timeslot_4h.Tag = "4";
			this.Timeslot_4h.Text = "timeslot_4h";
			this.Timeslot_4h.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Timeslot_4h.UseSelectable = true;
			this.Timeslot_4h.CheckedChanged += new System.EventHandler(this.Timeslot_Changed);
			// 
			// Timeslot_3h
			// 
			this.Timeslot_3h.AutoSize = true;
			this.Timeslot_3h.Checked = true;
			this.Timeslot_3h.Location = new System.Drawing.Point(502, 0);
			this.Timeslot_3h.Name = "Timeslot_3h";
			this.Timeslot_3h.Size = new System.Drawing.Size(84, 15);
			this.Timeslot_3h.TabIndex = 10;
			this.Timeslot_3h.TabStop = true;
			this.Timeslot_3h.Tag = "3";
			this.Timeslot_3h.Text = "timeslot_3h";
			this.Timeslot_3h.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Timeslot_3h.UseSelectable = true;
			this.Timeslot_3h.CheckedChanged += new System.EventHandler(this.Timeslot_Changed);
			// 
			// Visible24H
			// 
			this.Visible24H.AutoSize = true;
			this.Visible24H.Checked = true;
			this.Visible24H.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Visible24H.Location = new System.Drawing.Point(434, 0);
			this.Visible24H.Name = "Visible24H";
			this.Visible24H.Size = new System.Drawing.Size(62, 15);
			this.Visible24H.TabIndex = 9;
			this.Visible24H.Tag = "7";
			this.Visible24H.Text = "21~24h";
			this.Visible24H.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Visible24H.UseSelectable = true;
			this.Visible24H.Click += new System.EventHandler(this.Visible_Toggled);
			// 
			// Visible21H
			// 
			this.Visible21H.AutoSize = true;
			this.Visible21H.Checked = true;
			this.Visible21H.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Visible21H.Location = new System.Drawing.Point(366, 0);
			this.Visible21H.Name = "Visible21H";
			this.Visible21H.Size = new System.Drawing.Size(62, 15);
			this.Visible21H.TabIndex = 8;
			this.Visible21H.Tag = "6";
			this.Visible21H.Text = "18~21h";
			this.Visible21H.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Visible21H.UseSelectable = true;
			this.Visible21H.Click += new System.EventHandler(this.Visible_Toggled);
			// 
			// Visible18H
			// 
			this.Visible18H.AutoSize = true;
			this.Visible18H.Checked = true;
			this.Visible18H.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Visible18H.Location = new System.Drawing.Point(298, 0);
			this.Visible18H.Name = "Visible18H";
			this.Visible18H.Size = new System.Drawing.Size(62, 15);
			this.Visible18H.TabIndex = 7;
			this.Visible18H.Tag = "5";
			this.Visible18H.Text = "15~18h";
			this.Visible18H.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Visible18H.UseSelectable = true;
			this.Visible18H.Click += new System.EventHandler(this.Visible_Toggled);
			// 
			// Visible15H
			// 
			this.Visible15H.AutoSize = true;
			this.Visible15H.Checked = true;
			this.Visible15H.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Visible15H.Location = new System.Drawing.Point(230, 0);
			this.Visible15H.Name = "Visible15H";
			this.Visible15H.Size = new System.Drawing.Size(62, 15);
			this.Visible15H.TabIndex = 6;
			this.Visible15H.Tag = "4";
			this.Visible15H.Text = "12~15h";
			this.Visible15H.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Visible15H.UseSelectable = true;
			this.Visible15H.Click += new System.EventHandler(this.Visible_Toggled);
			// 
			// Visible12H
			// 
			this.Visible12H.AutoSize = true;
			this.Visible12H.Checked = true;
			this.Visible12H.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Visible12H.Location = new System.Drawing.Point(168, 0);
			this.Visible12H.Name = "Visible12H";
			this.Visible12H.Size = new System.Drawing.Size(56, 15);
			this.Visible12H.TabIndex = 5;
			this.Visible12H.Tag = "3";
			this.Visible12H.Text = "9~12h";
			this.Visible12H.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Visible12H.UseSelectable = true;
			this.Visible12H.Click += new System.EventHandler(this.Visible_Toggled);
			// 
			// Visible9H
			// 
			this.Visible9H.AutoSize = true;
			this.Visible9H.Checked = true;
			this.Visible9H.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Visible9H.Location = new System.Drawing.Point(112, 0);
			this.Visible9H.Name = "Visible9H";
			this.Visible9H.Size = new System.Drawing.Size(50, 15);
			this.Visible9H.TabIndex = 4;
			this.Visible9H.Tag = "2";
			this.Visible9H.Text = "6~9h";
			this.Visible9H.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Visible9H.UseSelectable = true;
			this.Visible9H.Click += new System.EventHandler(this.Visible_Toggled);
			// 
			// Visible6H
			// 
			this.Visible6H.AutoSize = true;
			this.Visible6H.Checked = true;
			this.Visible6H.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Visible6H.Location = new System.Drawing.Point(56, 0);
			this.Visible6H.Name = "Visible6H";
			this.Visible6H.Size = new System.Drawing.Size(50, 15);
			this.Visible6H.TabIndex = 3;
			this.Visible6H.Tag = "1";
			this.Visible6H.Text = "3~6h";
			this.Visible6H.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Visible6H.UseSelectable = true;
			this.Visible6H.Click += new System.EventHandler(this.Visible_Toggled);
			// 
			// Visible3H
			// 
			this.Visible3H.AutoSize = true;
			this.Visible3H.Checked = true;
			this.Visible3H.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Visible3H.Location = new System.Drawing.Point(0, 0);
			this.Visible3H.Name = "Visible3H";
			this.Visible3H.Size = new System.Drawing.Size(50, 15);
			this.Visible3H.TabIndex = 2;
			this.Visible3H.Tag = "0";
			this.Visible3H.Text = "0~3h";
			this.Visible3H.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Visible3H.UseSelectable = true;
			this.Visible3H.Click += new System.EventHandler(this.Visible_Toggled);
			// 
			// Chart
			// 
			this.Chart.BackColor = System.Drawing.Color.Transparent;
			this.Chart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Chart.Location = new System.Drawing.Point(0, 0);
			this.Chart.Name = "Chart";
			this.Chart.Size = new System.Drawing.Size(1060, 620);
			this.Chart.TabIndex = 2;
			this.Chart.Text = "0~3 Power Frequency";
			// 
			// Spinner
			// 
			this.Spinner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Spinner.Location = new System.Drawing.Point(405, 185);
			this.Spinner.Maximum = 100;
			this.Spinner.Name = "Spinner";
			this.Spinner.Size = new System.Drawing.Size(250, 250);
			this.Spinner.TabIndex = 2;
			this.Spinner.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Spinner.UseSelectable = true;
			// 
			// ChartContainer
			// 
			this.ChartContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ChartContainer.HorizontalScrollbarBarColor = true;
			this.ChartContainer.HorizontalScrollbarHighlightOnWheel = false;
			this.ChartContainer.HorizontalScrollbarSize = 10;
			this.ChartContainer.Location = new System.Drawing.Point(20, 149);
			this.ChartContainer.Name = "ChartContainer";
			this.ChartContainer.Size = new System.Drawing.Size(1060, 581);
			this.ChartContainer.TabIndex = 2;
			this.ChartContainer.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.ChartContainer.VerticalScrollbarBarColor = true;
			this.ChartContainer.VerticalScrollbarHighlightOnWheel = false;
			this.ChartContainer.VerticalScrollbarSize = 10;
			// 
			// Component
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1100, 800);
			this.Controls.Add(this.ChartContainer);
			this.Controls.Add(this.Body);
			this.Controls.Add(this.Footer);
			this.Controls.Add(this.Header);
			this.Name = "Component";
			this.Resizable = false;
			this.Text = "KETI";
			this.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Header.ResumeLayout(false);
			this.SeasonPanel.ResumeLayout(false);
			this.SeasonControlTabs.ResumeLayout(false);
			this.metroPanel1.ResumeLayout(false);
			this.DayTabs.ResumeLayout(false);
			this.Footer.ResumeLayout(false);
			this.Body.ResumeLayout(false);
			this.CheckBoxContainer.ResumeLayout(false);
			this.CheckBoxContainer.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroPanel Header;
		private MetroFramework.Controls.MetroPanel Footer;
		private MetroFramework.Controls.MetroPanel Body;
		private MetroFramework.Controls.MetroTextBox UIDSearch;
		private MetroFramework.Controls.MetroProgressSpinner Spinner;
		private MetroFramework.Controls.MetroButton LoadBtn;
		private LiveCharts.WinForms.CartesianChart Chart;
		private MetroFramework.Controls.MetroPanel ChartContainer;
		private MetroFramework.Controls.MetroPanel CheckBoxContainer;
		private MetroFramework.Controls.MetroCheckBox Visible24H;
		private MetroFramework.Controls.MetroCheckBox Visible21H;
		private MetroFramework.Controls.MetroCheckBox Visible18H;
		private MetroFramework.Controls.MetroCheckBox Visible15H;
		private MetroFramework.Controls.MetroCheckBox Visible12H;
		private MetroFramework.Controls.MetroCheckBox Visible9H;
		private MetroFramework.Controls.MetroCheckBox Visible6H;
		private MetroFramework.Controls.MetroCheckBox Visible3H;
		private MetroFramework.Controls.MetroPanel metroPanel1;
		private MetroFramework.Controls.MetroPanel SeasonPanel;
		private MetroFramework.Controls.MetroTabControl DayTabs;
		private MetroFramework.Controls.MetroTabPage Sun;
		private MetroFramework.Controls.MetroTabPage Sat;
		private MetroFramework.Controls.MetroTabPage Mon;
		private MetroFramework.Controls.MetroTabPage Tue;
		private MetroFramework.Controls.MetroTabPage Wed;
		private MetroFramework.Controls.MetroTabPage Thu;
		private MetroFramework.Controls.MetroTabPage Fri;
		private MetroFramework.Controls.MetroTabControl SeasonControlTabs;
		private MetroFramework.Controls.MetroTabPage Spring;
		private MetroFramework.Controls.MetroTabPage Summer;
		private MetroFramework.Controls.MetroTabPage Autumn;
		private MetroFramework.Controls.MetroTabPage Winter;
		private MetroFramework.Controls.MetroRadioButton Timeslot_3h;
		private MetroFramework.Controls.MetroRadioButton Timeslot_24h;
		private MetroFramework.Controls.MetroRadioButton Timeslot_12h;
		private MetroFramework.Controls.MetroRadioButton Timeslot_8h;
		private MetroFramework.Controls.MetroRadioButton Timeslot_6h;
		private MetroFramework.Controls.MetroRadioButton Timeslot_4h;
	}
}

