namespace Launcher
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.btn_girisYap = new Guna.UI2.WinForms.Guna2Button();
            this.user_textBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.RememberButton = new Guna.UI2.WinForms.Guna2CheckBox();
            this.uyari = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_girisYap
            // 
            this.btn_girisYap.Animated = true;
            this.btn_girisYap.BorderRadius = 10;
            this.btn_girisYap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_girisYap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_girisYap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_girisYap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_girisYap.FillColor = System.Drawing.Color.Black;
            this.btn_girisYap.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.btn_girisYap.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn_girisYap.Location = new System.Drawing.Point(153, 432);
            this.btn_girisYap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_girisYap.Name = "btn_girisYap";
            this.btn_girisYap.Size = new System.Drawing.Size(204, 47);
            this.btn_girisYap.TabIndex = 0;
            this.btn_girisYap.Text = "GİRİŞ YAP";
            this.btn_girisYap.Click += new System.EventHandler(this.btn_girisYap_Click);
            // 
            // user_textBox
            // 
            this.user_textBox.BorderColor = System.Drawing.Color.Black;
            this.user_textBox.BorderRadius = 10;
            this.user_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_textBox.DefaultText = "";
            this.user_textBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.user_textBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.user_textBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.user_textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.user_textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.user_textBox.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.user_textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.user_textBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("user_textBox.IconLeft")));
            this.user_textBox.IconLeftSize = new System.Drawing.Size(15, 15);
            this.user_textBox.Location = new System.Drawing.Point(83, 309);
            this.user_textBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.user_textBox.Name = "user_textBox";
            this.user_textBox.PasswordChar = '\0';
            this.user_textBox.PlaceholderText = "Kullanıcı Adı";
            this.user_textBox.SelectedText = "";
            this.user_textBox.Size = new System.Drawing.Size(348, 73);
            this.user_textBox.TabIndex = 1;
            this.user_textBox.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // RememberButton
            // 
            this.RememberButton.Animated = true;
            this.RememberButton.AutoSize = true;
            this.RememberButton.BackColor = System.Drawing.Color.White;
            this.RememberButton.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.RememberButton.CheckedState.BorderRadius = 0;
            this.RememberButton.CheckedState.BorderThickness = 0;
            this.RememberButton.CheckedState.FillColor = System.Drawing.Color.Black;
            this.RememberButton.CheckMarkColor = System.Drawing.Color.DarkMagenta;
            this.RememberButton.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.RememberButton.ForeColor = System.Drawing.Color.Black;
            this.RememberButton.Location = new System.Drawing.Point(83, 406);
            this.RememberButton.Name = "RememberButton";
            this.RememberButton.Size = new System.Drawing.Size(137, 19);
            this.RememberButton.TabIndex = 3;
            this.RememberButton.Text = "Beni Hatırla";
            this.RememberButton.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.RememberButton.UncheckedState.BorderRadius = 0;
            this.RememberButton.UncheckedState.BorderThickness = 0;
            this.RememberButton.UncheckedState.FillColor = System.Drawing.Color.White;
            this.RememberButton.UseVisualStyleBackColor = false;
            this.RememberButton.CheckedChanged += new System.EventHandler(this.guna2CheckBox2_CheckedChanged);
            // 
            // uyari
            // 
            this.uyari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uyari.AutoSize = false;
            this.uyari.BackColor = System.Drawing.Color.Transparent;
            this.uyari.Enabled = false;
            this.uyari.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyari.ForeColor = System.Drawing.Color.DarkMagenta;
            this.uyari.Location = new System.Drawing.Point(68, 262);
            this.uyari.Name = "uyari";
            this.uyari.Size = new System.Drawing.Size(388, 42);
            this.uyari.TabIndex = 4;
            this.uyari.Text = "Lütfen geçerli bir kullanıcı adı giriniz!";
            this.uyari.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uyari.Visible = false;
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(501, -1);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(1112, 836);
            this.PictureBox.TabIndex = 5;
            this.PictureBox.TabStop = false;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1625, 833);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.uyari);
            this.Controls.Add(this.RememberButton);
            this.Controls.Add(this.user_textBox);
            this.Controls.Add(this.btn_girisYap);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_girisYap;
        private Guna.UI2.WinForms.Guna2TextBox user_textBox;
        private Guna.UI2.WinForms.Guna2CheckBox RememberButton;
        public Guna.UI2.WinForms.Guna2HtmlLabel uyari;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}