namespace Global_Lagswitch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusLabel = new System.Windows.Forms.Label();
            this.processListBox = new System.Windows.Forms.ComboBox();
            this.lsoffButton = new System.Windows.Forms.Button();
            this.lsonButton = new System.Windows.Forms.Button();
            this.hotkeyInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(12, 43);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(126, 15);
            this.statusLabel.TabIndex = 70;
            this.statusLabel.Text = "Status: Disabled!";
            // 
            // processListBox
            // 
            this.processListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.processListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processListBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processListBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processListBox.ForeColor = System.Drawing.Color.White;
            this.processListBox.FormattingEnabled = true;
            this.processListBox.Location = new System.Drawing.Point(12, 12);
            this.processListBox.Name = "processListBox";
            this.processListBox.Size = new System.Drawing.Size(271, 27);
            this.processListBox.TabIndex = 69;
            this.processListBox.Click += new System.EventHandler(this.processListBox_Click);
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
            this.lsoffButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsoffButton.ForeColor = System.Drawing.Color.White;
            this.lsoffButton.Location = new System.Drawing.Point(152, 64);
            this.lsoffButton.Name = "lsoffButton";
            this.lsoffButton.Size = new System.Drawing.Size(133, 30);
            this.lsoffButton.TabIndex = 68;
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
            this.lsonButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsonButton.ForeColor = System.Drawing.Color.White;
            this.lsonButton.Location = new System.Drawing.Point(13, 64);
            this.lsonButton.Name = "lsonButton";
            this.lsonButton.Size = new System.Drawing.Size(133, 30);
            this.lsonButton.TabIndex = 67;
            this.lsonButton.Text = "On";
            this.lsonButton.UseVisualStyleBackColor = false;
            this.lsonButton.Click += new System.EventHandler(this.lsonButton_Click);
            // 
            // hotkeyInfo
            // 
            this.hotkeyInfo.AutoSize = true;
            this.hotkeyInfo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotkeyInfo.ForeColor = System.Drawing.Color.White;
            this.hotkeyInfo.Location = new System.Drawing.Point(12, 97);
            this.hotkeyInfo.Name = "hotkeyInfo";
            this.hotkeyInfo.Size = new System.Drawing.Size(175, 15);
            this.hotkeyInfo.TabIndex = 71;
            this.hotkeyInfo.Text = "Toggle hotkey: Shift + F";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(296, 122);
            this.Controls.Add(this.hotkeyInfo);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.processListBox);
            this.Controls.Add(this.lsoffButton);
            this.Controls.Add(this.lsonButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Global Lagswitch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox processListBox;
        private System.Windows.Forms.Button lsoffButton;
        private System.Windows.Forms.Button lsonButton;
        private System.Windows.Forms.Label hotkeyInfo;
    }
}

