
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib.Core;
using CmlLib.Core.Auth;

namespace Launcher
{
   
    
    public partial class LoginScreen : Form
    {
        
        Opening opening = (Opening)Application.OpenForms["Opening"];
        MainPage mainPage = new MainPage();
        private static string remember;
        public static string user;
        

        public LoginScreen()
        {
            InitializeComponent();
        }




        private void btn_girisYap_Click(object sender, EventArgs e)
        {


            opening.count = 1;

            if (opening.count == 1)
            {
                ControlUser_textbox();
                if (!string.IsNullOrEmpty(user_textBox.Text))
                {
                    user = user_textBox.Text;
                    remember = RememberButton.Checked ? user : "";
                    mainPage.Show();
                    Hide();
                }

            }
            opening.count++;
        }



        private void ControlUser_textbox()
        {
            if (string.IsNullOrEmpty(user_textBox.Text))
            {
                uyari.Visible = true;
            }
            else
            {
                uyari.Visible = false;
            }
        }


        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            pic();   
            user_textBox.Text = remember;
            if (string.IsNullOrEmpty(remember))
            {
                RememberButton.Checked = false;
            }
            else
            {
                RememberButton.Checked = true;
            }
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void uyari_Click(object sender, EventArgs e)
        {

        }
        private void pic()
        {
            PictureBox.Image = Properties.Resources.mcpe;
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
