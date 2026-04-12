namespace Lect3_Textboxes
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
            txtEgp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDollar = new TextBox();
            SuspendLayout();
            // 
            // txtEgp
            // 
            txtEgp.BorderStyle = BorderStyle.FixedSingle;
            txtEgp.Font = new Font("Segoe UI", 25F);
            txtEgp.Location = new Point(166, 65);
            txtEgp.MaxLength = 10;
            txtEgp.Name = "txtEgp";
            txtEgp.Size = new Size(418, 52);
            txtEgp.TabIndex = 0;
            txtEgp.TextAlign = HorizontalAlignment.Center;
            txtEgp.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(605, 61);
            label1.Name = "label1";
            label1.Size = new Size(372, 54);
            label1.TabIndex = 3;
            label1.Text = "المبلغ بالجنيه المصري";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F);
            label2.Location = new Point(605, 161);
            label2.Name = "label2";
            label2.Size = new Size(245, 54);
            label2.TabIndex = 4;
            label2.Text = "المبلغ بالدولار";
            // 
            // txtDollar
            // 
            txtDollar.BorderStyle = BorderStyle.FixedSingle;
            txtDollar.Font = new Font("Segoe UI", 25F);
            txtDollar.Location = new Point(166, 166);
            txtDollar.MaxLength = 10;
            txtDollar.Name = "txtDollar";
            txtDollar.Size = new Size(418, 52);
            txtDollar.TabIndex = 5;
            txtDollar.TextAlign = HorizontalAlignment.Center;
            txtDollar.TextChanged += txtDollar_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 250, 254);
            ClientSize = new Size(975, 325);
            Controls.Add(txtDollar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEgp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEgp;
        private Label label1;
        private Label label2;
        private TextBox txtDollar;
    }
}
