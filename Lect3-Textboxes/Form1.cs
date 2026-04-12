namespace Lect3_Textboxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtEgp.Text != "")
            {
                double valueEgp = Convert.ToDouble(txtEgp.Text);
                txtDollar.Text = (valueEgp / 49.6).ToString();
            }
            else
            {
                MessageBox.Show("الرجاء ادخل قيمة صحيحة", "معلومة", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            }
        }

        private void txtDollar_TextChanged(object sender, EventArgs e)
        {
            double valueDollar = Convert.ToDouble(txtDollar.Text);
            txtEgp.Text = (valueDollar * 49.6).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        { 
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
         
        }
    }
}
