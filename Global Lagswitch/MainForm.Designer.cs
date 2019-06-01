namespace GlobalLagswitch
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.lsoffButton = new System.Windows.Forms.Button();
            this.lsonButton = new System.Windows.Forms.Button();
            this.processListBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Source Sans Pro ExtraLight", 14F);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.MaximumSize = new System.Drawing.Size(300, 25);
            this.titleLabel.MinimumSize = new System.Drawing.Size(300, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(300, 25);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Global Lagswitch";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseMove);
            this.titleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseUp);
            // 
            // minimizeButton
            // 
            this.minimizeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.minimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minimizeButton.Location = new System.Drawing.Point(240, 0);
            this.minimizeButton.MaximumSize = new System.Drawing.Size(25, 25);
            this.minimizeButton.MinimumSize = new System.Drawing.Size(25, 25);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.TabIndex = 7;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(275, 0);
            this.closeButton.MaximumSize = new System.Drawing.Size(25, 25);
            this.closeButton.MinimumSize = new System.Drawing.Size(25, 25);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 6;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // lsoffButton
            // 
            this.lsoffButton.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.lsoffButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.lsoffButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lsoffButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lsoffButton.FlatAppearance.BorderSize = 0;
            this.lsoffButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lsoffButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.lsoffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lsoffButton.Font = new System.Drawing.Font("Source Sans Pro Light", 12F);
            this.lsoffButton.ForeColor = System.Drawing.Color.White;
            this.lsoffButton.Location = new System.Drawing.Point(152, 83);
            this.lsoffButton.Name = "lsoffButton";
            this.lsoffButton.Size = new System.Drawing.Size(133, 30);
            this.lsoffButton.TabIndex = 64;
            this.lsoffButton.Text = "Off";
            this.lsoffButton.UseVisualStyleBackColor = false;
            this.lsoffButton.Click += new System.EventHandler(this.lsoffButton_Click);
            // 
            // lsonButton
            // 
            this.lsonButton.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.lsonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.lsonButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lsonButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lsonButton.FlatAppearance.BorderSize = 0;
            this.lsonButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lsonButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.lsonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lsonButton.Font = new System.Drawing.Font("Source Sans Pro Light", 12F);
            this.lsonButton.ForeColor = System.Drawing.Color.White;
            this.lsonButton.Location = new System.Drawing.Point(13, 83);
            this.lsonButton.Name = "lsonButton";
            this.lsonButton.Size = new System.Drawing.Size(133, 30);
            this.lsonButton.TabIndex = 63;
            this.lsonButton.Text = "On";
            this.lsonButton.UseVisualStyleBackColor = false;
            this.lsonButton.Click += new System.EventHandler(this.lsonButton_Click);
            // 
            // processListBox
            // 
            this.processListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.processListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processListBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processListBox.Font = new System.Drawing.Font("Source Sans Pro Light", 12F);
            this.processListBox.ForeColor = System.Drawing.Color.White;
            this.processListBox.FormattingEnabled = true;
            this.processListBox.Location = new System.Drawing.Point(12, 31);
            this.processListBox.Name = "processListBox";
            this.processListBox.Size = new System.Drawing.Size(271, 28);
            this.processListBox.TabIndex = 65;
            this.processListBox.Click += new System.EventHandler(this.processListBox_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Source Sans Pro Light", 10F);
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(12, 62);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(103, 18);
            this.statusLabel.TabIndex = 66;
            this.statusLabel.Text = "Status: Disabled!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(300, 125);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.processListBox);
            this.Controls.Add(this.lsoffButton);
            this.Controls.Add(this.lsonButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button lsoffButton;
        private System.Windows.Forms.Button lsonButton;
        private System.Windows.Forms.ComboBox processListBox;
        private System.Windows.Forms.Label statusLabel;
    }
}