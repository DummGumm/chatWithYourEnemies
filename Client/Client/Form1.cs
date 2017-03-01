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
        Form FrmVerbinden;
        AsyncTcpClient AsyClient;
        string strName;

        public Client(string[] strIP_Name, Form FRMVerbinden)
        {
            InitializeComponent();

            FrmVerbinden = FRMVerbinden;

            AsyClient = new AsyncTcpClient();
            AsyClient.PacketReceived += AsyClient_PacketReceived;
            AsyClient.Disconnected += AsyClient_Disconnected;

            Verbinden(strIP_Name);
        }

        private void AsyClient_Disconnected(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AsyClient_PacketReceived(object sender, PacketReceivedEventArgs e)
        {
            if (Encoding.UTF8.GetString(e.Packet) != strName + " hat den chat verlassen!")
            {
                TextVServer(Encoding.UTF8.GetString(e.Packet));
            }
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

        private void cmdTrennen_Click(object sender, EventArgs e)
        {
            AsyClient.SendPacket(Encoding.UTF8.GetBytes(strName + " hat den chat verlassen!"));
            AsyClient.Disconnect();

            cmdTrennen.Enabled = false;
            cmdSenden.Enabled = false;

            FrmVerbinden.Show();
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
                    NachrichtSenden();
                }
            }
        }

        private void NachrichtSenden()
        {
            AsyClient.SendPacket(Encoding.UTF8.GetBytes(strName + ": " + txtBoxZuServer.Text));
            txtBoxZuServer.Clear();
        }

        private void Verbinden(string[] strIP_Name)
        {
            strName = strIP_Name[1];
            txtBoxZuServer.Clear();
            lbChat.Items.Clear();

            string[] substring = strIP_Name[0].Split(':');

            AsyClient.Connect(IPAddress.Parse(substring[0]), Convert.ToInt32(substring[1]));
            cmdTrennen.Enabled = true;
            cmdSenden.Enabled = true;

            AsyClient.SendPacket(Encoding.UTF8.GetBytes(strName + " ist da!"));
        }

        private void emojiButtonPressed(object sender, EventArgs e)
        {
            txtBoxZuServer.Text += ((Button)sender).Text;
        }
    }

    delegate void SetTextCallback(string Text);
}
