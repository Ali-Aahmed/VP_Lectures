using Lect6_MenuStrip;

namespace Lec6_MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
        /// Combobox
        /// menuStrip
        /// statusStrip
        /// ProgressBar
        /// ToolTip
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtFile.Clear();
            //txtFile.Text = "";
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {
            lblChars.Text = $"   Characters: {txtFile.Text.Length}";
            //Split the text into words using space as a delimiter
            // ahmed
            // mohamed
            // ali
            //string text = txtFile.Text;
            //string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //lblWords.Text = words.Length.ToString();
            lblWords.Text = $"   Words: {txtFile.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = $"   Time: {DateTime.Now.ToLongTimeString()}";
            progressBar1.Increment(10);
                if (progressBar1.Value == progressBar1.Maximum)
                {
                    progressBar1.Value = 0;
            }
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
