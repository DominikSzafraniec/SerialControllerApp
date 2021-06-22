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
		Graphics graphics2;
		Bitmap surface;
		Bitmap tempSurface;
		string filePath = string.Empty;
		public Pen pen;
		int x = -1;
		int y = -1;
		bool drawing = false;
		bool strightLine = false;
		bool square = false;
		bool rectangle = false;
		bool triangle = false;
		bool ellipse = false;
		bool rubber = false;

		private void setAllToolsFalse()
		{
			pen.Color = Color.Black;
			strightLine = false;
			square = false;
			rectangle = false;
			triangle = false;
			ellipse = false;
			rubber = false;
		}

		private Bitmap changeTransparentToWhite(Bitmap bmpT) {
			Bitmap bmp = new Bitmap(bmpT);
			for (int j = 0; j < bmp.Height; j++)
				for (int i = 0; i < bmp.Width; i++)
					if (bmp.GetPixel(i, j).A.Equals(0))
						bmp.SetPixel(i, j, Color.FromArgb(255, 255, 255, 255));
			return bmp;
		}
		private void setImageFromFile(string fp)
		{
			surface = new Bitmap(fp);
			graphics = Graphics.FromImage(surface);
			panel1.BackgroundImage = surface;
			panel1.BackgroundImageLayout = ImageLayout.None;
		}
		private void setImageFromFile(Bitmap bmp)
		{
			surface = new Bitmap(bmp);
			graphics = Graphics.FromImage(surface);
			panel1.BackgroundImage = surface;
			panel1.BackgroundImageLayout = ImageLayout.None;
		}
		public Form2()
		{
			InitializeComponent();
			surface = changeTransparentToWhite(new Bitmap(panel1.Width, panel1.Height));
			graphics = Graphics.FromImage(surface);
			graphics2 = panel1.CreateGraphics();
			panel1.BackgroundImage = surface;
			panel1.BackgroundImageLayout = ImageLayout.None;
			pen = new Pen(Color.Black, 1);
			pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
		}
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			tempSurface = surface;
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
			
			if (strightLine)
			{
				
				if (drawing && x != -1 && y != -1)
				{
					setImageFromFile(tempSurface);
					graphics.DrawLine(pen, new Point(x, y), e.Location);
					//panel1.Invalidate();
				}
			}
			else if (square)
			{

				if (drawing && x != -1 && y != -1)
				{
					setImageFromFile(tempSurface);
					graphics.DrawRectangle(pen, x,y,e.Location.X-x,e.Location.X-x);
					//panel1.Invalidate();
				}
			}
			else if (rectangle)
			{

				if (drawing && x != -1 && y != -1)
				{
					setImageFromFile(tempSurface);
					graphics.DrawRectangle(pen, x, y, e.Location.X-x, e.Location.Y-y);
					//panel1.Invalidate();
				}
			}
			else if (triangle)
			{

				if (drawing && x != -1 && y != -1)
				{
					setImageFromFile(tempSurface);
					graphics.DrawPolygon(pen,new Point[] {new Point(x,e.Location.Y), new Point(x+((e.Location.X-x)/2), y), new Point(e.Location.X, e.Location.Y) });
					//panel1.Invalidate();
				}
			}
			else if (ellipse)
			{

				if (drawing && x != -1 && y != -1 )
				{
					setImageFromFile(tempSurface);
					graphics.DrawEllipse(pen, new Rectangle(new Point(x,y),new Size(e.Location.X-x,e.Location.Y-y)));
					//panel1.Invalidate();
				}
			}
			else if (rubber)
			{

				if (drawing && x != -1 && y != -1)
				{
					graphics.DrawLine(pen, new Point(x, y), e.Location);
					//panel1.Invalidate();
				}
				x = e.X;
				y = e.Y;
			}

			else
			{
				if (drawing && x != -1 && y != -1)
				{
					graphics.DrawLine(pen, new Point(x, y), e.Location);
					//panel1.Invalidate();
				}
				x = e.X;
				y = e.Y;
			}
		}

		private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (filePath.Equals(string.Empty))
				saveAsToolStripMenuItem_Click(sender,e);
			else
				surface.Save(filePath, ImageFormat.MemoryBmp);
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
				filePath = @saveFileDialog1.FileName;
			}
		}

		private void Open_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "bmp files (*.bmp)|*.bmp|All files (*.*)|*.*";
			openFileDialog.FilterIndex = 2;
			openFileDialog.RestoreDirectory = true;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				//Get the path of specified file
				filePath = openFileDialog.FileName;
				Bitmap bitmapFile = new Bitmap(filePath);
				if (bitmapFile.Size.Equals(surface.Size))
				{
					bitmapFile = changeTransparentToWhite(bitmapFile);
					setImageFromFile(bitmapFile);
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			setAllToolsFalse();
		}
		private void imageToCommands()
		{
			List<String> commands = new List<string>();
			bool on = false;
			Color pixelColor;
			int numOfSteps = 0;
			String moveDirect = "";
			for (int j = 0; j < surface.Height; j++)
			{
				for (int i = 0; i < surface.Width; i++)
				{
					if ((j & 1) == 0)
					{
						pixelColor = surface.GetPixel(i, j);
					}
					else
					{
						pixelColor = surface.GetPixel((surface.Width-i-1), j);
					}

					if (j == 0 && i == 0)
					{
						if (pixelColor.A.Equals(255))
						{
							on = true;
							commands.Add("o");
						}
						moveDirect = "d";

					}
					else
					{
						if ((j & 1) == 0)
						{
							moveDirect = "d";
						}
						else
						{
							moveDirect = "a";
						}

						if (pixelColor.A.Equals(255))
						{
							if (on)
							{
								numOfSteps += 1;
							}
							else
							{
								on = true;
								commands.Add(moveDirect + numOfSteps.ToString());
								commands.Add("o");
								numOfSteps = 1;
							}
						}
						else
						{

							if (!on)
							{
								numOfSteps += 1;
							}
							else
							{
								on = false;
								commands.Add(moveDirect + numOfSteps.ToString());
								commands.Add("o");
								numOfSteps = 1;
							}
						}
					}

				}
				commands.Add(moveDirect + numOfSteps.ToString());
				numOfSteps = 1;
				commands.Add("w1");
				
			}
			if (filePath.Equals(string.Empty))
				saveAsToolStripMenuItem_Click(new Object(), new EventArgs());
			if (!filePath.Equals(string.Empty))
			{
				TextWriter tw = new StreamWriter(Path.GetDirectoryName(filePath) + Path.GetFileNameWithoutExtension(filePath) + "_command_list.txt");
				foreach (String s in commands)
					tw.WriteLine(s);
				tw.Close();
			}

		}
		private void imageToCommands2()
		{
			List<String> commands = new List<string>();
			bool on = false;
			bool emptyline = false;
			Color pixelColor;
			int numOfSteps = 0;
			int numOfEmptyLine = 0;
			String moveDirect = "";
			String tempCommand = "";
			commands.Add("l" + (int.Parse(cboLatency.Text)/2).ToString());
			commands.Add("z");
			for (int j = 0; j < surface.Height; j++)
			{
				for (int i = 0; i < surface.Width; i++)
				{
					if ((j & 1) == 0)
					{
						pixelColor = surface.GetPixel((surface.Width - i - 1), j);
					}
					else
					{
						pixelColor = surface.GetPixel(i, j);
					}

					if (j == 0 && i == 0)
					{
						if (pixelColor.GetBrightness().Equals(0) && pixelColor.A.Equals(255))
						{
							on = true;
							commands.Add("o");
						}
						moveDirect = "d";
						numOfSteps += 1;
					}
					else
					{
						if ((j & 1) == 0)
						{
							moveDirect = "d";
						}
						else
						{
							moveDirect = "a";
						}

						if (pixelColor.GetBrightness().Equals(0) && pixelColor.A.Equals(255))
						{
							if (on)
							{
								numOfSteps += 1;
							}
							else
							{
								if (numOfEmptyLine > 0)
								{
									if (emptyline)
									{
										commands.Add(tempCommand);
									}
									commands.Add("w" + numOfEmptyLine.ToString());
									numOfEmptyLine = 0;
								}
								on = true;
								commands.Add(moveDirect + numOfSteps.ToString());
								commands.Add("o");
								numOfSteps = 1;
							}
						}
						else
						{
							if (!on)
							{
								numOfSteps += 1;
							}
							else
							{
								on = false;
								commands.Add(moveDirect + numOfSteps.ToString());
								commands.Add("o");
								numOfSteps = 1;
							}
						}
					}

				}

				if (!on && numOfSteps >= surface.Width)
				{
					if (emptyline)
					{
						numOfEmptyLine += 2;
						emptyline = false;
					}
					else
					{
						emptyline = true;
					}
					tempCommand = moveDirect + numOfSteps.ToString();
					numOfSteps = 0;
				}
				else
				{
					if (numOfEmptyLine > 0)
					{
						if (emptyline)
						{
							commands.Add(tempCommand);
						}
						commands.Add("w" + numOfEmptyLine.ToString());
						numOfEmptyLine = 0;
					}
					else
					{
						if (commands.Count() > 0)
						{
							commands.Add(moveDirect + numOfSteps.ToString());
							numOfSteps = 0;
							commands.Add("w1");
						}
					}
				}
			}
			if (on)
				commands.Add("o");
			if (filePath.Equals(string.Empty))
				saveAsToolStripMenuItem_Click(new Object(),new EventArgs());
			if (!filePath.Equals(string.Empty))
			{
				TextWriter tw = new StreamWriter(Path.GetDirectoryName(filePath) + Path.GetFileNameWithoutExtension(filePath) + "_optimized_command_list.txt");
				foreach (String s in commands)
					tw.WriteLine(s);
				tw.Close();
			}
		}

		private void opcjeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}



		private void lineButton_Click(object sender, EventArgs e)
		{
			setAllToolsFalse();
			strightLine = true;
		}

		private void squareButton_Click(object sender, EventArgs e)
		{
			setAllToolsFalse();
			square = true;
		}

		private void rectangleButton_Click(object sender, EventArgs e)
		{
			setAllToolsFalse();
			rectangle = true;
		}

		private void triangleButton_Click(object sender, EventArgs e)
		{
			setAllToolsFalse();
			triangle = true;
		}

		private void circleButton_Click(object sender, EventArgs e)
		{
			setAllToolsFalse();
			ellipse = true;
		}

		private void rubberButton_Click(object sender, EventArgs e)
		{
			setAllToolsFalse();
			rubber = true;
			pen.Color= Color.FromArgb(255, 255, 255, 255);
		}

		private void allComandTxtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			imageToCommands();
		}

		private void optimizedCommandTxtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			imageToCommands2();
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			sizeLabel.Text = trackBar1.Value.ToString();
			pen.Width = trackBar1.Value;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			graphics2.DrawImage(surface, 0, 0);
		}
	}
}
