namespace Lect1_Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("welcome in First program ", "معلومات ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}
