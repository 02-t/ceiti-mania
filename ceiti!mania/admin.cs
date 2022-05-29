using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace ceiti_mania
{
    public partial class admin : Form
    {
        string path = @"192.108.64.103";
        string path2 = @"admins";
        string path3 = @"bans";
        string path4 = @"..\..\..\songs";
        string path5;
        SoundPlayer audio;

        private void playSound(int x)
        {
            if (File.Exists("sunet_off.setting")) return;
            var p1 = new System.Windows.Media.MediaPlayer();
            string s_ = Directory.GetCurrentDirectory();
            string s = Path.GetFullPath(Path.Combine(s_, @"..\..\..\"));

            switch (x)
            {
                case 1:
                    p1.Open(new System.Uri(s + @"\audio\clicked.wav"));
                    break;
                case 2:
                    p1.Open(new System.Uri(s + @"\audio\play.wav"));
                    break;
                default:
                    p1.Open(new System.Uri(s + @"\audio\hover.wav"));
                    break;
            }
            p1.Play();
        }

        public admin()
        {
            InitializeComponent();
        }
        private void button_MouseEnter(object sender, EventArgs e)
        {
            playSound(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playSound(1);
            utilizatoriPanel.Visible = true;
            melodiiPanel.Visible = false;
            scor_panel.Visible = false;
            var files = Directory.EnumerateFiles(path).OrderByDescending(filename => filename);
            comboBox1.Items.Clear();
            foreach (var file in files)
            {
                comboBox1.Items.Add(Path.GetFileName(file));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playSound(1);
            melodiiPanel.Visible = true;
            utilizatoriPanel.Visible = false;
            scor_panel.Visible = false;
            var files = Directory.EnumerateDirectories(path4).OrderByDescending(filename => filename);
            cong_select.Items.Clear();
            foreach (var file in files)
            {
                cong_select.Items.Add(Path.GetFileName(file));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playSound(1);
            melodiiPanel.Visible = false;
            utilizatoriPanel.Visible = false;
            scor_panel.Visible = true;
            var files = Directory.EnumerateDirectories(path4).OrderByDescending(filename => filename);
            song_select2.Items.Clear();
            comboBox2.Items.Clear();
            foreach (var file in files)
            {
                song_select2.Items.Add(Path.GetFileName(file));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = File.ReadAllText(path + @"\" + comboBox1.Text);
            checkBox1.Checked = false;
            if (File.Exists(path2 + @"\" + comboBox1.Text))
                checkBox1.Checked = true;
            if (File.Exists(path3 + @"\" + comboBox1.Text))
                checkBox2.Checked = true;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            playSound(1);
        }

        private void save_Click(object sender, EventArgs e)
        {
            playSound(2);
            if (checkBox1.Checked)
                File.Create(path2 + @"\" + comboBox1.Text).Close();
            else
                if (File.Exists(path2 + @"\" + comboBox1.Text))
                    File.Delete(path2 + @"\" + comboBox1.Text);

            if (checkBox2.Checked)
                File.Create(path3 + @"\" + comboBox1.Text).Close();
            else
                if (File.Exists(path3 + @"\" + comboBox1.Text))
                File.Delete(path3 + @"\" + comboBox1.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            playSound(1);
            if (audio != null)
                audio.Stop();
        }

        private void listen_Click(object sender, EventArgs e)
        {
            playSound(1);
            if (!File.Exists(path4 + @"\" + cong_select.Text + @"\audio.wav")) return;
            audio = new SoundPlayer(path4 + @"\" + cong_select.Text + @"\audio.wav");
            audio.Play();
        }

        private void cong_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            playSound(1);
            melodie_bg.ImageLocation = path4 + @"\" + cong_select.Text + @"\bg.jpg";
            if (File.Exists(path4 + @"\" + cong_select.Text + @"\ascunsa"))
                checkBox3.Checked = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            playSound(2);

            if (checkBox3.Checked)
                File.Create(path4 + @"\" + cong_select.Text + @"\ascunsa").Close();
            else
                if (File.Exists(path4 + @"\" + cong_select.Text + @"\ascunsa"))
                File.Delete(path4 + @"\" + cong_select.Text + @"\ascunsa");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            playSound(1);
        }

        private void DELETE_SCORE_Click(object sender, EventArgs e)
        {
            playSound(2);
            string x = comboBox2.Text;
            File.Delete(path5 + @"\" + x);
            var files = Directory.EnumerateFiles(path5).OrderByDescending(filename => filename);
            comboBox2.Items.Clear();
            foreach (var file in files)
            {
                comboBox2.Items.Add(Path.GetFileName(file));
            }

            label7.Text = "utilizator: -";
            label8.Text = "nota : -";
            label9.Text = "data: -";
        }

        private void song_select2_SelectedIndexChanged(object sender, EventArgs e) // melodie
        {
            pictureBox1.ImageLocation = path4 + @"\" + song_select2.Text + @"\bg.jpg";
            path5 = path4 + @"\" + song_select2.Text + @"\scores";
            var files = Directory.EnumerateFiles(path5).OrderByDescending(filename => filename);
            comboBox2.Items.Clear();
            foreach (var file in files)
            {
                comboBox2.Items.Add(Path.GetFileName(file));
            }
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            playSound(1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) // scor
        {
            string x = comboBox2.Text;
            string nota = Convert.ToString(Convert.ToDouble(x.Split('-')[1]) / 10);
            if (nota == "99.9") nota = "10";
            label7.Text = "utilizator: " + File.ReadAllText(path5 + @"\" + x);
            label8.Text = "nota : " + nota;
            label9.Text = "data: " + Convert.ToString(File.GetCreationTime(path5 + @"\" + x));
        }
    }
}
