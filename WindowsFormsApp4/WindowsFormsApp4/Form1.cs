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

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        SerialPort MyCom4 = new SerialPort(); // Create a new SerialPort Object

           
        public Form1()
        {
            InitializeComponent();
             //COM port settings to 8N1 mode 
            MyCom4.PortName = "COM4";            // Name of the COM port 
            MyCom4.BaudRate = 9600;               // Baudrate = 9600bps
            MyCom4.Parity = Parity.None;        // Parity bits = none  
            MyCom4.DataBits = 8;                  // No of Data bits = 8
            MyCom4.StopBits = StopBits.One;       // No of Stop bits = 1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyCom4.Open();                        // Open the port
            MyCom4.RtsEnable = true;             
            MyCom4.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyCom4.Open();                        // Open the port
            MyCom4.RtsEnable = false;                 
            MyCom4.Close();
        }
    }
}
