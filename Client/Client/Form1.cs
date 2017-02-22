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
        string strName;

        public Client()
        {
            InitializeComponent();
            lbChat.Items.Add("Bitte Chat Namen eingeben.");

            AsyClient = new AsyncTcpClient();

            AsyClient.PacketReceived += AsyClient_PacketReceived;
        }

        private void AsyClient_PacketReceived(object sender, PacketReceivedEventArgs e)
        {
            TextVServer(Encoding.UTF8.GetString(e.Packet));
        }

        private void cmdSenden_Click(object sender, EventArgs e)
        {
            NachrichtSenden();
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
            Verbinden();
        }

        private void cmdTrennen_Click(object sender, EventArgs e)
        {
            AsyClient.SendPacket(Encoding.UTF8.GetBytes(strName + " hat den chat verlassen!"));
            AsyClient.Disconnect();

            cmdTrennen.Enabled = false;
            cmdSenden.Enabled = false;
            cmdVerbinden.Enabled = true;
        }

        private void txtBoxZuServer_Keypress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NachrichtSenden();
            }
        }

        private void txtBoxZuServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBoxZuServer.Text != "")
                {
                    if (cmdVerbinden.Enabled == true)
                    {
                        Verbinden();
                    }
                    else if (cmdSenden.Enabled == true)
                    {
                        NachrichtSenden();
                    }
                }
            }
        }

        private void NachrichtSenden()
        {
            AsyClient.SendPacket(Encoding.UTF8.GetBytes(strName + ": " + txtBoxZuServer.Text));
            txtBoxZuServer.Clear();
        }

        private void Verbinden()
        {
            strName = txtBoxZuServer.Text;
            txtBoxZuServer.Clear();
            lbChat.Items.Clear();

            AsyClient.Connect(IPAddress.Parse("10.200.14.187"), 80);
            cmdTrennen.Enabled = true;
            cmdSenden.Enabled = true;
            cmdVerbinden.Enabled = false;

            AsyClient.SendPacket(Encoding.UTF8.GetBytes(strName + " ist da!"));
        }

        private void emojiButtonPressed(object sender, EventArgs e)
        {
            txtBoxZuServer.Text += ((Button)sender).Text;
        }
    }

    delegate void SetTextCallback(string Text);
}
