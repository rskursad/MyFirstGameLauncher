using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CmlLib.Core;
using CmlLib.Core.Auth;
using static System.Collections.Specialized.BitVector32;
using System.Threading;

namespace Launcher
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            LoginScreen loginScreen = (LoginScreen)Application.OpenForms["LoginScreen"];
        }

        public static string version;

        MSession mSession;

        private void path()
        {

            var path = new MinecraftPath();

            var launcher = new CMLauncher(path);

            launcher.FileChanged += (e) =>
            {
                listBox1.Items.Add((string.Format("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount)));
            };
            launcher.ProgressChanged += (s, e) =>
            {
                //Console.WriteLine("{0}%", e.ProgressPercentage);
            };


            foreach (var item in launcher.GetAllVersions())
            {
                // show all version names
                // use this version name in CreateProcessAsync method.
                version_Combobox.Items.Add(item.Name);
            }


        }

        private void launch()
        {
            var path = new MinecraftPath();

            var launcher = new CMLauncher(path);

            launcher.FileChanged += (e) =>
            {
                listBox1.Items.Add((string.Format("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount)));
            };
            var launchOption = new MLaunchOption
            {
                MaximumRamMb = 1024,
                Session = MSession.GetOfflineSession("OOO Kimleri görüyorum " + LoginScreen.user + " gelmiş :D"),
                ServerIp = "5.252.74.192",
            };

            version = version_Combobox.SelectedItem.ToString();
            var process = launcher.CreateProcess(version, launchOption);

            process.Start();
            Hide();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            pic();
            path();
            UserMessage.Text = "Hoşgeldiniz Sayın" + " " + LoginScreen.user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            geri();

        }
        private void geri()
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            PlayButton.Enabled = false;
            Thread thread = new Thread(() => launch());
            thread.IsBackground = true;
            thread.Start();
        }

        private void versionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void pic()
        {
            pictureBox1.Image = Properties.Resources.mcpe;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
