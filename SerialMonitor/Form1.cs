using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SerialMonitor
{
    public partial class Form1 : Form
    {

        // Create the serial port with basic settings 
        private string ReceivedData; //received data
        private SerialPort SerPort = new SerialPort();
        string out_text;
        string value;


        public Form1()
        {
        InitializeComponent();
        FetchAvailablePorts();
        }

        void FetchAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();//Put the name of the available USB ports into the ports string array
            AvailablePortsBox.Items.AddRange(ports); //Add the string into the dropdown list we made
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            LBL_status.Text = "Connecting...";

            if (SerPort.IsOpen)
            {
                SerPort.Close();
                Console.WriteLine("DISCONNECTED");
                LBL_status.Text = "DISCONNECTED";
            }

            else
            {
                Console.WriteLine("Connection.... Incoming Data:");
                // Begin communications 
                SerPort.BaudRate = 9600;
                SerPort.PortName = AvailablePortsBox.Text;
                SerPort.DataReceived += SerPort_DataReceived;
                
                try
                {
                    SerPort.Open(); //We open the port
                    Thread.Sleep(1000); //We wait a sec
                    LBL_status.Text = "CONNECTED";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                    LBL_status.Text = "ERROR";

                }
            }
        }

        private void SerPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(100);
            int len = SerPort.BytesToRead;
            byte[] buf = new byte[len];
            SerPort.Read(buf, 0, len);

            string inbuf = BitConverter.ToString(buf).Replace("-", "");

            if (inbuf.StartsWith("16"))
            {
                out_text = inbuf+"\r\n";
                value = int.Parse(inbuf.Substring(10, 4), System.Globalization.NumberStyles.HexNumber).ToString();
                this.Invoke(new Action(ProcessingData));
            }


            //}

            
            //Console.WriteLine("Received Data:" + BitConverter.ToString(buf).Replace("-", ""));
            //textdata += BitConverter.ToString(buf);

            //ReceivedData = SerPort.ReadByte().ToString("X2"); //We read the serial port
            //this.Invoke(new Action(ProcessingData)); //execute the delegate (ProcessingData)

        }

        private void ProcessingData()
        {
            DateTimeOffset now = (DateTimeOffset)DateTime.UtcNow;
            textBox2.AppendText(now.ToString("yyyy/MM/dd    HH-mm-ss-fff") + "    " + out_text);

            Color red = System.Drawing.Color.Red;
            Color green = System.Drawing.Color.Green;

            if (int.Parse(value) > 25)
            {
                LBL.ForeColor = red;
                LBL_155_a.ForeColor = red;
                LBL_155_g.ForeColor = red;
                LBL_OMS_a.ForeColor = red;
                LBL_OMS_g.ForeColor = red;
            }

            if (int.Parse(value) < 25)
            {
                LBL.ForeColor = green;
                LBL_155_a.ForeColor = red;
                LBL_155_g.ForeColor = green;
                LBL_OMS_a.ForeColor = red;
                LBL_OMS_g.ForeColor = red;
            }

            if (int.Parse(value) < 20)
            {
                LBL.ForeColor = green;
                LBL_155_a.ForeColor = green;
                LBL_155_g.ForeColor = green;
                LBL_OMS_a.ForeColor = red;
                LBL_OMS_g.ForeColor = red;
            }

            if (int.Parse(value) < 15)
            {
                LBL.ForeColor = green;
                LBL_155_a.ForeColor = green;
                LBL_155_g.ForeColor = green;
                LBL_OMS_a.ForeColor = red;
                LBL_OMS_g.ForeColor = green;
            }

            if (int.Parse(value) < 5)
            {
                LBL.ForeColor = green;
                LBL_155_a.ForeColor = green;
                LBL_155_g.ForeColor = green;
                LBL_OMS_a.ForeColor = green;
                LBL_OMS_g.ForeColor = green;
            }

            LBL.Text = value + " μg/mc";
        }

        private void prescription_Click(object sender, EventArgs e)
        {

        }
    }
            
    }

