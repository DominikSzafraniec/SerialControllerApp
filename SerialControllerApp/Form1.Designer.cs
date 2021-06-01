
using System;

namespace SerialControllerApp
{
	partial class Form1
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnUpY = new System.Windows.Forms.Button();
			this.btnDownX = new System.Windows.Forms.Button();
			this.btnUpX = new System.Windows.Forms.Button();
			this.btnDownY = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cboPort = new System.Windows.Forms.ComboBox();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.txtReceive = new System.Windows.Forms.TextBox();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.btnUpZ = new System.Windows.Forms.Button();
			this.btnDownZ = new System.Windows.Forms.Button();
			this.cboBaundRate = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cboSteps = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnUpY
			// 
			this.btnUpY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnUpY.Location = new System.Drawing.Point(59, 219);
			this.btnUpY.Margin = new System.Windows.Forms.Padding(1);
			this.btnUpY.Name = "btnUpY";
			this.btnUpY.Size = new System.Drawing.Size(40, 40);
			this.btnUpY.TabIndex = 0;
			this.btnUpY.Text = "y+";
			this.btnUpY.UseVisualStyleBackColor = true;
			this.btnUpY.Click += new System.EventHandler(this.btnUpY_Click);
			// 
			// btnDownX
			// 
			this.btnDownX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnDownX.Location = new System.Drawing.Point(17, 261);
			this.btnDownX.Margin = new System.Windows.Forms.Padding(1);
			this.btnDownX.Name = "btnDownX";
			this.btnDownX.Size = new System.Drawing.Size(40, 40);
			this.btnDownX.TabIndex = 1;
			this.btnDownX.Text = "x-";
			this.btnDownX.UseVisualStyleBackColor = true;
			this.btnDownX.Click += new System.EventHandler(this.btnDownX_Click);
			// 
			// btnUpX
			// 
			this.btnUpX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnUpX.Location = new System.Drawing.Point(101, 261);
			this.btnUpX.Margin = new System.Windows.Forms.Padding(1);
			this.btnUpX.Name = "btnUpX";
			this.btnUpX.Size = new System.Drawing.Size(40, 40);
			this.btnUpX.TabIndex = 2;
			this.btnUpX.Text = "x+";
			this.btnUpX.UseVisualStyleBackColor = true;
			this.btnUpX.Click += new System.EventHandler(this.btnUpX_Click);
			// 
			// btnDownY
			// 
			this.btnDownY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnDownY.Location = new System.Drawing.Point(59, 303);
			this.btnDownY.Margin = new System.Windows.Forms.Padding(1);
			this.btnDownY.Name = "btnDownY";
			this.btnDownY.Size = new System.Drawing.Size(40, 40);
			this.btnDownY.TabIndex = 3;
			this.btnDownY.Text = "y-";
			this.btnDownY.UseVisualStyleBackColor = true;
			this.btnDownY.Click += new System.EventHandler(this.btnDownY_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Port:";
			// 
			// cboPort
			// 
			this.cboPort.FormattingEnabled = true;
			this.cboPort.Location = new System.Drawing.Point(15, 110);
			this.cboPort.Name = "cboPort";
			this.cboPort.Size = new System.Drawing.Size(121, 21);
			this.cboPort.TabIndex = 6;
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(15, 137);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(56, 23);
			this.btnOpen.TabIndex = 7;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(80, 137);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(56, 23);
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(220, 394);
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(602, 20);
			this.txtMessage.TabIndex = 9;
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(828, 391);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 10;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// txtReceive
			// 
			this.txtReceive.Location = new System.Drawing.Point(220, 12);
			this.txtReceive.Multiline = true;
			this.txtReceive.Name = "txtReceive";
			this.txtReceive.Size = new System.Drawing.Size(683, 376);
			this.txtReceive.TabIndex = 11;
			// 
			// serialPort1
			// 
			this.serialPort1.PortName = "COM5";
			// 
			// btnUpZ
			// 
			this.btnUpZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.btnUpZ.Location = new System.Drawing.Point(162, 235);
			this.btnUpZ.Margin = new System.Windows.Forms.Padding(1);
			this.btnUpZ.Name = "btnUpZ";
			this.btnUpZ.Size = new System.Drawing.Size(40, 40);
			this.btnUpZ.TabIndex = 13;
			this.btnUpZ.Text = "🠑";
			this.btnUpZ.UseVisualStyleBackColor = true;
			this.btnUpZ.Click += new System.EventHandler(this.btnUpZ_Click);
			// 
			// btnDownZ
			// 
			this.btnDownZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.btnDownZ.Location = new System.Drawing.Point(162, 288);
			this.btnDownZ.Margin = new System.Windows.Forms.Padding(1);
			this.btnDownZ.Name = "btnDownZ";
			this.btnDownZ.Size = new System.Drawing.Size(40, 40);
			this.btnDownZ.TabIndex = 14;
			this.btnDownZ.Text = "🠓";
			this.btnDownZ.UseVisualStyleBackColor = true;
			this.btnDownZ.Click += new System.EventHandler(this.btnDownZ_Click);
			// 
			// cboBaundRate
			// 
			this.cboBaundRate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cboBaundRate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cboBaundRate.DisplayMember = "9600";
			this.cboBaundRate.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cboBaundRate.FormatString = "N2";
			this.cboBaundRate.FormattingEnabled = true;
			this.cboBaundRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400",
            "250000"});
			this.cboBaundRate.Location = new System.Drawing.Point(15, 69);
			this.cboBaundRate.Name = "cboBaundRate";
			this.cboBaundRate.Size = new System.Drawing.Size(121, 21);
			this.cboBaundRate.TabIndex = 16;
			this.cboBaundRate.Text = "9600";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Baud rate:";
			// 
			// cboSteps
			// 
			this.cboSteps.FormattingEnabled = true;
			this.cboSteps.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
			this.cboSteps.Location = new System.Drawing.Point(17, 187);
			this.cboSteps.Name = "cboSteps";
			this.cboSteps.Size = new System.Drawing.Size(40, 21);
			this.cboSteps.TabIndex = 17;
			this.cboSteps.Text = "1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 171);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 13);
			this.label3.TabIndex = 18;
			this.label3.Text = "Number of steps:";
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(15, 12);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(56, 23);
			this.btnRefresh.TabIndex = 19;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(80, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 23);
			this.button1.TabIndex = 20;
			this.button1.Text = "Design";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(915, 429);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cboSteps);
			this.Controls.Add(this.cboBaundRate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnDownZ);
			this.Controls.Add(this.btnUpZ);
			this.Controls.Add(this.txtReceive);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.cboPort);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnDownY);
			this.Controls.Add(this.btnUpX);
			this.Controls.Add(this.btnDownX);
			this.Controls.Add(this.btnUpY);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(931, 468);
			this.MinimumSize = new System.Drawing.Size(931, 468);
			this.Name = "Form1";
			this.Text = "CNCtool";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public delegate void AddDataDelegate(String myString);
		public AddDataDelegate myDelegate;
		private System.Windows.Forms.Button btnUpY;
		private System.Windows.Forms.Button btnDownX;
		private System.Windows.Forms.Button btnUpX;
		private System.Windows.Forms.Button btnDownY;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboPort;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox txtReceive;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Button btnUpZ;
		private System.Windows.Forms.Button btnDownZ;
		private System.Windows.Forms.ComboBox cboBaundRate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboSteps;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button button1;
	}
}

