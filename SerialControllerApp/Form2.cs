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
		Bitmap surface;
		public Pen pen;
		int x = -1;
		int y = -1;
		bool drawing = false;
		public Form2()
		{
			InitializeComponent();
			surface = new Bitmap(panel1.Width, panel1.Height);
			graphics = Graphics.FromImage(surface);
			panel1.BackgroundImage = surface;
			panel1.BackgroundImageLayout = ImageLayout.None;
			pen = new Pen(Color.Black, 5);
			pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
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
				panel1.Invalidate();
			}

			x = e.X;
			y = e.Y;	
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			surface.Save("save1_1.bmp", ImageFormat.MemoryBmp);
		}
	}
}
