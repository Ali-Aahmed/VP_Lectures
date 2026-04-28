namespace Lect7_Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "allfiles|*.*|Text files|*.txt|word|*.docx|images|*.png;*.jpeg";
            openFileDialog1.Filter = "Text files|*.txt";
            openFileDialog1.Title = "Choose text files only";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files|*.txt";
            saveFileDialog1.FileName = "newFileTest";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(menuStrip1, "Tab controls for text files");
        }

        private void newFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm=new Form2();
            frm.ShowDialog();
        }
    }
}