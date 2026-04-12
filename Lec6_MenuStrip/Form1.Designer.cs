namespace Lec6_MenuStrip
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            pastToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            statusStripToolStripMenuItem = new ToolStripMenuItem();
            comToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            txtFile = new RichTextBox();
            statusStrip1 = new StatusStrip();
            lblWords = new ToolStripStatusLabel();
            lblChars = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            cmbDepartments = new ComboBox();
            button1 = new Button();
            txtDepart = new TextBox();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            toolTip1 = new ToolTip(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(838, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 25);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(118, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(118, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(118, 26);
            saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(118, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyToolStripMenuItem, cutToolStripMenuItem, pastToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(48, 25);
            editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(117, 26);
            copyToolStripMenuItem.Text = "copy";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(117, 26);
            cutToolStripMenuItem.Text = "cut";
            // 
            // pastToolStripMenuItem
            // 
            pastToolStripMenuItem.Name = "pastToolStripMenuItem";
            pastToolStripMenuItem.Size = new Size(117, 26);
            pastToolStripMenuItem.Text = "paste";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { statusStripToolStripMenuItem, comToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(56, 25);
            viewToolStripMenuItem.Text = "View";
            // 
            // statusStripToolStripMenuItem
            // 
            statusStripToolStripMenuItem.Name = "statusStripToolStripMenuItem";
            statusStripToolStripMenuItem.Size = new Size(158, 26);
            statusStripToolStripMenuItem.Text = "Status Strip";
            // 
            // comToolStripMenuItem
            // 
            comToolStripMenuItem.Name = "comToolStripMenuItem";
            comToolStripMenuItem.Size = new Size(158, 26);
            comToolStripMenuItem.Text = "ComoBox";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 25);
            aboutToolStripMenuItem.Text = "About";
            // 
            // txtFile
            // 
            txtFile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFile.Location = new Point(0, 37);
            txtFile.Margin = new Padding(4, 5, 4, 5);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(836, 130);
            txtFile.TabIndex = 1;
            txtFile.Text = "";
            toolTip1.SetToolTip(txtFile, "this textbox for any text");
            txtFile.TextChanged += txtFile_TextChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Font = new Font("Segoe UI", 12F);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblWords, lblChars, lblTime, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 445);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(838, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            toolTip1.SetToolTip(statusStrip1, "this Status Strip");
            // 
            // lblWords
            // 
            lblWords.Image = Lect6_MenuStrip.Properties.Resources.iconfinder_Customer_Male_Light_808301;
            lblWords.Name = "lblWords";
            lblWords.Size = new Size(16, 21);
            // 
            // lblChars
            // 
            lblChars.Name = "lblChars";
            lblChars.Size = new Size(0, 21);
            // 
            // lblTime
            // 
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(157, 21);
            lblTime.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.MarqueeAnimationSpeed = 300;
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(300, 20);
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // cmbDepartments
            // 
            cmbDepartments.AutoCompleteCustomSource.AddRange(new string[] { "علوم الحاسب", "كيمياء", "فيزياء", "رياضيات", "صيدلة", "هندسة" });
            cmbDepartments.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbDepartments.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbDepartments.FormattingEnabled = true;
            cmbDepartments.Items.AddRange(new object[] { "علوم الحاسب", "كيمياء", "فيزياء", "رياضيات" });
            cmbDepartments.Location = new Point(282, 266);
            cmbDepartments.Name = "cmbDepartments";
            cmbDepartments.RightToLeft = RightToLeft.Yes;
            cmbDepartments.Size = new Size(304, 31);
            cmbDepartments.TabIndex = 3;
            cmbDepartments.SelectedIndexChanged += cmbDepartments_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(150, 201);
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
            txtDepart.Location = new Point(282, 213);
            txtDepart.Name = "txtDepart";
            txtDepart.RightToLeft = RightToLeft.Yes;
            txtDepart.Size = new Size(304, 31);
            txtDepart.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(37, 201);
            button2.Name = "button2";
            button2.Size = new Size(95, 52);
            button2.TabIndex = 6;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(234, 366);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 471);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(txtDepart);
            Controls.Add(button1);
            Controls.Add(cmbDepartments);
            Controls.Add(statusStrip1);
            Controls.Add(txtFile);
            Controls.Add(menuStrip1);
            Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem pastToolStripMenuItem;
        private ToolStripMenuItem statusStripToolStripMenuItem;
        private ToolStripMenuItem comToolStripMenuItem;
        private RichTextBox txtFile;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblWords;
        private ToolStripStatusLabel lblChars;
        private ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ComboBox cmbDepartments;
        private Button button1;
        private TextBox txtDepart;
        private Button button2;
        private ProgressBar progressBar1;
        private ToolTip toolTip1;
    }
}
