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
			pen = new Pen(Color.Black, 2);
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
			var filePath = string.Empty;
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
					surface = bitmapFile;
					panel1.BackgroundImage = surface;
					panel1.Invalidate();
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{

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
			TextWriter tw = new StreamWriter("CommandList.txt");
			foreach (String s in commands)
				tw.WriteLine(s);
			tw.Close();

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

				if(!on && numOfSteps >= surface.Width)
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
			TextWriter tw = new StreamWriter("ComandList3.txt");
			foreach (String s in commands)
				tw.WriteLine(s);
			tw.Close();
		}

		private void opcjeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void imageToCommandsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			imageToCommands();
		}

		private void imageToCommands2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			imageToCommands2();
		}
	}
}
