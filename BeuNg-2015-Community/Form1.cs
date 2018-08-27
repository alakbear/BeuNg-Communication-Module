using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using BeuNg_2015_Community.Classes;

namespace BeuNg_2015_Community
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public static Form1 Self;
        static string mySerialCommunicationPort;
        static int myBaudRate;
        static List<string> myParsedDataFromSerial;
        static string incomingTeamID;
        static string incomingMissionTime;
        static string incomingPacketCount;
        static float incomingHeight;
        static float incomingPressure;
        static float incomingTemperature;
        static int incomingVoltage;
        static string incomingGpstime;
        static string incomingLongtitude;
        static string incomingLengtitude;
        static float incomingSpeed;
        static string incomingGpsSatteliteCount;
        static int incomingHumidity;
        public static bool program_state = false;

        public Form1()
        {
            Self = this;
            InitializeComponent();
            Utilities.getAvailablePorts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
        }


        //static void threadingCallback(object args)
        //{
        //    incomingSpeed = Services.getSpeed(myParsedDataFromSerial);
        //    incomingHeight = Services.getHeight(myParsedDataFromSerial);
        //    incomingPressure = Services.getPressure(myParsedDataFromSerial);
        //    incomingTemperature = Services.getTemperature(myParsedDataFromSerial);
        //    incomingHumidity = Services.getHumidity(myParsedDataFromSerial);
        //    incomingVoltage = Services.getVoltage(myParsedDataFromSerial);
        //}

        //Updating plotting charts in this method
        private void timer1_Tick(object sender, EventArgs e)
        {


            incomingSpeed = Services.getSpeed(myParsedDataFromSerial);
            incomingHeight = Services.getHeight(myParsedDataFromSerial);
            incomingPressure = Services.getPressure(myParsedDataFromSerial);
            incomingTemperature = Services.getTemperature(myParsedDataFromSerial);
            incomingHumidity = Services.getHumidity(myParsedDataFromSerial);
            incomingVoltage = Services.getVoltage(myParsedDataFromSerial);

            chart1.Series["Sürət"].Points.AddY(incomingSpeed);
            chart2.Series["Hündürlük"].Points.AddY(incomingHeight);
            chart3.Series["Temperatur"].Points.AddY(incomingTemperature);
            chart4.Series["Təzyiq"].Points.AddY(incomingPressure);

            circularProgressBar1.Value = incomingVoltage;
            circularProgressBar1.Text = string.Format("{0:0.0}\r\nV", incomingVoltage);

            circularProgressBar2.Value = incomingHumidity;
            circularProgressBar2.Text = string.Format("{0:0.0}\r\n%", incomingHumidity);

            myParsedDataFromSerial = DataFromSerial.getDataFromSerialPort(mySerialCommunicationPort, myBaudRate);

        }


        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Start mission
        private void button7_Click(object sender, EventArgs e)
        {

            //System.Threading.Timer threadingTimer = new System.Threading.Timer(threadingCallback, 10, 1, 100);
            program_state = true;
            serialPort1.Close();

            try
            {
                if (comPort.SelectedItem != null || baudRate.SelectedItem != null)
                {
                    mySerialCommunicationPort = comPort.SelectedItem.ToString();
                    myBaudRate = Convert.ToInt32(baudRate.SelectedItem.ToString());
                    myParsedDataFromSerial = DataFromSerial.getDataFromSerialPort(mySerialCommunicationPort, myBaudRate);
                    timer1.Enabled = true;
                    timer1.Start();
                    MessageBox.Show("Missiya Basladi");
                }
                else
                {
                    MessageBox.Show("Missiyani bawlatmaq ucun port ve baud reyti secin");
                }
            }
            catch (Exception ex)
            {
                program_state = false;
                MessageBox.Show(" Xeta bash verdi! " + ex.Message);
            }
        }

        //Refresh button
        private void button3_Click(object sender, EventArgs e)
        {
            Buttons.refreshButton();
        } 

        //Reset button
        private void button6_Click(object sender, EventArgs e)
        {
            Buttons.resetButton();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            if(program_state == true)
            {
                program_state = false;
                MessageBox.Show("Missiyanı sonlandır əmri UĞURLU alındı.");
            }
            else
            {
                MessageBox.Show("Missiyani bawlatmamisiz");
            }
            
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
