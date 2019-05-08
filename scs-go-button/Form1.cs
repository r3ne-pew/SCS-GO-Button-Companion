using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scs_go_button
{
    public partial class SCSGoButtonCompanion : Form
    {
        public SCSGoButtonCompanion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();//Opening the serial port
            serialPort1.WriteLine("STATE");

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string s = serialPort1.ReadExisting();//reads the serialport buffer
            if (s.Contains("trigger"))//checks if it is status
            {
                SendKeys.SendWait(" ");
            }
        }


    }
}
