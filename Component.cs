using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroUI
{
	public partial class Component : MetroFramework.Forms.MetroForm
	{
		public Component()
		{
			InitializeComponent();
		}

		private void Component_Load(object sender, EventArgs e)
		{
			PrivateFontCollection privateFonts = new PrivateFontCollection();

			string path = @"C:\Users\ykpark\source\repos\MetroUI\Resource\Fonts\Montserrat-SemiBold.ttf";
			privateFonts.AddFontFile(path);
			Font font = new Font(privateFonts.Families[0], 24f);

			this.Sun.Font = font; this.Mon.Font = font; this.Tue.Font = font;
			this.Wed.Font = font; this.Thu.Font = font; this.Fri.Font = font; this.Sat.Font = font;
		}
	}
}
