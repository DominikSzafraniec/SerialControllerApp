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

		private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			surface.Save("save1_1.bmp", ImageFormat.MemoryBmp);
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
			saveFileDialog1.Filter = "bmp files (*.bmp)|*.bmp|All files (*.*)|*.*";
			saveFileDialog1.FilterIndex = 1;
			saveFileDialog1.RestoreDirectory = true;

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				surface.Save(saveFileDialog1.FileName, ImageFormat.MemoryBmp);
			}
		}

		private void Open_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			var fileContent = string.Empty;
			var filePath = string.Empty;
			openFileDialog.Filter = "bmp files (*.bmp)|*.bmp|All files (*.*)|*.*";
			openFileDialog.FilterIndex = 2;
			openFileDialog.RestoreDirectory = true;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				//Get the path of specified file
				filePath = openFileDialog.FileName;

				//Read the contents of the file into a stream
				var fileStream = openFileDialog.OpenFile();

				using (StreamReader reader = new StreamReader(fileStream))
				{
					fileContent = reader.ReadToEnd();
				}
			}
		}
		private void imageToComands()
		{

			for (int j = 0; j < surface.Height; j++)
				for (int i = 0; i < surface.Width; i++)
					surface.GetPixel(i, j);
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{

		}
	}
}
