using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZchatServer.Sockets;

namespace ZchatServer
{
    public partial class ChatServer : Form
    {

        Zsocket? Zsocketsocket;
        // Create a binding list to store the connected clients' IP addresses
        private BindingList<string> connectedClients = new BindingList<string>();


        public ChatServer()
        {
            InitializeComponent();
            ConnectedIps.DataSource = connectedClients;
            this.Zsocketsocket = null;
        }

        private void ChatServer_Load(object sender, EventArgs e)
        {
            
        }

        // not finished yet
        private void ibuttonsend_Click(object sender, EventArgs e)
        {
            string value = iprompt.Text;
            
            imessagesfield.SelectionStart = imessagesfield.Text.Length;
            imessagesfield.ScrollToCaret();
        }

        private void ibuttondelete_Click(object sender, EventArgs e)
        {
            iprompt.Text = "Escribe algo...";
            
        }

        private void CloseServerBtn_Click(object sender, EventArgs e)
        {
            if (this.Zsocketsocket != null)
            {
                this.Zsocketsocket.CleanUp();
                this.connectedClients.Clear();
            }
            CloseServerBtn.Visible = false;
            StatusMsg.Text = "Server disconnected";
            StatusMsg.ForeColor = Color.Red;
        }

        private async void connectToExistingServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectServerForm csf = new();
            DialogResult result = await Task.Run(() => csf.ShowDialog());

            if (csf.ConnectedSucceed)
            {
                MessageBox.Show("Server connected");
            }
            else
            {
                MessageBox.Show("No connection stablished");
            }
        }

        private async void createNewServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateServerForm csf = new(this.connectedClients, this);
            DialogResult res = await Task.Run(() => csf.ShowDialog());
            if (csf.socket != null)
                this.Zsocketsocket = csf.socket;

            if (res == DialogResult.OK)
            {
                StatusMsg.Text = "Server connected";
                CloseServerBtn.Visible = true;
                StatusMsg.ForeColor = Color.Green;
            }
            csf.socket = null;
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void golaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
