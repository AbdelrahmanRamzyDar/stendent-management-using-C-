namespace Student_Management.Screens.employee
{
    partial class employeeinfoForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelToppanel = new System.Windows.Forms.Panel();
            this.TopPanelLabel = new System.Windows.Forms.Label();
            this.logopictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.TextBox();
            this.mobile = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.labelToppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.saveRecordToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // saveRecordToolStripMenuItem
            // 
            this.saveRecordToolStripMenuItem.Name = "saveRecordToolStripMenuItem";
            this.saveRecordToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.saveRecordToolStripMenuItem.Text = "&Save Record";
            this.saveRecordToolStripMenuItem.Click += new System.EventHandler(this.saveRecordToolStripMenuItem_Click);
            // 
            // labelToppanel
            // 
            this.labelToppanel.BackColor = System.Drawing.Color.DarkCyan;
            this.labelToppanel.Controls.Add(this.TopPanelLabel);
            this.labelToppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelToppanel.Location = new System.Drawing.Point(0, 24);
            this.labelToppanel.Name = "labelToppanel";
            this.labelToppanel.Size = new System.Drawing.Size(652, 50);
            this.labelToppanel.TabIndex = 4;
            this.labelToppanel.Paint += new System.Windows.Forms.PaintEventHandler(this.labelToppanel_Paint_1);
            // 
            // TopPanelLabel
            // 
            this.TopPanelLabel.AutoSize = true;
            this.TopPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanelLabel.Location = new System.Drawing.Point(359, 9);
            this.TopPanelLabel.Name = "TopPanelLabel";
            this.TopPanelLabel.Size = new System.Drawing.Size(54, 29);
            this.TopPanelLabel.TabIndex = 0;
            this.TopPanelLabel.Text = "FCI";
            this.TopPanelLabel.Click += new System.EventHandler(this.TopPanelLabel_Click);
            // 
            // logopictureBox
            // 
            this.logopictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logopictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logopictureBox.Location = new System.Drawing.Point(22, 55);
            this.logopictureBox.Name = "logopictureBox";
            this.logopictureBox.Size = new System.Drawing.Size(210, 210);
            this.logopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logopictureBox.TabIndex = 5;
            this.logopictureBox.TabStop = false;
            this.logopictureBox.Click += new System.EventHandler(this.logopictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Full Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Telephone  :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Email Address   :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Date Of Birth :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Depart Id :";
            // 
            // fullname
            // 
            this.fullname.Location = new System.Drawing.Point(390, 103);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(214, 20);
            this.fullname.TabIndex = 26;
            this.fullname.TextChanged += new System.EventHandler(this.fullname_TextChanged);
            // 
            // mobile
            // 
            this.mobile.Location = new System.Drawing.Point(390, 212);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(147, 20);
            this.mobile.TabIndex = 28;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(390, 178);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(219, 20);
            this.email.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(390, 133);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(390, 248);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // employeeinfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 394);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.logopictureBox);
            this.Controls.Add(this.labelToppanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "employeeinfoForm";
            this.Text = "employeeinfoForm";
            this.Load += new System.EventHandler(this.employeeinfoForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.labelToppanel.ResumeLayout(false);
            this.labelToppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRecordToolStripMenuItem;
        private System.Windows.Forms.Panel labelToppanel;
        private System.Windows.Forms.Label TopPanelLabel;
        private System.Windows.Forms.PictureBox logopictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}