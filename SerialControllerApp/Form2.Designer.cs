
namespace SerialControllerApp
{
	partial class Form2
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.retryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.Open = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageToComandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.allComandTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optimizedCommandTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageToComands2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.penButton = new System.Windows.Forms.Button();
			this.lineButton = new System.Windows.Forms.Button();
			this.squareButton = new System.Windows.Forms.Button();
			this.triangleButton = new System.Windows.Forms.Button();
			this.circleButton = new System.Windows.Forms.Button();
			this.rectangleButton = new System.Windows.Forms.Button();
			this.rubberButton = new System.Windows.Forms.Button();
			this.textButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cboLatency = new System.Windows.Forms.ComboBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label2 = new System.Windows.Forms.Label();
			this.sizeLabel = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 94);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(366, 398);
			this.panel1.TabIndex = 0;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.opcjeToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(366, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// plikToolStripMenuItem
			// 
			this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.retryToolStripMenuItem,
            this.toolStripSeparator1,
            this.Open,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.closeToolStripMenuItem});
			this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
			this.plikToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.plikToolStripMenuItem.Text = "Project";
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.undoToolStripMenuItem.Text = "Undo";
			// 
			// retryToolStripMenuItem
			// 
			this.retryToolStripMenuItem.Name = "retryToolStripMenuItem";
			this.retryToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.retryToolStripMenuItem.Text = "Retry";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
			// 
			// Open
			// 
			this.Open.Name = "Open";
			this.Open.Size = new System.Drawing.Size(121, 22);
			this.Open.Text = "Open";
			this.Open.Click += new System.EventHandler(this.Open_Click);
			// 
			// saveToolStripMenuItem1
			// 
			this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
			this.saveToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
			this.saveToolStripMenuItem1.Text = "Save";
			this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.saveAsToolStripMenuItem.Text = "Save as...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(118, 6);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.closeToolStripMenuItem.Text = "Close";
			// 
			// opcjeToolStripMenuItem
			// 
			this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToComandsToolStripMenuItem,
            this.imageToComands2ToolStripMenuItem});
			this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
			this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.opcjeToolStripMenuItem.Text = "Export";
			this.opcjeToolStripMenuItem.Click += new System.EventHandler(this.opcjeToolStripMenuItem_Click);
			// 
			// imageToComandsToolStripMenuItem
			// 
			this.imageToComandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allComandTxtToolStripMenuItem,
            this.optimizedCommandTxtToolStripMenuItem});
			this.imageToComandsToolStripMenuItem.Name = "imageToComandsToolStripMenuItem";
			this.imageToComandsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.imageToComandsToolStripMenuItem.Text = "Export to command file";
			// 
			// allComandTxtToolStripMenuItem
			// 
			this.allComandTxtToolStripMenuItem.Name = "allComandTxtToolStripMenuItem";
			this.allComandTxtToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.allComandTxtToolStripMenuItem.Text = "All command txt";
			this.allComandTxtToolStripMenuItem.Click += new System.EventHandler(this.allComandTxtToolStripMenuItem_Click);
			// 
			// optimizedCommandTxtToolStripMenuItem
			// 
			this.optimizedCommandTxtToolStripMenuItem.Name = "optimizedCommandTxtToolStripMenuItem";
			this.optimizedCommandTxtToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.optimizedCommandTxtToolStripMenuItem.Text = "Optimized command txt";
			this.optimizedCommandTxtToolStripMenuItem.Click += new System.EventHandler(this.optimizedCommandTxtToolStripMenuItem_Click);
			// 
			// imageToComands2ToolStripMenuItem
			// 
			this.imageToComands2ToolStripMenuItem.Name = "imageToComands2ToolStripMenuItem";
			this.imageToComands2ToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.imageToComands2ToolStripMenuItem.Text = "Export as...";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// penButton
			// 
			this.penButton.Image = ((System.Drawing.Image)(resources.GetObject("penButton.Image")));
			this.penButton.Location = new System.Drawing.Point(0, 27);
			this.penButton.Name = "penButton";
			this.penButton.Size = new System.Drawing.Size(34, 34);
			this.penButton.TabIndex = 4;
			this.penButton.UseVisualStyleBackColor = true;
			this.penButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// lineButton
			// 
			this.lineButton.Image = ((System.Drawing.Image)(resources.GetObject("lineButton.Image")));
			this.lineButton.Location = new System.Drawing.Point(40, 27);
			this.lineButton.Name = "lineButton";
			this.lineButton.Size = new System.Drawing.Size(34, 34);
			this.lineButton.TabIndex = 5;
			this.lineButton.UseVisualStyleBackColor = true;
			this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
			// 
			// squareButton
			// 
			this.squareButton.Image = ((System.Drawing.Image)(resources.GetObject("squareButton.Image")));
			this.squareButton.Location = new System.Drawing.Point(80, 27);
			this.squareButton.Name = "squareButton";
			this.squareButton.Size = new System.Drawing.Size(34, 34);
			this.squareButton.TabIndex = 6;
			this.squareButton.UseVisualStyleBackColor = true;
			this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
			// 
			// triangleButton
			// 
			this.triangleButton.Image = ((System.Drawing.Image)(resources.GetObject("triangleButton.Image")));
			this.triangleButton.Location = new System.Drawing.Point(160, 27);
			this.triangleButton.Name = "triangleButton";
			this.triangleButton.Size = new System.Drawing.Size(34, 34);
			this.triangleButton.TabIndex = 7;
			this.triangleButton.UseVisualStyleBackColor = true;
			this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
			// 
			// circleButton
			// 
			this.circleButton.Image = ((System.Drawing.Image)(resources.GetObject("circleButton.Image")));
			this.circleButton.Location = new System.Drawing.Point(200, 27);
			this.circleButton.Name = "circleButton";
			this.circleButton.Size = new System.Drawing.Size(34, 34);
			this.circleButton.TabIndex = 8;
			this.circleButton.UseVisualStyleBackColor = true;
			this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
			// 
			// rectangleButton
			// 
			this.rectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("rectangleButton.Image")));
			this.rectangleButton.Location = new System.Drawing.Point(120, 27);
			this.rectangleButton.Name = "rectangleButton";
			this.rectangleButton.Size = new System.Drawing.Size(34, 34);
			this.rectangleButton.TabIndex = 10;
			this.rectangleButton.UseVisualStyleBackColor = true;
			this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
			// 
			// rubberButton
			// 
			this.rubberButton.Image = ((System.Drawing.Image)(resources.GetObject("rubberButton.Image")));
			this.rubberButton.Location = new System.Drawing.Point(240, 27);
			this.rubberButton.Name = "rubberButton";
			this.rubberButton.Size = new System.Drawing.Size(34, 34);
			this.rubberButton.TabIndex = 9;
			this.rubberButton.UseVisualStyleBackColor = true;
			this.rubberButton.Click += new System.EventHandler(this.rubberButton_Click);
			// 
			// textButton
			// 
			this.textButton.Image = ((System.Drawing.Image)(resources.GetObject("textButton.Image")));
			this.textButton.Location = new System.Drawing.Point(280, 27);
			this.textButton.Name = "textButton";
			this.textButton.Size = new System.Drawing.Size(34, 34);
			this.textButton.TabIndex = 11;
			this.textButton.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(1, 62);
			this.label1.MaximumSize = new System.Drawing.Size(65, 30);
			this.label1.MinimumSize = new System.Drawing.Size(65, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 30);
			this.label1.TabIndex = 13;
			this.label1.Text = "Engraving speed (ms):";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cboLatency
			// 
			this.cboLatency.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cboLatency.AutoCompleteCustomSource.AddRange(new string[] {
            "1000",
            "1100",
            "1200",
            "1300",
            "1400",
            "1500",
            "1600",
            "1700",
            "1800",
            "1900",
            "2000",
            "2100",
            "2200",
            "2300",
            "2400",
            "2500",
            "2600",
            "2700",
            "2800",
            "2900",
            "3000"});
			this.cboLatency.FormatString = "N0";
			this.cboLatency.FormattingEnabled = true;
			this.cboLatency.Items.AddRange(new object[] {
            "1000",
            "1100",
            "1200",
            "1300",
            "1400",
            "1500",
            "1600",
            "1700",
            "1800",
            "1900",
            "2000",
            "2100",
            "2200",
            "2300",
            "2400",
            "2500",
            "2600",
            "2700",
            "2800",
            "2900",
            "3000"});
			this.cboLatency.Location = new System.Drawing.Point(62, 68);
			this.cboLatency.Name = "cboLatency";
			this.cboLatency.Size = new System.Drawing.Size(52, 21);
			this.cboLatency.TabIndex = 14;
			this.cboLatency.Text = "1000";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(127, 70);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(67, 17);
			this.checkBox1.TabIndex = 15;
			this.checkBox1.Text = "fill shape";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(320, 27);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(46, 17);
			this.checkBox2.TabIndex = 16;
			this.checkBox2.Text = "bold";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(200, 62);
			this.trackBar1.Maximum = 20;
			this.trackBar1.MaximumSize = new System.Drawing.Size(130, 30);
			this.trackBar1.Minimum = 1;
			this.trackBar1.MinimumSize = new System.Drawing.Size(130, 30);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(130, 45);
			this.trackBar1.TabIndex = 17;
			this.trackBar1.Value = 1;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(334, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 18;
			this.label2.Text = "Size:";
			// 
			// sizeLabel
			// 
			this.sizeLabel.AutoSize = true;
			this.sizeLabel.Location = new System.Drawing.Point(334, 78);
			this.sizeLabel.MaximumSize = new System.Drawing.Size(20, 13);
			this.sizeLabel.MinimumSize = new System.Drawing.Size(20, 13);
			this.sizeLabel.Name = "sizeLabel";
			this.sizeLabel.Size = new System.Drawing.Size(20, 13);
			this.sizeLabel.TabIndex = 19;
			this.sizeLabel.Text = "1";
			this.sizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 20;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ClientSize = new System.Drawing.Size(366, 492);
			this.Controls.Add(this.sizeLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.cboLatency);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textButton);
			this.Controls.Add(this.rectangleButton);
			this.Controls.Add(this.rubberButton);
			this.Controls.Add(this.circleButton);
			this.Controls.Add(this.triangleButton);
			this.Controls.Add(this.squareButton);
			this.Controls.Add(this.lineButton);
			this.Controls.Add(this.penButton);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.trackBar1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximumSize = new System.Drawing.Size(382, 531);
			this.MinimumSize = new System.Drawing.Size(382, 531);
			this.Name = "Form2";
			this.Text = "CNCdesigner";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem retryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem Open;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.Button penButton;
		private System.Windows.Forms.Button lineButton;
		private System.Windows.Forms.Button squareButton;
		private System.Windows.Forms.Button triangleButton;
		private System.Windows.Forms.Button circleButton;
		private System.Windows.Forms.Button rectangleButton;
		private System.Windows.Forms.Button rubberButton;
		private System.Windows.Forms.Button textButton;
		private System.Windows.Forms.ToolStripMenuItem imageToComandsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToComands2ToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboLatency;
		private System.Windows.Forms.ToolStripMenuItem allComandTxtToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optimizedCommandTxtToolStripMenuItem;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label sizeLabel;
		private System.Windows.Forms.Timer timer1;
	}
}