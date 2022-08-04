using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siap
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void administrarToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            administrarToolStripMenuItem.ForeColor = Color.Black;
        }

        private void administrarToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            administrarToolStripMenuItem.ForeColor = Color.White;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
