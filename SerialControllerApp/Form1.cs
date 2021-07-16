﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialControllerApp
{
	public partial class Form1 : Form
	{
        bool engravingOn;
        int commandCounter = 0;
        int actualCommand = 0;
        string sendedCommand = "";
        string filePath = string.Empty;
        List<String> commandList = new List<String>();
        public Form1()
		{
			InitializeComponent();
             engravingOn= false;
		}
        private void disableCotrols()
		{
            btnSend.Enabled = false;
            btnDownX.Enabled = false;
            btnDownY.Enabled = false;
            btnDownZ.Enabled = false;
            btnUpX.Enabled = false;
            btnUpY.Enabled = false;
            btnUpZ.Enabled = false;
            btnLaserOn.Enabled = false;
            btnGoToZero.Enabled = false;
            cboSteps.Enabled = false;
            btnClose.Enabled = false;
            txtMessage.Enabled = false;
            btnEngravingFile.Enabled = false;
            btnEngravingStart.Enabled = false;
        }
        private void enableCotrols()
        {
            btnSend.Enabled = true;
            btnDownX.Enabled = true;
            btnDownY.Enabled = true;
            btnDownZ.Enabled = true;
            btnUpX.Enabled = true;
            btnUpY.Enabled = true;
            btnUpZ.Enabled = true;
            btnLaserOn.Enabled = true;
            btnGoToZero.Enabled = true;
            cboSteps.Enabled = true;
            btnClose.Enabled = true;
            txtMessage.Enabled = true;
            btnEngravingFile.Enabled = true;
            if(!filePath.Equals(String.Empty))
                btnEngravingStart.Enabled = true;
            else
                btnEngravingStart.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtReceive.Enabled = false;
            //Get all ports
            string[] ports = SerialPort.GetPortNames();
            if (!ports.Equals(null))
            {
                cboPort.Items.AddRange(ports);
                cboPort.SelectedIndex = 0;
                cboPort.Text = cboPort.GetItemText(ports[0]);
                btnOpen.Enabled = true;
            } else {
                btnOpen.Enabled = false;
			}
            disableCotrols();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            this.myDelegate = new AddDataDelegate(AddDataMethod);
        }
        public void AddDataMethod(String myString)
        {
            txtReceive.AppendText(DateTime.UtcNow.ToString("HH:mm:ss")+ ": " + myString+Environment.NewLine);
            if (actualCommand == commandCounter - 1)
                enableCotrols();
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string s = sp.ReadExisting();
            string[] subs = s.Split(new string[] {Environment.NewLine}, StringSplitOptions.None);

            foreach (var sub in subs)
            {
                if (engravingOn)
                {
                    if (sub.Contains(sendedCommand.Trim()))
                    {
                        txtReceive.Invoke(this.myDelegate, new Object[] { sub });
                        engravingNextCommand();
                    }
                    if (sub.Contains("End switch"))
					{
                        txtReceive.Invoke(this.myDelegate, new Object[] { sub });
                    }

                }
				else
				{
                    txtReceive.Invoke(this.myDelegate, new Object[] { sub });
                }
            }
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                //Open port
                serialPort1.PortName = cboPort.Text;
                serialPort1.BaudRate = int.Parse(cboBaundRate.Text);
                serialPort1.Open();
                enableCotrols();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
			if (serialPort1.IsOpen)
			{
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                btnRefresh.Enabled = false;
                cboBaundRate.Enabled = false;
                cboPort.Enabled = false;
            }
        }
 
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    //Send text to port
                    serialPort1.WriteLine(txtMessage.Text + Environment.NewLine);
                    txtMessage.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void btnClose_Click(object sender, EventArgs e)
        {
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            btnRefresh.Enabled = true;
            cboBaundRate.Enabled = true;
            cboPort.Enabled = true;
            disableCotrols();
            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

		private void btnUpY_Click(object sender, EventArgs e)
		{
            try
            {
                if (serialPort1.IsOpen)
                {
                    //Send text to port
                    serialPort1.WriteLine("w"+cboSteps.Text + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

		private void btnDownY_Click(object sender, EventArgs e)
		{
            try
            {
                if (serialPort1.IsOpen)
                {
                    //Send text to port
                    serialPort1.WriteLine("s" + cboSteps.Text + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void btnDownX_Click(object sender, EventArgs e)
		{
            try
            {
                if (serialPort1.IsOpen)
                {
                    //Send text to port
                    serialPort1.WriteLine("a" + cboSteps.Text + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void btnUpX_Click(object sender, EventArgs e)
		{
            try
            {
                if (serialPort1.IsOpen)
                {
                    //Send text to port
                    serialPort1.WriteLine("d" + cboSteps.Text + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void btnUpZ_Click(object sender, EventArgs e)
		{
            try
            {
                if (serialPort1.IsOpen)
                {
                    //Send text to port
                    serialPort1.WriteLine("h" + cboSteps.Text + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void btnDownZ_Click(object sender, EventArgs e)
		{
            try
            {
                if (serialPort1.IsOpen)
                {
                    //Send text to port
                    serialPort1.WriteLine("y" + cboSteps.Text + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void btnRefresh_Click(object sender, EventArgs e)
		{
            string[] ports = SerialPort.GetPortNames();
            if (!ports.Equals(null))
            {
                cboPort.Items.Clear();
                cboPort.Items.AddRange(ports);
                cboPort.SelectedIndex = 0;
                if(ports.Length>0)
				cboPort.Text = cboPort.GetItemText(ports[0]);
            }
        }

		private void button1_Click(object sender, EventArgs e)
		{
            Form2 form2 = new Form2();
            form2.ShowDialog();
		}

		private void engravingFileButton_Click(object sender, EventArgs e)
		{
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                txtReceive.AppendText(filePath);
            }
            if (!filePath.Equals(String.Empty))
                btnEngravingStart.Enabled = true;
            else
                btnEngravingStart.Enabled = false;
        }

		private void engravingStartButton_Click(object sender, EventArgs e)
		{
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(filePath);
            commandList=new List<string>();
            engravingOn = false;
            commandCounter = 0;
            while ((line = file.ReadLine()) != null)
            {
                commandList.Add(line);
                commandCounter++;
            }
            file.Close();
            txtReceive.Invoke(this.myDelegate, new Object[] { Environment.NewLine+"Number of commands readed from file:"+commandCounter.ToString()+ Environment.NewLine});
            disableCotrols();
            engravingNextCommand();
        }
		private void engravingNextCommand()
		{
			if (engravingOn)
			{
                if(actualCommand<commandCounter-1)
                sendedCommand = commandList[actualCommand];
                writeToSerial(commandList[actualCommand]);
                actualCommand++;
			}
			else
			{
                sendedCommand = commandList[0];
                writeToSerial(commandList[0]);
                actualCommand = 1;
                engravingOn = true;
			}
            

        }
        private void writeToSerial(String command)
		{
            try
            {
                if (serialPort1.IsOpen)
                {
                    //Send text to port
                    serialPort1.WriteLine(command + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void btnGoToZero_Click(object sender, EventArgs e)
		{
            try
            {
                if (serialPort1.IsOpen)
                {
                    //Send text to port
                    serialPort1.WriteLine("z" + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void btnLaserOn_Click(object sender, EventArgs e)
		{
            try
            {
                if (serialPort1.IsOpen)
                {
                    //Send text to port
                    serialPort1.WriteLine("o" + Environment.NewLine);
                    if (btnLaserOn.Text.Equals("Laser On"))
                        btnLaserOn.Text = "Laser Off";
                    else
                        btnLaserOn.Text = "Laser On";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
	}
}
