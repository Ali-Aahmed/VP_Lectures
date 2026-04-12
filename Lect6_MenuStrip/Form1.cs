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
            FrmControls frm = new  FrmControls ();
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
    }
}
