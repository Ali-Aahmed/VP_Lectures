namespace Lect4_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string order = "";

            if (rdpChecken.Checked)
            {
                order = rdpChecken.Text;
            }
            else if (rdpMeat.Checked)
            {
                order = rdpMeat.Text;
            }
            else
            {
                order = rdpFish.Text;
            }

            order += " | ";
            if (chkTorshy.Checked)
            {
                order += " ," + chkTorshy.Text;
            }
            if (chkTomia.Checked)
            {
                order += " ," + chkTomia.Text;
            }
            if (chkTahina.Checked)
            {
                order += " ," + chkTahina.Text;
            }
            //order += " | ";
            //order += listDrinks.SelectedItem.ToString();
            order += " | ";
            for (int i = 0; i < chkListDrinks.CheckedItems.Count; i++)
            {
                order += chkListDrinks.CheckedItems[i].ToString() + " , ";
            }
            order += " | ";
            order += chkListDrinks.SelectedItem.ToString();
            lblSummary.Text = order;

        }

    }
}
