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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private Point _dragOffset;
        private void ConnectServerForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragOffset = new Point(e.X, e.Y);
        }
        private void ConnectServerForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newLocation = this.Location;
                newLocation.X += e.X - _dragOffset.X;
                newLocation.Y += e.Y - _dragOffset.Y;
                this.Location = newLocation;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Minimized;
        }
    }
}
