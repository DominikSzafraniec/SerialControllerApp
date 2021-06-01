using System;
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
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
        {
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
            btnClose.Enabled = false;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            this.myDelegate = new AddDataDelegate(AddDataMethod);
        }
        public void AddDataMethod(String myString)
        {
            txtReceive.AppendText(DateTime.UtcNow.ToString("HH:mm:ss")+ ": " + myString);
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string s = sp.ReadExisting();

            txtReceive.Invoke(this.myDelegate, new Object[] { s });
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            btnOpen.Enabled = false;
            btnClose.Enabled = true;
            btnRefresh.Enabled = false;
            try
            {
                //Open port
                serialPort1.PortName = cboPort.Text;
                serialPort1.BaudRate = int.Parse(cboBaundRate.Text);
                serialPort1.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cboPort.Items.AddRange(ports);
                cboPort.SelectedIndex = 0;
                cboPort.Text = cboPort.GetItemText(ports[0]);
            }
        }

		private void button1_Click(object sender, EventArgs e)
		{
            Form2 form2 = new Form2();
            form2.ShowDialog();
		}

	}
	
}
