namespace Lect5_Timer
{
    partial class frmTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            rchMessage = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            changeColorToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            boldToolStripMenuItem = new ToolStripMenuItem();
            italicToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // rchMessage
            // 
            rchMessage.ContextMenuStrip = contextMenuStrip1;
            rchMessage.Font = new Font("Segoe UI", 15F);
            rchMessage.Location = new Point(12, 52);
            rchMessage.Name = "rchMessage";
            rchMessage.Size = new Size(776, 386);
            rchMessage.TabIndex = 0;
            rchMessage.Text = "";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { changeColorToolStripMenuItem, boldToolStripMenuItem, italicToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(148, 70);
            // 
            // changeColorToolStripMenuItem
            // 
            changeColorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { redToolStripMenuItem, greenToolStripMenuItem });
            changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            changeColorToolStripMenuItem.Size = new Size(147, 22);
            changeColorToolStripMenuItem.Text = "Change Color";
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(180, 22);
            redToolStripMenuItem.Text = "Red";
            redToolStripMenuItem.Click += redToolStripMenuItem_Click;
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(180, 22);
            greenToolStripMenuItem.Text = "Green";
            greenToolStripMenuItem.Click += greenToolStripMenuItem_Click;
            // 
            // boldToolStripMenuItem
            // 
            boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            boldToolStripMenuItem.Size = new Size(147, 22);
            boldToolStripMenuItem.Text = "Bold";
            // 
            // italicToolStripMenuItem
            // 
            italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            italicToolStripMenuItem.Size = new Size(147, 22);
            italicToolStripMenuItem.Text = "Italic";
            // 
            // frmTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rchMessage);
            Name = "frmTest";
            Text = "frmTest";
            Load += frmTest_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rchMessage;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem changeColorToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem boldToolStripMenuItem;
        private ToolStripMenuItem italicToolStripMenuItem;
    }
}