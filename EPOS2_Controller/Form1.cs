using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using serialDriver;
using System.IO;
using System.Net.Sockets;
using System.IO.Ports;
using EposCmd;
using EposCmd.Net.DeviceCmdSet.DataRecorder;
using System.Runtime.InteropServices;
using EposCmd.Net;
using System.Threading;

namespace EPOS2_Controller
{
    public partial class Form1 : Form
    {
        string portName = "COM14"; // Port name
                                   // (adjust as needed)
        uint baudrate = 14400; // Baudrate
        uint timeout = 500; // Timeout in ms
        ushort nodeId = 1; // Node ID   
       
        bool Startread = true;

        Thread thread;

        EPOS2_Driver ePOS2_Driver = new EPOS2_Driver();

        public Form1()
        {
            InitializeComponent();
        }

        private void mConnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ePOS2_Driver.Connect(portName, baudrate, timeout, nodeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mSetrpmBtn_Click(object sender, EventArgs e)
        {
            int rpm = Convert.ToInt32(mDataShowTxtBox.Text);
            ePOS2_Driver.Start(rpm);
        }

        private void mHaltBtn_Click(object sender, EventArgs e)
        {
            ePOS2_Driver.Stop();
        }

        private void mEnableBtn_Click(object sender, EventArgs e)
        {
            thread = new Thread(readvelocity);
            thread.Start();
            ePOS2_Driver.Enable();
        }
        private void mDisableBtn_Click(object sender, EventArgs e)
        {
            ePOS2_Driver.Disable();
            Startread = false;
            thread.Abort(100);
            thread.Join();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ePOS2_Driver.DisConnect();
            Startread = false ;
        }

        private void readvelocity()
        {
            while (Startread)
            {
                Thread.Sleep(500);
                long data = ePOS2_Driver.GetActualVelocity();

                if (InvokeRequired)
                {
                    mVelocityActualLbl.Invoke(new Action(() => mVelocityActualLbl.Text = data.ToString()));
                }
                else
                {
                    mVelocityActualLbl.Text = data.ToString();
                }
            }
        }        
    }
}
