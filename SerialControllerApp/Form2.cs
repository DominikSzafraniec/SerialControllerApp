using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialControllerApp
{
	public partial class Form2 : Form
	{
		Graphics graphics;
		Pen pen;
		int x = -1;
		int y = -1;
		bool drawing=false;
		public Form2()
		{
			InitializeComponent();
			graphics = panel1.CreateGraphics();
			graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			pen = new Pen(Color.Black,1);
			pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
		}
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			drawing = true;
			x = e.X;
			y = e.Y;
		}

		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			drawing = false;
			x = -1;
			y = -1;
			graphics.Flush();
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (drawing && x != -1 && y != -1)
			{
				graphics.DrawLine(pen, new Point(x, y), e.Location);
			}

			x = e.X;
			y = e.Y;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			graphics.Dispose();
			panel1.Visible = true;
			Bitmap bmap = new Bitmap(panel1.Width, panel1.Height);
			panel1.DrawToBitmap(bmap, new Rectangle(0, 0, panel1.Width, panel1.Height));
			bmap.Save("save1_1.bmp", ImageFormat.Bmp);
			bmap.Dispose();
		}
	}
}
