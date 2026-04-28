using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lect7_Dialogs
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog obj = new OpenFileDialog();
            obj.Filter = "Images|*.png;*.Jpeg";
            obj.Title = "اختر صورة...";
            if (obj.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(obj.FileName);
            }
        } 
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog obj = new SaveFileDialog();

            obj.Filter = "Images|*.png;*.Jpeg";
            obj.Title = "اختر صورة...";
            obj.FileName = "test";
            if (obj.ShowDialog() == DialogResult.OK)
            {
                DialogResult ob = MessageBox.Show("هل تحتاج حفظ الصورة", "test", MessageBoxButtons.YesNo);
                if (ob == DialogResult.Yes)
                {
                    pictureBox1.Image.Save(obj.FileName);
                }
                else
                {

                 MessageBox.Show("شكرا", "test", MessageBoxButtons.OK);

                }

            } 
        }
    }
}
