using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lect5_Timer
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }
        public frmTest(string mes)
        {
            InitializeComponent();
            message = mes;
        }
        string message;
        private void frmTest_Load(object sender, EventArgs e)
        {
            rchMessage.Text = message;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchMessage.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchMessage.ForeColor = Color.Green;

        }
    }
}
