using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib.Core;
using CmlLib.Core.Auth;

namespace Launcher
{
    public partial class Opening : Form
    {
        public Opening()
        {
            
            InitializeComponent();
        }
        public  int count = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (count == 0)
            {
                panel2.Width += 15;
                if (panel2.Width >= 500)
                {
                    timer1.Stop();
                    LoginScreen LoginScreen = new LoginScreen();
                    LoginScreen.Show();
                    Hide();
                    count = 1;
                }
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
