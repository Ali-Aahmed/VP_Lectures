namespace Lect3_Textboxes
{
    partial class frmGPA
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
            groupBox1 = new GroupBox();
            txtScore2 = new TextBox();
            txtScore1 = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnCalc = new Button();
            btnClear = new Button();
            btnExit = new Button();
            groupBox2 = new GroupBox();
            lblResult = new Label();
            lblAvg = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 255);
            groupBox1.Controls.Add(txtScore2);
            groupBox1.Controls.Add(txtScore1);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            groupBox1.Location = new Point(452, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(527, 401);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "بيانات الطالب";
            // 
            // txtScore2
            // 
            txtScore2.Location = new Point(37, 197);
            txtScore2.Name = "txtScore2";
            txtScore2.Size = new Size(286, 46);
            txtScore2.TabIndex = 5;
            // 
            // txtScore1
            // 
            txtScore1.Location = new Point(37, 132);
            txtScore1.Name = "txtScore1";
            txtScore1.Size = new Size(286, 46);
            txtScore1.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(37, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(286, 46);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 197);
            label2.Name = "label2";
            label2.Size = new Size(111, 40);
            label2.TabIndex = 2;
            label2.Text = "برمجة 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 132);
            label3.Name = "label3";
            label3.Size = new Size(111, 40);
            label3.TabIndex = 1;
            label3.Text = "برمجة 1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(353, 76);
            label1.Name = "label1";
            label1.Size = new Size(158, 40);
            label1.TabIndex = 0;
            label1.Text = "اسم الطالب";
            // 
            // btnCalc
            // 
            btnCalc.Font = new Font("Segoe UI", 20F);
            btnCalc.Location = new Point(490, 448);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(124, 68);
            btnCalc.TabIndex = 2;
            btnCalc.Text = "حساب";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 20F);
            btnClear.Location = new Point(349, 448);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 68);
            btnClear.TabIndex = 3;
            btnClear.Text = "مسح";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 20F);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(12, 470);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(124, 68);
            btnExit.TabIndex = 4;
            btnExit.Text = "خروج";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 255, 192);
            groupBox2.Controls.Add(lblResult);
            groupBox2.Controls.Add(lblAvg);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            groupBox2.Location = new Point(29, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(417, 401);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "النتيجة";
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.FromArgb(192, 255, 192);
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Location = new Point(44, 237);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(342, 72);
            lblResult.TabIndex = 5;
            // 
            // lblAvg
            // 
            lblAvg.BorderStyle = BorderStyle.FixedSingle;
            lblAvg.Location = new Point(58, 109);
            lblAvg.Name = "lblAvg";
            lblAvg.Size = new Size(200, 50);
            lblAvg.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 110);
            label4.Name = "label4";
            label4.Size = new Size(124, 40);
            label4.TabIndex = 3;
            label4.Text = "المتوسط";
            // 
            // frmGPA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 250, 254);
            ClientSize = new Size(1008, 533);
            Controls.Add(groupBox2);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(groupBox1);
            Name = "frmGPA";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCalc;
        private Button btnClear;
        private Button btnExit;
        private GroupBox groupBox2;
        private TextBox txtScore2;
        private TextBox txtScore1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label lblResult;
        private Label lblAvg;
        private Label label4;
    }
}
