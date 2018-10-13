using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectApartment
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmStRoom room = new frmStRoom();
            room.MdiParent = this;
            room.Show();

         
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmMeter room = new frmMeter();
            room.MdiParent = this;
            room.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmCustomer room = new frmCustomer();
            room.MdiParent = this;
            room.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmRenal room = new frmRenal();
            room.MdiParent = this;
            room.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmInvoice room = new frmInvoice();
            room.MdiParent = this;
            room.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmReceipt room = new frmReceipt();
            room.MdiParent = this;
            room.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            frmMoveOut room = new frmMoveOut();
            room.MdiParent = this;
            room.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            frmReport room = new frmReport();
            room.MdiParent = this;
            room.Show();
        }
    }
}
