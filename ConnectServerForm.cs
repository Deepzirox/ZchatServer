using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZchatServer
{
    public partial class ConnectServerForm : Form
    {
        public bool ConnectedSucceed { get; set; }
        public ConnectServerForm()
        {
            InitializeComponent();
        }

        private void ConnectServerForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ConnectedSucceed = true;
        }
    }
}
