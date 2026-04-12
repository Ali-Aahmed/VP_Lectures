namespace Lec6_MenuStrip
{
    partial class FrmControls
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            cmbDepartments = new ComboBox();
            button1 = new Button();
            txtDepart = new TextBox();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000; 
            // 
            // cmbDepartments
            // 
            cmbDepartments.AutoCompleteCustomSource.AddRange(new string[] { "علوم الحاسب", "كيمياء", "فيزياء", "رياضيات", "صيدلة", "هندسة" });
            cmbDepartments.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbDepartments.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbDepartments.FormattingEnabled = true;
            cmbDepartments.Items.AddRange(new object[] { "علوم الحاسب", "كيمياء", "فيزياء", "رياضيات" });
            cmbDepartments.Location = new Point(318, 164);
            cmbDepartments.Name = "cmbDepartments";
            cmbDepartments.RightToLeft = RightToLeft.Yes;
            cmbDepartments.Size = new Size(304, 31);
            cmbDepartments.TabIndex = 3;
            cmbDepartments.SelectedIndexChanged += cmbDepartments_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(186, 80);
            button1.Name = "button1";
            button1.Size = new Size(95, 52);
            button1.TabIndex = 4;
            button1.Text = "Add";
            toolTip1.SetToolTip(button1, "Enter Add to add items in Comobox");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtDepart
            // 
            txtDepart.Location = new Point(318, 92);
            txtDepart.Name = "txtDepart";
            txtDepart.RightToLeft = RightToLeft.Yes;
            txtDepart.Size = new Size(304, 31);
            txtDepart.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(73, 80);
            button2.Name = "button2";
            button2.Size = new Size(95, 52);
            button2.TabIndex = 6;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(204, 279);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(482, 37);
            progressBar1.TabIndex = 7;
            progressBar1.Value = 50;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "معلومات";
            // 
            // FrmControls
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 471);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(txtDepart);
            Controls.Add(button1);
            Controls.Add(cmbDepartments);
            Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmControls";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private ComboBox cmbDepartments;
        private Button button1;
        private TextBox txtDepart;
        private Button button2;
        private ProgressBar progressBar1;
        private ToolTip toolTip1;
    }
}
