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

namespace HelloWorld
{
    public partial class Form8 : Form
    {
        SerialPort port;
        public Form8()
        {
            InitializeComponent();
            InitializePort("COM3");
        }

        public void InitializePort(String portName)
        {
            if(port == null)
            {
                port = new SerialPort(portName, 9600);
                port.Open();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PortWrite("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PortWrite("0");
        }

        private void PortWrite(String message)
        {
            if (port != null && port.IsOpen)
            {
                port.Write(message);
            }
        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(port != null && port.IsOpen)
            {
                port.Close();
            }
        }
    }
}
