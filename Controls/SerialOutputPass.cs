﻿using MissionPlanner.Comms;
using System;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
    public partial class SerialOutputPass : Form
    {
        static TcpListener listener;
        // Thread signal. 
        public static ManualResetEvent tcpClientConnected = new ManualResetEvent(false);

        public SerialOutputPass()
        {
            InitializeComponent();

            chk_write.Checked = MainV2.comPort.MirrorStreamWrite;

            CMB_serialport.Items.AddRange(SerialPort.GetPortNames());
            CMB_serialport.Items.Add("TCP Host - 14550");
            CMB_serialport.Items.Add("TCP Client");
            CMB_serialport.Items.Add("UDP Host - 14550");
            CMB_serialport.Items.Add("UDP Client");

            if (MainV2.comPort.MirrorStream != null && MainV2.comPort.MirrorStream.IsOpen || listener != null)
            {
                BUT_connect.Text = "Stop";
            }
        }

        private void BUT_connect_Click(object sender, EventArgs e)
        {
            if (MainV2.comPort.MirrorStream != null && MainV2.comPort.MirrorStream.IsOpen || listener != null)
            {
                MainV2.comPort.MirrorStream.Close();
                BUT_connect.Text = "Connect";
            }
            else
            {
                try
                {
                    switch (CMB_serialport.Text)
                    {
                        case "TCP Host - 14550":
                        case "TCP Host":
                            {
                                MainV2.comPort.MirrorStream = new TcpSerial();
                                CMB_baudrate.SelectedIndex = 0;
                                int port = 14550;
                                if (InputBox.Show("Port", "Enter port", ref port) != DialogResult.OK)
                                    return;
                                listener = new TcpListener(System.Net.IPAddress.Any, port);
                                listener.Start(0);
                                listener.BeginAcceptTcpClient(new AsyncCallback(DoAcceptTcpClientCallback), listener);
                                BUT_connect.Text = "Stop";
                                return;
                            }

                        case "TCP Client":

                            MainV2.comPort.MirrorStream = new TcpSerial() { retrys = 999999, autoReconnect = true };
                            CMB_baudrate.SelectedIndex = 0;
                            break;
                        case "UDP Host - 14550":
                            {
                                int port = 14550;
                                if (InputBox.Show("Port", "Enter port", ref port) != DialogResult.OK)
                                    return;
                                MainV2.comPort.MirrorStream = new UdpSerial()
                                { ConfigRef = "SerialOutputPassUDP", Port = port.ToString() };
                                CMB_baudrate.SelectedIndex = 0;
                                break;
                            }

                        case "UDP Client":
                            MainV2.comPort.MirrorStream = new UdpSerialConnect() { ConfigRef = "SerialOutputPassUDPCL" };
                            CMB_baudrate.SelectedIndex = 0;
                            break;
                        default:
                            MainV2.comPort.MirrorStream = new SerialPort();
                            MainV2.comPort.MirrorStream.PortName = CMB_serialport.Text;
                            break;
                    }
                }
                catch
                {
                    CustomMessageBox.Show("InvalidPortName");
                    return;
                }

                try
                {
                    MainV2.comPort.MirrorStream.BaudRate = int.Parse(CMB_baudrate.Text);
                }
                catch
                {
                    CustomMessageBox.Show("InvalidBaudRate");
                    return;
                }
                try
                {
                    MainV2.comPort.MirrorStream.Open();
                }
                catch
                {
                    CustomMessageBox.Show("Error Connecting\nif using com0com please rename the ports to COM??");
                    return;
                }
            }
        }

        void DoAcceptTcpClientCallback(IAsyncResult ar)
        {
            // Get the listener that handles the client request.
            TcpListener listener = (TcpListener)ar.AsyncState;

            // End the operation and display the received data on  
            // the console.
            TcpClient client = listener.EndAcceptTcpClient(ar);

            ((TcpSerial)MainV2.comPort.MirrorStream).client = client;

            listener.BeginAcceptTcpClient(new AsyncCallback(DoAcceptTcpClientCallback), listener);
        }

        private void chk_write_CheckedChanged(object sender, EventArgs e)
        {
            MainV2.comPort.MirrorStreamWrite = chk_write.Checked;
        }
    }
}