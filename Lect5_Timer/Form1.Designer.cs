namespace Lect5_Timer
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
            timer1 = new System.Windows.Forms.Timer(components);
            dtmDate = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // dtmDate
            // 
            dtmDate.CalendarFont = new Font("Segoe UI", 25F);
            dtmDate.CustomFormat = "dd/MM/yyyy  hh:mm:ss tt";
            dtmDate.Font = new Font("Segoe UI", 15F);
            dtmDate.Format = DateTimePickerFormat.Custom;
            dtmDate.Location = new Point(260, 28);
            dtmDate.Name = "dtmDate";
            dtmDate.Size = new Size(280, 34);
            dtmDate.TabIndex = 0;
            dtmDate.ValueChanged += dtmDate_ValueChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(414, 114);
            button1.Name = "button1";
            button1.Size = new Size(311, 101);
            button1.TabIndex = 1;
            button1.Text = "Stop Timer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(49, 114);
            button2.Name = "button2";
            button2.Size = new Size(311, 101);
            button2.TabIndex = 2;
            button2.Text = "Start Timer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtmDate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private DateTimePicker dtmDate;
        private Button button1;
        private Button button2;
    }
}
