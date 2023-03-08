using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZchatServer.Sockets;

namespace ZchatServer
{
    public partial class CreateServerForm : Form
    {

        public Zsocket? socket;
        public BindingList<string> external_binding;
        public BindingList<string> chat_binding;
        public Form parentForm;


        public CreateServerForm(BindingList<string> bind, BindingList<string> chat, Form parentForm)
        {
            InitializeComponent();
            this.external_binding = bind;
            this.parentForm = parentForm;
            this.chat_binding = chat;
        }

        private void CreateServerForm_Load(object sender, EventArgs e)
        {

        }

        private async void CreateBtn_Click(object sender, EventArgs e)
        {
            string ip = ipFvalue.Text;
            string port = portFvalue.Text;
            //string connMsg = ConnMsg.Text;

            try
            {
                this.socket = new Zsocket(ip + ":" + port);
                socket.CreateTcpListener();
                //socket.ReadNewData(this.chat_binding, parentForm);
                socket.WaitClients(this.external_binding, this.chat_binding, this.parentForm);
                
                MessageBox.Show("Server is listening");
                this.DialogResult = DialogResult.OK;
            } catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.socket.CancelToken();
            this.socket.CloseAllConnections();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private Point _dragOffset;
        private void CreateServerForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragOffset = new Point(e.X, e.Y);
        }

        private void CreateServerForm_MouseMove(object sender, MouseEventArgs e)
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
