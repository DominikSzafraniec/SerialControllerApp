
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
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.penButton = new System.Windows.Forms.Button();
			this.lineButton = new System.Windows.Forms.Button();
			this.squareButton = new System.Windows.Forms.Button();
			this.triangleButton = new System.Windows.Forms.Button();
			this.circleButton = new System.Windows.Forms.Button();
			this.rectangleButton = new System.Windows.Forms.Button();
			this.rubberButton = new System.Windows.Forms.Button();
			this.textButton = new System.Windows.Forms.Button();
			this.markingButton = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 64);
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
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.undoToolStripMenuItem.Text = "Undo";
			// 
			// retryToolStripMenuItem
			// 
			this.retryToolStripMenuItem.Name = "retryToolStripMenuItem";
			this.retryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.retryToolStripMenuItem.Text = "Retry";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// Open
			// 
			this.Open.Name = "Open";
			this.Open.Size = new System.Drawing.Size(180, 22);
			this.Open.Text = "Open";
			this.Open.Click += new System.EventHandler(this.Open_Click);
			// 
			// saveToolStripMenuItem1
			// 
			this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
			this.saveToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.saveToolStripMenuItem1.Text = "Save";
			this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveAsToolStripMenuItem.Text = "Save as...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.closeToolStripMenuItem.Text = "Close";
			// 
			// opcjeToolStripMenuItem
			// 
			this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
			this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.opcjeToolStripMenuItem.Text = "Settings";
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
			// 
			// squareButton
			// 
			this.squareButton.Image = ((System.Drawing.Image)(resources.GetObject("squareButton.Image")));
			this.squareButton.Location = new System.Drawing.Point(80, 27);
			this.squareButton.Name = "squareButton";
			this.squareButton.Size = new System.Drawing.Size(34, 34);
			this.squareButton.TabIndex = 6;
			this.squareButton.UseVisualStyleBackColor = true;
			// 
			// triangleButton
			// 
			this.triangleButton.Image = ((System.Drawing.Image)(resources.GetObject("triangleButton.Image")));
			this.triangleButton.Location = new System.Drawing.Point(160, 27);
			this.triangleButton.Name = "triangleButton";
			this.triangleButton.Size = new System.Drawing.Size(34, 34);
			this.triangleButton.TabIndex = 7;
			this.triangleButton.UseVisualStyleBackColor = true;
			// 
			// circleButton
			// 
			this.circleButton.Image = ((System.Drawing.Image)(resources.GetObject("circleButton.Image")));
			this.circleButton.Location = new System.Drawing.Point(200, 27);
			this.circleButton.Name = "circleButton";
			this.circleButton.Size = new System.Drawing.Size(34, 34);
			this.circleButton.TabIndex = 8;
			this.circleButton.UseVisualStyleBackColor = true;
			// 
			// rectangleButton
			// 
			this.rectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("rectangleButton.Image")));
			this.rectangleButton.Location = new System.Drawing.Point(120, 27);
			this.rectangleButton.Name = "rectangleButton";
			this.rectangleButton.Size = new System.Drawing.Size(34, 34);
			this.rectangleButton.TabIndex = 10;
			this.rectangleButton.UseVisualStyleBackColor = true;
			// 
			// rubberButton
			// 
			this.rubberButton.Image = ((System.Drawing.Image)(resources.GetObject("rubberButton.Image")));
			this.rubberButton.Location = new System.Drawing.Point(240, 27);
			this.rubberButton.Name = "rubberButton";
			this.rubberButton.Size = new System.Drawing.Size(34, 34);
			this.rubberButton.TabIndex = 9;
			this.rubberButton.UseVisualStyleBackColor = true;
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
			// markingButton
			// 
			this.markingButton.Image = ((System.Drawing.Image)(resources.GetObject("markingButton.Image")));
			this.markingButton.Location = new System.Drawing.Point(320, 27);
			this.markingButton.Name = "markingButton";
			this.markingButton.Size = new System.Drawing.Size(34, 34);
			this.markingButton.TabIndex = 12;
			this.markingButton.UseVisualStyleBackColor = true;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(366, 462);
			this.Controls.Add(this.markingButton);
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
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximumSize = new System.Drawing.Size(382, 501);
			this.MinimumSize = new System.Drawing.Size(382, 501);
			this.Name = "Form2";
			this.Text = "CNCdesigner";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
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
		private System.Windows.Forms.Button markingButton;
	}
}