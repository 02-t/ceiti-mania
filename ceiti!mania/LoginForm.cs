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
using System.IO;

namespace ceiti_mania
{
    public partial class LoginForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        int key = 1;
        string database_id = "192.108.64.103";

        public LoginForm()
        {
            InitializeComponent();
        }

        static string Encrypt(string textToEncrypt)
        {
            try
            {
                string ToReturn = "";
                string publickey = "12345678";
                string secretkey = "87654321";
                byte[] secretkeyByte = { };
                secretkeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);
                byte[] publickeybyte = { };
                publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(textToEncrypt);
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    ToReturn = Convert.ToBase64String(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        private void playSound(int x)
        {
            if (File.Exists("sunet_off.setting")) return;
            var p1 = new System.Windows.Media.MediaPlayer();
            string s_ = Directory.GetCurrentDirectory();
            string s = Path.GetFullPath(Path.Combine(s_, @"..\..\..\"));

            switch (x)
            {
                case 1:
                    p1.Open(new System.Uri(s + @"\audio\play.wav"));
                    break;
                case 2:
                    p1.Open(new System.Uri(s + @"\audio\clicked.wav"));
                    break;
                case 3:
                    switch(key)
                    {
                        case 1:
                            p1.Open(new System.Uri(s + @"\audio\key_tap1.wav"));
                            break;
                        case 2:
                            p1.Open(new System.Uri(s + @"\audio\key_tap2.wav"));
                            break;
                        case 3:
                            p1.Open(new System.Uri(s + @"\audio\key_tap3.wav"));
                            break;
                        case 4:
                            p1.Open(new System.Uri(s + @"\audio\key_tap4.wav"));
                            break;
                    }
                    break;
                default:
                    p1.Open(new System.Uri(s + @"\audio\hover.wav"));
                    break;
            }
            p1.Play();
        }

        private void drag_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void drag_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void drag_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void closeForm(object sender, EventArgs e)
        {
            if (File.Exists("is_logging.in"))
                File.Delete("is_logging.in");
            playSound(2);
            this.Close();
        }

        private void close_button_MouseEnter(object sender, EventArgs e)
        {
            playSound(0);
            close_button.ImageLocation = @"..\..\..\images\x_dark.png";
        }

        private void close_button_MouseLeave(object sender, EventArgs e)
        {
            close_button.ImageLocation = @"..\..\..\images\x.png";
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            playSound(0);
            if (sender.ToString().Split(',')[0] == "System.Windows.Forms.Button")
                return;
            PictureBox btn = sender as PictureBox;
            var color = btn.BackColor;
            var R = color.R + 35; var G = color.G + 35; var B = color.B + 35;
            if (R > 255) R = R - 70;
            if (B > 255) B = B - 70;
            if (G > 255) G = G - 70;

            btn.BackColor = System.Drawing.Color.FromArgb(R, G, B);
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            if (sender.ToString().Split(',')[0] == "System.Windows.Forms.Button" || sender.ToString().Split(',')[0] == "System.Windows.Forms.TextBox")
                return;
            PictureBox btn = sender as PictureBox;
            btn.BackColor = btn.Parent.BackColor;
        }

        private void go_Click(object sender, EventArgs e)
        {
            bool merge = false;
            string username = user_box.Text;
            string pass = pass_box.Text;
            playSound(2);

            if (Directory.Exists(database_id))
                if (File.Exists(database_id + @"\" + username))
                    if (Encrypt(pass) == File.ReadAllText(database_id + @"\" + username))
                        merge = true;

            if (merge)
            {
                File.WriteAllText("username.in", username);

                if (File.Exists(@"admins\" + username))
                    File.Create("is.admin").Close();
                if (remember_acc.Checked)
                    File.WriteAllText("last_login.u", username);
                if (File.Exists("is_logging.in"))
                    File.Delete("is_logging.in");
                this.Close();
            }
            else
                MessageBox.Show("Numele/Parola greșită!", "Eroare!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void key_sound(object sender, EventArgs e)
        {
            playSound(3);
        }

        private void logare_picture_Click(object sender, EventArgs e)
        {
            login_panel.Visible = false;
            new_user_panel.Visible = true;
            playSound(2);
        }

        private void show_pass_CheckedChanged(object sender, EventArgs e)
        {
            playSound(2);
            if (show_pass.Checked)
                pass_box.UseSystemPasswordChar = false;
            else
                pass_box.UseSystemPasswordChar = true;
        }

        private void remember_acc_CheckedChanged(object sender, EventArgs e)
        {
            playSound(2);
        }

        private void new_user_button_Click(object sender, EventArgs e)
        {
            login_panel.Visible = true;
            new_user_panel.Visible = false;
            playSound(2);
        }

        private void go_new_account_Click(object sender, EventArgs e)
        {
            playSound(2);
            string username = username_box2.Text;
            string pass = pass_box2.Text;

            if (pass_box2.Text != pass_box3.Text)
            {
                MessageBox.Show("Parolele nu se aseamănă!", "Eroare!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pass.Length < 8)
            {
                MessageBox.Show("Parola trebuie să fie de minim 8 caractere!", "Eroare!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (username.Length < 3)
            {
                MessageBox.Show("Numele trebuie să fie de minim 3 caractere!", "Eroare!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (File.Exists(database_id + @"\" + username))
            {
                MessageBox.Show("Acest nume este luat! Alege altul!", "Eroare!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(database_id))
                Directory.CreateDirectory(database_id);

            File.WriteAllText(database_id + @"\" + username, Encrypt(pass));
            File.WriteAllText("username.in", username);
            if (remember2.Checked)
                File.WriteAllText("last_login.u", username);
            if (File.Exists("is_logging.in"))
                File.Delete("is_logging.in");
            this.Close();
        }

        private void show_pass2_CheckedChanged(object sender, EventArgs e)
        {
            playSound(2);
            if (show_pass2.Checked)
            {
                pass_box2.UseSystemPasswordChar = false;
                pass_box3.UseSystemPasswordChar = false;
            }
            else
            {
                pass_box2.UseSystemPasswordChar = true;
                pass_box3.UseSystemPasswordChar = true;
            }
        }

        private void remember2_CheckedChanged(object sender, EventArgs e)
        {
            playSound(2);
        }
    }
}
