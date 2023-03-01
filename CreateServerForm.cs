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


        public CreateServerForm(BindingList<string> bind, Form parentForm)
        {
            InitializeComponent();
            this.external_binding = bind;
            this.parentForm = parentForm;

        }

        private void CreateServerForm_Load(object sender, EventArgs e)
        {

        }

        private async void CreateBtn_Click(object sender, EventArgs e)
        {
            string ip = ipFvalue.Text;
            string port = portFvalue.Text;
            string connMsg = ConnMsg.Text;

            try
            {
                this.socket = new Zsocket(ip + ":" + port);
                socket.CreateTcpListener();
                socket.WaitClients(connMsg, this.external_binding, this.parentForm);
                
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
    }
}
