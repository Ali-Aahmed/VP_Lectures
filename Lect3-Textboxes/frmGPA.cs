namespace Lect3_Textboxes
{
    public partial class frmGPA : Form
    {
        public frmGPA()
        {
            InitializeComponent();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtScore1.Text = txtScore2.Text =
                lblAvg.Text = lblResult.Text = string.Empty;


        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double s1 = Convert.ToDouble(txtScore1.Text);
            double s2 = Convert.ToDouble(txtScore2.Text);

            double avg = (s1 + s2) / 2;
            lblAvg.Text = avg.ToString();

            if (avg < 60)
            {
                lblResult.Text = "راسب";
                lblResult.BackColor = Color.Red;
            }
            else if (avg <= 80)
            {
                lblResult.Text = "جيد جدا";
                lblResult.BackColor = Color.Green;

            }
            else
            {
                lblResult.Text = "امتياز";
                lblResult.BackColor = Color.Green;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
