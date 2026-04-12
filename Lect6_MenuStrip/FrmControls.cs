using Lect6_MenuStrip;

namespace Lec6_MenuStrip
{
    public partial class FrmControls : Form
    {
        public FrmControls()
        {
            InitializeComponent();
        } 
        /// Combobox
        /// menuStrip
        /// statusStrip
        /// ProgressBar
        /// ToolTip 

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbDepartments.Items.Add(txtDepart.Text);
            txtDepart.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbDepartments.Items.Remove(cmbDepartments.Text);


        }

        private void cmbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int ff = cmbDepartments.SelectedIndex;
            //string ff4 = cmbDepartments.SelectedItem.ToString();


            //MessageBox.Show($"You selected: {cmbDepartments.SelectedText}");

        }
    }
}
