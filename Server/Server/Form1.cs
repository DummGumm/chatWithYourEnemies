using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    public partial class Server : Form
    {
        AsyncTcpServer AsyServer;

        public Server()
        {
            InitializeComponent();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            //AsyServer = new AsyncTcpServer(IPAddress.Parse("127.0.0.1"), 20);
            AsyServer = new AsyncTcpServer(IPAddress.Any, 20);
            AsyServer.Start();
            
            AsyServer.ClientConnected += Server_ClientConnected;
            AsyServer.ClientDisconnected += Server_ClientDisconnected;
            AsyServer.PacketReceived += Server_PacketReceived;

            lb.Items.Add("Server Gestartet");

            cmdStart.Enabled = false;
            cmdStop.Enabled = true;
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            AsyServer.Stop();
            lb.Items.Add("Server Gestopt");
            cmdStart.Enabled = true;
            cmdStop.Enabled = false;
        }

        private void Server_ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            lbEintrag(e.Client, "Client " + e.Client.Client.RemoteEndPoint + " verbunden");
            //MessageBox.Show("client Connected" + e.Client.ToString());
            //lblTextVserver.Text = "Verbunden";
        }

        private void Server_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            lbEintrag(e.Client, "Client " + e.Client.Client.RemoteEndPoint + " getrennt");
            //MessageBox.Show("Disconnected");
        }

        private void Server_PacketReceived(object sender, PacketReceivedEventArgs e)
        {
            //MessageBox.Show(System.Text.Encoding.ASCII.GetString(e.Packet));
            AsyServer.SendPacket(e.Sender, e.Packet);
        }

        private void lbEintrag(TcpClient client, string Text)
        {
            if (lb.InvokeRequired)
            {
                WritetoListBox g = new WritetoListBox(lbEintrag);
                Invoke(g, new object[] { client, Text });

            }
            else
            {
                lb.Items.Add(Text);
            }
        }
    }
    delegate void WritetoListBox(TcpClient client, string Text);
}
