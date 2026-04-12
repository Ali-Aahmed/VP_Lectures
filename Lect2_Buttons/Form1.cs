namespace Lect2_Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Test Events....";
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            btnTest1.Visible = btnTest2.Visible = false;
            lblMessage.Text = "Button Test  Clicked...";
        }

        private void btnTest1_Click(object sender, EventArgs e)
        {
            btnTest.BackColor = btnTest2.BackColor = Color.Yellow;
            lblMessage.Text = "Button Test1 Clicked...";
        
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            btnTest.ForeColor = btnTest1.ForeColor = Color.Blue;
            lblMessage.Text = "Button Test2 Clicked...";
        }
    }
}
