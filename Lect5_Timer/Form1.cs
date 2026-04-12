namespace Lect5_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //interval  1000 MS= 1 Sec
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            dtmDate.Value = DateTime.Now;
            i++;

            //if (i == 5)// 3 secs
            //{
            //    // this.Hide();
            //    frmTest fr = new frmTest("Weclome");
            //    fr.ShowDialog();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void dtmDate_ValueChanged(object sender, EventArgs e)
        {

        }
        // Timer
        // DateTimePaker
        // RichtextBox
        // new form 
        // ContextMenuStrip
    }
}
