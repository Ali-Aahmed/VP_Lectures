using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lect8_WithDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StudentDBEntities mainen = new StudentDBEntities();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("name is Requird");
                return;
            }
            tblStudent obj = new tblStudent();
            obj.name = textBox1.Text;
            obj.phone = textBox2.Text;
            obj.gpa = (double)numericUpDown1.Value;
            obj.date = dateTimePicker1.Value;

            mainen.tblStudents.Add(obj);
            int test = mainen.SaveChanges();
            if (test >= 1)
            {
                MessageBox.Show("Save Succssfully");
                Show();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Show();
        }
        void Show()
        {

            var list = mainen.tblStudents.ToList();

            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var raw = dataGridView1.Rows[e.RowIndex];
                txtId.Text = raw.Cells[0].Value.ToString();
                textBox1.Text = raw.Cells[1].Value.ToString();
                textBox2.Text = raw.Cells[2].Value.ToString();
                numericUpDown1.Text = raw.Cells[3].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(raw.Cells[4].Value);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var obj = mainen.tblStudents.Find(id);

            obj.name = textBox1.Text;
            obj.phone = textBox2.Text;
            obj.gpa = (double)numericUpDown1.Value;
            obj.date = dateTimePicker1.Value;


            int test = mainen.SaveChanges();
            if (test >= 1)
            {
                MessageBox.Show("Update Succssfully", "inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var obj = mainen.tblStudents.Find(id);

            mainen.tblStudents.Remove(obj);
            int test = mainen.SaveChanges();
            if (test >= 1)
            {
                MessageBox.Show("Delete Succssfully", "inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
            }
        }
    }
}