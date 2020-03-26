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
        SerialPort MyCOMPort = new SerialPort(); // Create a new SerialPort Object

           
        public Form1()
        {
            InitializeComponent();
             //COM port settings to 8N1 mode 
            MyCOMPort.PortName = "COM4";            // Name of the COM port 
            MyCOMPort.BaudRate = 9600;               // Baudrate = 9600bps
            MyCOMPort.Parity = Parity.None;        // Parity bits = none  
            MyCOMPort.DataBits = 8;                  // No of Data bits = 8
            MyCOMPort.StopBits = StopBits.One;       // No of Stop bits = 1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyCOMPort.Open();                        // Open the port
            MyCOMPort.RtsEnable = true;             
            MyCOMPort.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyCOMPort.Open();                        // Open the port
            MyCOMPort.RtsEnable = false;                 
            MyCOMPort.Close();
        }
    }
}
