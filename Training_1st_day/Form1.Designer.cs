namespace Training_1st_day
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmdShow = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Tag = "";
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Tag = "";
            this.label2.Text = "Last Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(340, 20);
            this.textBox2.TabIndex = 2;
            // 
            // cmdShow
            // 
            this.cmdShow.Location = new System.Drawing.Point(371, 140);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(75, 23);
            this.cmdShow.TabIndex = 4;
            this.cmdShow.Text = "Show Name";
            this.cmdShow.UseVisualStyleBackColor = true;
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            this.cmdShow.MouseHover += new System.EventHandler(this.cmdShow_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(490, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "File";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1ToolStripMenuItem,
            this.menu2ToolStripMenuItem});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(37, 20);
            this.tsmFile.Text = "File";
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(37, 20);
            this.tsmExit.Text = "Exit";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // menu1ToolStripMenuItem
            // 
            this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.menu1ToolStripMenuItem.Text = "Menu 1";
            // 
            // menu2ToolStripMenuItem
            // 
            this.menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            this.menu2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.menu2ToolStripMenuItem.Text = "Menu 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 187);
            this.Controls.Add(this.cmdShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button cmdShow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem menu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu2ToolStripMenuItem;
    }
}

