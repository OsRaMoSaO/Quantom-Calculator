using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Zipperoni
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer soundBull = new SoundPlayer(Properties.Resources.bullets);
            
            SetStartup();

            Random rnd = new Random();
            progressBar.Value = 0;

            int num1;
            int num2;
            try
            {
                num1 = int.Parse(Num1Box.Text);
            }
            catch
            {
                System.Media.SystemSounds.Exclamation.Play();
                soundBull.Play();
                MessageBox.Show("Invalid number in field 1", "Error!");
                return;
            }

            try
            {
                num2 = int.Parse(Num2Box.Text);
            }
            catch
            {
                System.Media.SystemSounds.Exclamation.Play();
                soundBull.Play();
                MessageBox.Show("Invalid number in field 2", "Error!");
                return;
            }


            int result = num1 + num2;

            TextBox.Text = "Calcuating...";

            EnterButton.Enabled = false;
            Num1Box.Enabled = false;
            Num2Box.Enabled = false;

            SoundPlayer soundNick = new SoundPlayer(Properties.Resources.intro);
            SoundPlayer soundWin = new SoundPlayer(Properties.Resources.Usher);
            soundWin.Stop();
            soundNick.PlayLooping();

            for (int i = 0; i < 100; i++)
            {
                int time = rnd.Next(250, 1500);
                await Task.Delay(time);
                progressBar.Value = i;
                System.Media.SystemSounds.Beep.Play();
            }
            soundNick.Stop();
            soundWin.PlayLooping();


            progressBar.Value = 100;

            EnterButton.Enabled = true;
            Num1Box.Enabled = true;
            Num2Box.Enabled = true;

            TextBox.Text = result.ToString();
            System.Media.SystemSounds.Exclamation.Play();
            MessageBox.Show("Your answer is: " + result + "!");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void SetStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);


            rk.SetValue("Zipperoni", Application.ExecutablePath);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
