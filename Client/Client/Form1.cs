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

namespace Client
{
    public partial class Client : Form
    {
        AsyncTcpClient AsyClient;

        public Client()
        {
            InitializeComponent();

            AsyClient = new AsyncTcpClient();

            AsyClient.PacketReceived += AsyClient_PacketReceived;
        }

        private void AsyClient_PacketReceived(object sender, PacketReceivedEventArgs e)
        {
            TextVServer(Encoding.ASCII.GetString(e.Packet));
        }

        private void cmdSenden_Click(object sender, EventArgs e)
        {
            AsyClient.SendPacket(Encoding.ASCII.GetBytes(txtBoxZuServer.Text));
        }

        private void TextVServer(string Text)
        {
            if (lbChat.InvokeRequired)
            {
                SetTextCallback g = new SetTextCallback(TextVServer);
                Invoke(g, new object[] { Text });
            }
            else
            {
                lbChat.Items.Add(Text);
            }
        }

        private void cmdVerbinden_Click(object sender, EventArgs e)
        {
            AsyClient.Connect(IPAddress.Parse("127.0.0.1"), 20);
            cmdTrennen.Enabled = true;
            cmdSenden.Enabled = true;
            cmdVerbinden.Enabled = false;
        }

        private void cmdTrennen_Click(object sender, EventArgs e)
        {
            cmdSenden.Enabled = false;
        }

        private void emojiButtonPressed(object sender, EventArgs e)
        {
            txtBoxZuServer.Text += ((Button)sender).Text;
        }
    }

    delegate void SetTextCallback(string Text);
}
