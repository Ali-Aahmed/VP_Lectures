namespace Lect2_Buttons
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
            btnTest = new Button();
            btnTest1 = new Button();
            btnTest2 = new Button();
            label1 = new Label();
            label2 = new Label();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // btnTest
            // 
            btnTest.BackColor = Color.Teal;
            btnTest.FlatAppearance.BorderColor = Color.Red;
            btnTest.FlatAppearance.BorderSize = 3;
            btnTest.FlatStyle = FlatStyle.Flat;
            btnTest.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTest.Location = new Point(237, 471);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(228, 92);
            btnTest.TabIndex = 0;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = false;
            btnTest.Click += btnTest_Click;
            // 
            // btnTest1
            // 
            btnTest1.BackColor = Color.RosyBrown;
            btnTest1.FlatAppearance.BorderColor = Color.Red;
            btnTest1.FlatAppearance.BorderSize = 3;
            btnTest1.FlatStyle = FlatStyle.Flat;
            btnTest1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTest1.Location = new Point(98, 357);
            btnTest1.Name = "btnTest1";
            btnTest1.Size = new Size(228, 92);
            btnTest1.TabIndex = 1;
            btnTest1.Text = "Test 1";
            btnTest1.UseVisualStyleBackColor = false;
            btnTest1.Click += btnTest1_Click;
            // 
            // btnTest2
            // 
            btnTest2.BackColor = Color.RosyBrown;
            btnTest2.FlatAppearance.BorderColor = Color.Red;
            btnTest2.FlatAppearance.BorderSize = 3;
            btnTest2.FlatStyle = FlatStyle.Flat;
            btnTest2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTest2.Location = new Point(377, 357);
            btnTest2.Name = "btnTest2";
            btnTest2.Size = new Size(232, 92);
            btnTest2.TabIndex = 2;
            btnTest2.Text = "Test 2";
            btnTest2.UseVisualStyleBackColor = false;
            btnTest2.Click += btnTest2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(76, 96);
            label1.Name = "label1";
            label1.Size = new Size(209, 54);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F);
            label2.Location = new Point(88, 179);
            label2.Name = "label2";
            label2.Size = new Size(197, 54);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.FromArgb(255, 224, 192);
            lblMessage.BorderStyle = BorderStyle.Fixed3D;
            lblMessage.Dock = DockStyle.Top;
            lblMessage.Font = new Font("Segoe UI", 30F);
            lblMessage.ForeColor = Color.Navy;
            lblMessage.Location = new Point(0, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(750, 66);
            lblMessage.TabIndex = 5;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 578);
            Controls.Add(lblMessage);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTest2);
            Controls.Add(btnTest1);
            Controls.Add(btnTest);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseHover += Form1_MouseHover;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTest;
        private Button btnTest1;
        private Button btnTest2;
        private Label label1;
        private Label label2;
        private Label lblMessage;
    }
}
