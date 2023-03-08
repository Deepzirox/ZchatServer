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

        // Create a list to bind the chat message field to a AdminSocket
        private BindingList<string> chat = new BindingList<string>();


        private bool _firtsClick = true;

        public ChatServer()
        {
            InitializeComponent();
            ConnectedIps.DataSource = connectedClients;
            Chat.DataSource = chat;
            this.Zsocketsocket = null;
        }

        private void ChatServer_Load(object sender, EventArgs e)
        {
            
        }

        // not finished yet
        private async void ibuttonsend_Click(object sender, EventArgs e)
        {
            if (this.Zsocketsocket == null)
                return;
            string userName = UserName.Text;
            string value = iprompt.Text;
            this.Zsocketsocket.BroadCast($"{userName} says: {value}");
            this.Zsocketsocket.ReadNewData(chat, this);
            
            //Chat.Items.Add(UserNameItem.Text + ": " + this.Zsocketsocket.ReadFromAdmin());
            
            //imessagesfield.SelectionStart = imessagesfield.Text.Length;
            //imessagesfield.ScrollToCaret();
        }

        private void ibuttondelete_Click(object sender, EventArgs e)
        {
            iprompt.Text = "Escribe algo...";
            _firtsClick = true;
        }

        private void CloseServerBtn_Click(object sender, EventArgs e)
        {
            if (this.Zsocketsocket != null)
            {
                this.Zsocketsocket.CleanUp();
                this.connectedClients.Clear();
                ServerInfo.Items.Clear();
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
            CreateServerForm csf = new(this.connectedClients, this.chat, this);
            DialogResult res = await Task.Run(() => csf.ShowDialog());
            if (csf.socket != null)
                this.Zsocketsocket = csf.socket;

            if (res == DialogResult.OK)
            {
                StatusMsg.Text = "Server connected";
                CloseServerBtn.Visible = true;
                StatusMsg.ForeColor = Color.Green;
                if (this.Zsocketsocket.Ip != null)
                {
                    ServerInfo.Items.Add($"This is your server info.");
                    ServerInfo.Items.Add($"IP = {this.Zsocketsocket.Ip}");
                    ServerInfo.Items.Add($"PORT = {this.Zsocketsocket.Port}");
                    
                }
               
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

        private void iprompt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem1_MouseDown(object sender, MouseEventArgs e)
        {
            BackColor= Color.Red;
            
        }

        private void iprompt_Click(object sender, EventArgs e)
        {
            if (_firtsClick)
            {

                iprompt.Text = "";

                _firtsClick = false; 
            }
            
        }

        private Point _dragOffset;

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragOffset = new Point(e.X, e.Y);
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newLocation = this.Location;
                newLocation.X += e.X - _dragOffset.X;
                newLocation.Y += e.Y - _dragOffset.Y;
                this.Location = newLocation;
            }
        }
    }
}
