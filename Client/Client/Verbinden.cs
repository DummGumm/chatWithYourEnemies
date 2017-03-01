using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Verbinden : Form
    {
        string[] IP_Name;
        Client Client;

        public Verbinden()
        {
            InitializeComponent();
            IP_Name = new string[2];
        }

        private void cmdVerbinden_Click(object sender, EventArgs e)
        {
            IP_Name[0] = txtAdresse.Text;
            IP_Name[1] = txtName.Text;
            Client = new Client(IP_Name, this);
            Client.Show();
            this.Hide();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Verbinden_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
