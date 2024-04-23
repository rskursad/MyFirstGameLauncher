namespace Launcher
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.UserMessage = new System.Windows.Forms.Label();
            this.geriButton = new Guna.UI2.WinForms.Guna2Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PlayButton = new Guna.UI2.WinForms.Guna2Button();
            this.version_Combobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserMessage
            // 
            this.UserMessage.AutoSize = true;
            this.UserMessage.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserMessage.Location = new System.Drawing.Point(122, 611);
            this.UserMessage.Name = "UserMessage";
            this.UserMessage.Size = new System.Drawing.Size(248, 17);
            this.UserMessage.TabIndex = 0;
            this.UserMessage.Text = "Hoşgeldiniz sayın {user}";
            this.UserMessage.Click += new System.EventHandler(this.label1_Click);
            // 
            // geriButton
            // 
            this.geriButton.BorderRadius = 10;
            this.geriButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.geriButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.geriButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.geriButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.geriButton.FillColor = System.Drawing.Color.Black;
            this.geriButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriButton.ForeColor = System.Drawing.Color.White;
            this.geriButton.Location = new System.Drawing.Point(12, 778);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(54, 43);
            this.geriButton.TabIndex = 2;
            this.geriButton.Text = "<";
            this.geriButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(597, 778);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(944, 20);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // PlayButton
            // 
            this.PlayButton.BorderRadius = 15;
            this.PlayButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PlayButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PlayButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PlayButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PlayButton.FillColor = System.Drawing.Color.Black;
            this.PlayButton.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PlayButton.ForeColor = System.Drawing.Color.DarkMagenta;
            this.PlayButton.Location = new System.Drawing.Point(161, 374);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(180, 69);
            this.PlayButton.TabIndex = 4;
            this.PlayButton.Text = "Oyna";
            this.PlayButton.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // version_Combobox
            // 
            this.version_Combobox.BackColor = System.Drawing.Color.Transparent;
            this.version_Combobox.BorderRadius = 15;
            this.version_Combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.version_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.version_Combobox.FillColor = System.Drawing.Color.DarkMagenta;
            this.version_Combobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.version_Combobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.version_Combobox.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.version_Combobox.ForeColor = System.Drawing.Color.Black;
            this.version_Combobox.ItemHeight = 30;
            this.version_Combobox.Location = new System.Drawing.Point(161, 449);
            this.version_Combobox.Name = "version_Combobox";
            this.version_Combobox.Size = new System.Drawing.Size(180, 36);
            this.version_Combobox.TabIndex = 5;
            this.version_Combobox.SelectedIndexChanged += new System.EventHandler(this.versionCombo_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(518, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1107, 830);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1625, 833);
            this.Controls.Add(this.version_Combobox);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.UserMessage);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserMessage;
        private Guna.UI2.WinForms.Guna2Button geriButton;
        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI2.WinForms.Guna2Button PlayButton;
        private Guna.UI2.WinForms.Guna2ComboBox version_Combobox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}