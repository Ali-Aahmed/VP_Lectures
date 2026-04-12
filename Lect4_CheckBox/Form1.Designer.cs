namespace Lect4_CheckBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            lblSummary = new Label();
            groupBox1 = new GroupBox();
            chkTahina = new CheckBox();
            chkTomia = new CheckBox();
            chkTorshy = new CheckBox();
            rdpMeat = new RadioButton();
            rdpChecken = new RadioButton();
            groupBox2 = new GroupBox();
            rdpFish = new RadioButton();
            listDrinks = new ListBox();
            chkListDrinks = new CheckedListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(350, 556);
            button1.Margin = new Padding(6, 7, 6, 7);
            button1.Name = "button1";
            button1.Size = new Size(194, 66);
            button1.TabIndex = 0;
            button1.Text = "تأكيد الطلب";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblSummary
            // 
            lblSummary.BackColor = Color.FromArgb(255, 192, 128);
            lblSummary.Dock = DockStyle.Bottom;
            lblSummary.ForeColor = Color.Black;
            lblSummary.Location = new Point(0, 727);
            lblSummary.Margin = new Padding(6, 0, 6, 0);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(909, 59);
            lblSummary.TabIndex = 2;
            lblSummary.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkTahina);
            groupBox1.Controls.Add(chkTomia);
            groupBox1.Controls.Add(chkTorshy);
            groupBox1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox1.Location = new Point(523, 16);
            groupBox1.Margin = new Padding(6, 7, 6, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 7, 6, 7);
            groupBox1.Size = new Size(344, 284);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "الاضافات";
            // 
            // chkTahina
            // 
            chkTahina.AutoSize = true;
            chkTahina.Location = new Point(74, 205);
            chkTahina.Name = "chkTahina";
            chkTahina.Size = new Size(144, 58);
            chkTahina.TabIndex = 9;
            chkTahina.Text = "طحينة";
            chkTahina.UseVisualStyleBackColor = true;
            // 
            // chkTomia
            // 
            chkTomia.AutoSize = true;
            chkTomia.Location = new Point(87, 130);
            chkTomia.Name = "chkTomia";
            chkTomia.Size = new Size(131, 58);
            chkTomia.TabIndex = 8;
            chkTomia.Text = "تومية";
            chkTomia.UseVisualStyleBackColor = true;
            // 
            // chkTorshy
            // 
            chkTorshy.AutoSize = true;
            chkTorshy.Location = new Point(90, 55);
            chkTorshy.Name = "chkTorshy";
            chkTorshy.Size = new Size(128, 58);
            chkTorshy.TabIndex = 7;
            chkTorshy.Text = "مخلل";
            chkTorshy.UseVisualStyleBackColor = true;
            // 
            // rdpMeat
            // 
            rdpMeat.AutoSize = true;
            rdpMeat.Location = new Point(116, 136);
            rdpMeat.Name = "rdpMeat";
            rdpMeat.Size = new Size(120, 58);
            rdpMeat.TabIndex = 12;
            rdpMeat.Text = "لحمة";
            rdpMeat.UseVisualStyleBackColor = true;
            // 
            // rdpChecken
            // 
            rdpChecken.AutoSize = true;
            rdpChecken.Location = new Point(128, 72);
            rdpChecken.Name = "rdpChecken";
            rdpChecken.Size = new Size(108, 58);
            rdpChecken.TabIndex = 11;
            rdpChecken.Text = "فراخ";
            rdpChecken.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdpFish);
            groupBox2.Controls.Add(rdpChecken);
            groupBox2.Controls.Add(rdpMeat);
            groupBox2.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.WhiteSmoke;
            groupBox2.Location = new Point(73, 16);
            groupBox2.Margin = new Padding(6, 7, 6, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6, 7, 6, 7);
            groupBox2.Size = new Size(329, 284);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "نوع الوجبة";
            // 
            // rdpFish
            // 
            rdpFish.AutoSize = true;
            rdpFish.Checked = true;
            rdpFish.Location = new Point(106, 192);
            rdpFish.Name = "rdpFish";
            rdpFish.Size = new Size(130, 58);
            rdpFish.TabIndex = 13;
            rdpFish.TabStop = true;
            rdpFish.Text = "سمك";
            rdpFish.UseVisualStyleBackColor = true;
            // 
            // listDrinks
            // 
            listDrinks.FormattingEnabled = true;
            listDrinks.ItemHeight = 37;
            listDrinks.Items.AddRange(new object[] { "عصير", "شاى", "قهوة" });
            listDrinks.Location = new Point(523, 354);
            listDrinks.Name = "listDrinks";
            listDrinks.Size = new Size(344, 152);
            listDrinks.TabIndex = 12;
            // 
            // chkListDrinks
            // 
            chkListDrinks.CheckOnClick = true;
            chkListDrinks.FormattingEnabled = true;
            chkListDrinks.Items.AddRange(new object[] { "قهوة سادة", "شاى سادة", "عصير بدون سكر" });
            chkListDrinks.Location = new Point(73, 354);
            chkListDrinks.Name = "chkListDrinks";
            chkListDrinks.Size = new Size(329, 156);
            chkListDrinks.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(909, 786);
            Controls.Add(chkListDrinks);
            Controls.Add(listDrinks);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblSummary);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label lblSummary;
        private GroupBox groupBox1;
        private CheckBox chkTorshy;
        private RadioButton rdpMeat;
        private RadioButton rdpChecken;
        private GroupBox groupBox2;
        private CheckBox chkTahina;
        private CheckBox chkTomia;
        private RadioButton rdpFish;
        private ListBox listDrinks;
        private CheckedListBox chkListDrinks;
    }
}
