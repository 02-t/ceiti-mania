using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Windows.Input;
using System.IO;

namespace ceiti_mania
{
	public partial class MainForm : Form
	{
		LoginForm logare = new LoginForm();
		admin adminForm = new admin();
		bool is_admin = false;
		bool is_logging_in = false;
		string user;

		bool isMenuOpen = false;
		int tick = -70;
		int offset = 0;
		int stop_tick = 0;

		int circle1 = 0;
		int circle2 = 0;
		int circle3 = 0;
		int circle4 = 0;

		int count1 = 0;
		int count2 = 0;
		int count3 = 0;
		int count4 = 0;

		bool s_held = false;
		bool d_held = false;
		bool k_held = false;
		bool l_held = false;

		int combo = 0;
		int max_combo = 0;
		int actual_max_combo = 0;
		int miss_count = 0;

		string[] song1;
		string[] song2;
		string[] song3;
		string[] song4;

		SoundPlayer audio;
		PictureBox[] notes1 = new PictureBox[10];
		PictureBox[] notes2 = new PictureBox[10];
		PictureBox[] notes3 = new PictureBox[10];
		PictureBox[] notes4 = new PictureBox[10];

		public void resizeScreen()
		{
			int x = this.Width,
				y = this.Height;

			int logo_menu_sizeX = Convert.ToInt32(x / 2.65), logo_menu_sizeY = Convert.ToInt32(y / 1.5),
			 	logo_menu_posX = Convert.ToInt32(x / 3 - logo_menu_sizeX / 2),
				logo_menu_posY = Convert.ToInt32(y / 2 - logo_menu_sizeY / 2),
				menu_bar_sizeX = Convert.ToInt32(x / 3.25),
				button_sizeX = Convert.ToInt32(logo_menu_sizeX / 1.25),
				button_sizeY = Convert.ToInt32(logo_menu_sizeY / 3),
				button_posX = Convert.ToInt32(x / 3 + logo_menu_sizeX / 2),
				play_button_posY = Convert.ToInt32(logo_menu_posY),
				meniu_button_posY = Convert.ToInt32(logo_menu_posY + button_sizeY),
				exit_button_posY = Convert.ToInt32(logo_menu_posY + button_sizeY * 2),
				settings_sizeX = Convert.ToInt32(menu_bar_sizeX / 1.1),
				settings_size_Y = Convert.ToInt32(y * 0.115),
				settings_posX = Convert.ToInt32(menu_bar_sizeX / 2 - settings_sizeX / 2),
				settings_posY = Convert.ToInt32(settings_size_Y + y * 0.05),
				back_button_sizeX = Convert.ToInt32(x / 4),
				back_button_sizeY = Convert.ToInt32(y / 8),
				back_button_posY = Convert.ToInt32(y * 0.025),
				song_select_sizeY = Convert.ToInt32(y - back_button_sizeY + back_button_posY * 2),
				song_select_posY = Convert.ToInt32(back_button_sizeY + back_button_posY * 2),
				go_sizeX = Convert.ToInt32(x / 4.26),
				go_sizeY = Convert.ToInt32(y / 4.32),
				go_posX = Convert.ToInt32(x - go_sizeX),
				go_posY = Convert.ToInt32(y - go_sizeY),
				chart_bg1_sizeX = Convert.ToInt32(x / 2),
				chart_bg1_posX = Convert.ToInt32(x * .25),
				chart_sizeX = Convert.ToInt32(chart_bg1_sizeX / 4 - 3),
				circle_size = Convert.ToInt32(chart_sizeX / 2),
				chart_line_sizeX = Convert.ToInt32(chart_bg1_sizeX * 1.25),
				chart_line_posX = Convert.ToInt32(x / 2 - chart_line_sizeX / 2),
				chart_line_posY = Convert.ToInt32(y * .9),
				chart_key_posY = Convert.ToInt32(chart_line_posY - 50),
				felititari_img_sizeY = Convert.ToInt32(y * 0.3),
				end_combo_sizeY = Convert.ToInt32(y * 0.075),
				end_nota_sizeY = Convert.ToInt32(y * 0.125),
				end_nota_posY = Convert.ToInt32(felititari_img_sizeY + y * 0.05),
				end_combo_label_posY = Convert.ToInt32(end_nota_posY + end_nota_sizeY + y * 0.025),
				end_button_sizeX = Convert.ToInt32(x * 0.25),
				end_button_sizeY = Convert.ToInt32(y * 0.15),
				end_button_posX = Convert.ToInt32(x * 0.1),
				end_button_posY = Convert.ToInt32(y * 0.75),
				end_button_posX2 = Convert.ToInt32(x * 0.6);

			logo_menu.Size = new Size(logo_menu_sizeX, logo_menu_sizeY);
			logo_menu.Location = new Point(logo_menu_posX, logo_menu_posY);
			menu_bar.Size = new Size (menu_bar_sizeX, y);
			menu_bar.Location = new Point(0, 0);
			
			play_button.Size = new Size(button_sizeX, button_sizeY);
			play_button.Location = new Point(button_posX, play_button_posY);
			meniu_button.Size = new Size(button_sizeX, button_sizeY);
			meniu_button.Location = new Point(button_posX, meniu_button_posY);
			exit_button.Size = new Size(button_sizeX, button_sizeY);
			exit_button.Location = new Point(button_posX, exit_button_posY);
			
			fullscreen_off.Size = new Size(settings_sizeX, settings_size_Y);
			fullscreen_off.Location = new Point(settings_posX, settings_posY);
			fullscreen_on.Size = new Size(settings_sizeX, settings_size_Y);
			fullscreen_on.Location = new Point(settings_posX, settings_posY);
			muzica_off.Size = new Size(settings_sizeX, settings_size_Y);
			muzica_off.Location = new Point(settings_posX, settings_posY*2);
			muzica_on.Size = new Size(settings_sizeX, settings_size_Y);
			muzica_on.Location = new Point(settings_posX, settings_posY * 2);
			sunet_off.Size = new Size(settings_sizeX, settings_size_Y);
			sunet_off.Location = new Point(settings_posX, settings_posY * 3);
			sunet_on.Size = new Size(settings_sizeX, settings_size_Y);
			sunet_on.Location = new Point(settings_posX, settings_posY * 3);
			low_detail_off.Size = new Size(settings_sizeX, settings_size_Y);
			low_detail_off.Location = new Point(settings_posX, settings_posY * 4);
			low_detail_on.Size = new Size(settings_sizeX, settings_size_Y);
			low_detail_on.Location = new Point(settings_posX, settings_posY * 4);
			restart_label.Size = new Size(settings_sizeX, settings_size_Y);
			restart_label.Location = new Point(settings_posX, settings_posY * 5);

			back_button.Size = new Size (back_button_sizeX, back_button_sizeY);
			back_button.Location = new Point (0, back_button_posY);
			back_button2.Size = new Size(back_button_sizeX, back_button_sizeY);
			back_button2.Location = new Point(0, back_button_posY);
			Go.Size = new Size(go_sizeX, go_sizeY);
			Go.Location = new Point(go_posX, go_posY);

			felicitari_img.Size = new Size(x, felititari_img_sizeY); ////////------------
			felicitari_img.Location = new Point(0, 0);
			///
			end_nota.Size = new Size(x, end_nota_sizeY);
			end_nota.Location = new Point(0, end_nota_posY);
			end_nota.Font = new Font("Microsoft Sans Serif", end_nota_sizeY / 2);
			///
			end_combo_label.Size = new Size(x, end_combo_sizeY);
			end_combo_label.Location = new Point(0, end_combo_label_posY);
			end_combo_label.Font = new Font("Microsoft Sans Serif", end_combo_sizeY / 2);
			///
			end_max_combo_label.Size = new Size(x, end_combo_sizeY);
			end_max_combo_label.Location = new Point(0, end_combo_label_posY + end_combo_sizeY);
			end_max_combo_label.Font = new Font("Microsoft Sans Serif", end_combo_sizeY / 2);
			///
			end_miss_label.Size = new Size(x, end_combo_sizeY);
			end_miss_label.Location = new Point(0, end_combo_label_posY + (end_combo_sizeY * 2));
			end_miss_label.Font = new Font("Microsoft Sans Serif", end_combo_sizeY / 2);
			///
			back_button3.Size = new Size(end_button_sizeX, end_button_sizeY);
			back_button3.Location = new Point(end_button_posX, end_button_posY);
			retry_button.Size = new Size(end_button_sizeX, end_button_sizeY);
			retry_button.Location = new Point(end_button_posX2, end_button_posY);

			MainPanel.Size = new Size(x, y);
			MainPanel.Location = new Point (0, 0);
			MenuPanel.Size = new Size (menu_bar_sizeX, y);
			MenuPanel.Location = new Point (0, 0);
			PlayPanel.Size = new Size (x, y);
			PlayPanel.Location = new Point (0, 0);
			songSelect1.Size = new Size(x, song_select_sizeY);
			songSelect1.Location = new Point (0, song_select_posY);
			GameplayPanel.Size = new Size(x, y);
			GameplayPanel.Location = new Point(0, 0);
			EndPanel.Size = new Size(x, y);
			EndPanel.Location = new Point(0, 0);

			chart_bg1.Size = new Size(chart_bg1_sizeX-3, y);
			chart_bg1.Location = new Point(chart_bg1_posX, 0);
			chart1.Size = new Size(chart_sizeX, y);
			chart1.Location = new Point(chart_bg1_posX, 0);
			chart2.Size = new Size(chart_sizeX, y);
			chart2.Location = new Point(chart_bg1_posX + chart_sizeX + 3, 0);
			chart3.Size = new Size(chart_sizeX, y);
			chart3.Location = new Point(chart_bg1_posX + chart_sizeX*2 + 6, 0);
			chart4.Size = new Size(chart_sizeX, y);
			chart4.Location = new Point(chart_bg1_posX + chart_sizeX*3 + 9, 0);
			chart_line.Size = new Size(chart_line_sizeX, 2);
			chart_line.Location = new Point(chart_line_posX, chart_line_posY);

			chart1_key.Location = new Point(chart_sizeX / 2 - 21, chart_key_posY);
			chart2_key.Location = new Point(chart_sizeX / 2 - 21, chart_key_posY);
			chart3_key.Location = new Point(chart_sizeX / 2 - 21, chart_key_posY);
			chart4_key.Location = new Point(chart_sizeX / 2 - 21, chart_key_posY);

			if (notes1[1] == null) return;
			foreach (var circle in notes1)
				circle.Size = new Size(circle_size, circle_size);
			foreach (var circle in notes2)
				circle.Size = new Size(circle_size, circle_size);
			foreach (var circle in notes3)
				circle.Size = new Size(circle_size, circle_size);
			foreach (var circle in notes4)
				circle.Size = new Size(circle_size, circle_size);
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
					p1.Open(new System.Uri(s + @"\audio\note-hit-S.wav"));
					break;
				case 4:
					p1.Open(new System.Uri(s + @"\audio\note-hit-D.wav"));
					break;
				case 5:
					p1.Open(new System.Uri(s + @"\audio\note-hit-K.wav"));
					break;
				case 6:
					p1.Open(new System.Uri(s + @"\audio\note-hit-L.wav"));
					break;
				case 7:
					break;
				case 8:
					break;
				case 9:
					break;
				case 10:
					break;
				case 11:
					p1.Open(new System.Uri(s + @"\audio\miss1.wav"));
					break;
				case 12:
					p1.Open(new System.Uri(s + @"\audio\miss2.wav"));
					break;
				case 13:
					p1.Open(new System.Uri(s + @"\audio\miss3.wav"));
					break;
				case 14:
					p1.Open(new System.Uri(s + @"\audio\miss4.wav"));
					break;
				default:
					p1.Open(new System.Uri(s + @"\audio\hover.wav"));
					break;
            }
			p1.Play();
		}

		public MainForm()
		{
			InitializeComponent();
		}
		
		void Exit_buttonClick(object sender, EventArgs e)
		{
			playSound(2);
			Application.Exit();
		}
		
		void Meniu_buttonClick(object sender, EventArgs e)
		{
			playSound(2);
			if (isMenuOpen) {
				isMenuOpen = false;
				MenuPanel.Visible = false;
			}
			else {
				isMenuOpen = true;
				MenuPanel.Visible = true;
			}
		}

		void MainFormLoad(object sender, EventArgs e)
		{
			notes1[0] = chart1circle1;
			notes1[1] = chart1circle2;
			notes1[2] = chart1circle3;
			notes1[3] = chart1circle4;
			notes1[4] = chart1circle5;
			notes1[5] = chart1circle6;
			notes1[6] = chart1circle7;
			notes1[7] = chart1circle8;
			notes1[8] = chart1circle9;
			notes1[9] = chart1circle10;

			notes2[0] = chart2circle1;
			notes2[1] = chart2circle2;
			notes2[2] = chart2circle3;
			notes2[3] = chart2circle4;
			notes2[4] = chart2circle5;
			notes2[5] = chart2circle6;
			notes2[6] = chart2circle7;
			notes2[7] = chart2circle8;
			notes2[8] = chart2circle9;
			notes2[9] = chart2circle10;

			notes3[0] = chart3circle1;
			notes3[1] = chart3circle2;
			notes3[2] = chart3circle3;
			notes3[3] = chart3circle4;
			notes3[4] = chart3circle5;
			notes3[5] = chart3circle6;
			notes3[6] = chart3circle7;
			notes3[7] = chart3circle8;
			notes3[8] = chart3circle9;
			notes3[9] = chart3circle10;

			notes4[0] = chart4circle1;
			notes4[1] = chart4circle2;
			notes4[2] = chart4circle3;
			notes4[3] = chart4circle4;
			notes4[4] = chart4circle5;
			notes4[5] = chart4circle6;
			notes4[6] = chart4circle7;
			notes4[7] = chart4circle8;
			notes4[8] = chart4circle9;
			notes4[9] = chart4circle10;

			if (notes1[1] == null) return;
			foreach (var circle in notes1)
				circle.Location = new Point(-1000, 0);
			foreach (var circle in notes2)
				circle.Location = new Point(-1000, 0);
			foreach (var circle in notes3)
				circle.Location = new Point(-1000, 0);
			foreach (var circle in notes4)
				circle.Location = new Point(-1000, 0);

			if (File.Exists("last_login.u"))
			{
				user = File.ReadAllText("last_login.u");
				logare_button.Visible = false;
				username_label.Text = "Logat ca: " + user;
				username_label.Visible = true;
				delogare_button.Visible = true;
				if (File.Exists("is.admin"))
				{
					is_admin = true;
					username_label.Text = "Logat ca: " + user + " (admin)";
					admin_button.Visible = true;
				}
			}

			if (File.Exists(@"low_detail.setting"))
			{
				low_detail_off.Visible = false;
				low_detail_on.Visible = true;
				int x = 1;
				foreach (var circle in notes1)
				{
					circle.Image = null;
					circle.BackColor = ColorTranslator.FromHtml("#ed1740");
					if (x%2 == 0)
						circle.BackColor = ColorTranslator.FromHtml("#BD1434");
					x++;
				}
				foreach (var circle in notes2)
				{
					circle.Image = null;
					circle.BackColor = ColorTranslator.FromHtml("#20a3a1");
					if (x % 2 == 0)
						circle.BackColor = ColorTranslator.FromHtml("#1C807E");
					x++;
				}
				foreach (var circle in notes3)
				{
					circle.Image = null;
					circle.BackColor = ColorTranslator.FromHtml("#20a3a1");
					if (x % 2 == 0)
						circle.BackColor = ColorTranslator.FromHtml("#1C807E");
					x++;
				}
				foreach (var circle in notes4)
				{
					circle.Image = null;
					circle.BackColor = ColorTranslator.FromHtml("#ed1740");
					if (x % 2 == 0)
						circle.BackColor = ColorTranslator.FromHtml("#BD1434");
					x++;
				}
			}

			if (File.Exists(@"muzica_off.setting"))
            {
				muzica_off.Visible = true;
				muzica_on.Visible = false;
            }

			if (File.Exists(@"sunet_off.setting"))
			{
				sunet_off.Visible = true;
				sunet_on.Visible = false;
			}

			if (File.Exists(@"fullscreen_off.setting"))
            {
				fullscreen_off.Visible = true;
				fullscreen_on.Visible = false;
				Form.ActiveForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
				Form.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Normal;
			}

			resizeScreen();
		}
		
		private void MainForm_Resize(object sender, System.EventArgs e)
		{
			resizeScreen();
		}
		
		void Fullscreen_offClick(object sender, EventArgs e)
		{
			playSound(2);
			Form.ActiveForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			Form.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			fullscreen_on.Visible = true;
			fullscreen_off.Visible = false;
			if (File.Exists(@"fullscreen_off.setting"))
				File.Delete(@"fullscreen_off.setting");
		}

		void Fullscreen_onClick(object sender, EventArgs e)
		{
			playSound(2);
			Form.ActiveForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
			Form.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Normal;
			fullscreen_on.Visible = false;
			fullscreen_off.Visible = true;
			var f = File.Create(@"fullscreen_off.setting");
			f.Close();
		}

		private void low_detail_on_Click(object sender, EventArgs e)
		{
			playSound(2);
			restart_label.Visible = true;
			low_detail_off.Visible = true;
			low_detail_on.Visible = false;
			if (File.Exists(@"low_detail.setting"))
				File.Delete(@"low_detail.setting");
		}

		private void low_detail_off_Click(object sender, EventArgs e)
		{
			playSound(2);
			restart_label.Visible = true;
			low_detail_off.Visible = false;
			low_detail_on.Visible = true;
            var f =File.Create(@"low_detail.setting");
			f.Close();
		}

        private void sunet_off_Click(object sender, EventArgs e)
		{
			playSound(2);
			sunet_on.Visible = true;
			sunet_off.Visible = false;
			if (File.Exists(@"sunet_off.setting"))
				File.Delete(@"sunet_off.setting");
		}

		private void sunet_on_Click(object sender, EventArgs e)
		{
			playSound(2);
			sunet_on.Visible = false;
			sunet_off.Visible = true;
			var f = File.Create(@"sunet_off.setting");
			f.Close();
		}

		private void muzica_on_Click(object sender, EventArgs e)
		{
			playSound(2);
			muzica_on.Visible = false;
			muzica_off.Visible = true;
			var f = File.Create(@"muzica_off.setting");
			f.Close();
		}

		private void muzica_off_Click(object sender, EventArgs e)
		{
			playSound(2);
			muzica_on.Visible = true;
			muzica_off.Visible = false;
			if (File.Exists(@"muzica_off.setting"))
				File.Delete(@"muzica_off.setting");
		}

		void Play_buttonClick(object sender, EventArgs e)
		{
			playSound(1);
			if (is_logging_in || user == null || user == "")
            {
				MessageBox.Show("Finisează logarea înainte ca să te joci!", "Eroare!",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
            }

			if (File.Exists(@"bans\"+user))
            {
				MessageBox.Show("Accesul interzis!", "Eroare!",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			PlayPanel.Visible = true;
			MenuPanel.Visible = false;
			isMenuOpen = false;
			MainPanel.Visible = false;
			if (!songSelect1.AutoSize)
				songSelect1.AutoSize = true;
		}
		void Back_buttonClick(object sender, EventArgs e)
		{
			playSound(2);
			PlayPanel.Visible = false;
			MainPanel.Visible = true;
			if (songSelect1.AutoSize)
				songSelect1.AutoSize = false;
		}

        private void PlaySong_Click(object sender, EventArgs e) //GO CLICK!!!! <-----------------
		{
			playSound(1);

			string selectedSong = File.ReadAllText(@"..\..\..\selected_song.temp");

			if (File.Exists(selectedSong + @"\ascunsa"))
			{
				MessageBox.Show("Această melodie este ascunsă!", "Eroare!",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			combo = 0;
			max_combo = 0;
			miss_count = 0;
			actual_max_combo = 0;
			combo_label.Text = "0x";
			max_combo_label.Text = "0x";
			miss_count_label.Text = "0";
			PlayPanel.Visible = false;
			MainPanel.Visible = true;

			if (songSelect1.AutoSize)
				songSelect1.AutoSize = false;
			GameplayPanel.Visible = true;

			song1 = (System.IO.File.ReadAllText(selectedSong + @"\timing1.txt")).Split(
				new string[] { "\r\n", "\r", "\n" },
				StringSplitOptions.None
			);
			song2 = (System.IO.File.ReadAllText(selectedSong + @"\timing2.txt")).Split(
				new string[] { "\r\n", "\r", "\n" },
				StringSplitOptions.None
			);
			song3 = (System.IO.File.ReadAllText(selectedSong + @"\timing3.txt")).Split(
				new string[] { "\r\n", "\r", "\n" },
				StringSplitOptions.None
			);
			song4 = (System.IO.File.ReadAllText(selectedSong + @"\timing4.txt")).Split(
				new string[] { "\r\n", "\r", "\n" },
				StringSplitOptions.None
			);

			offset = Convert.ToInt32(System.IO.File.ReadAllText(selectedSong + @"\offset.txt"));
			timer1.Start();
		}

        private void back2_Click(object sender, EventArgs e)
		{
			playSound(2);
			GameplayPanel.Visible = false;
			timer1.Stop();
			tick = -70;

			circle1 = 0;
			circle2 = 0;
			circle3 = 0;
			circle4 = 0;

			count1 = 0;
			count2 = 0;
			count3 = 0;
			count4 = 0;

			if (notes1[1] == null) return;
			foreach (var circle in notes1)
				circle.Location = new Point(-1000, 0);
			foreach (var circle in notes2)
				circle.Location = new Point(-1000, 0);
			foreach (var circle in notes3)
				circle.Location = new Point(-1000, 0);
			foreach (var circle in notes4)
				circle.Location = new Point(-1000, 0);

			if (audio != null)
			{
				audio.Stop();
				audio = null;
			}
		}

		public double getNota(int combo_, int maxcombo_, int miss)
        {
			double x = Math.Round(Convert.ToDouble(combo_)/Convert.ToDouble(maxcombo_)*100)/10;
			for (int i = 0; i < miss; i++)
			{ x = x - 0.1; Console.WriteLine(x); }
				if (x < 1)
				x = 1;

			return x;
        }
		public static double ConvertToUnixTimestamp(DateTime date)
		{
			DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			TimeSpan diff = date.ToUniversalTime() - origin;
			return Math.Floor(diff.TotalSeconds);
		}

		private void addCircles()
        {
			if (Convert.ToInt32(song1[count1]) == -1 || Convert.ToInt32(song2[count2]) == -1 || Convert.ToInt32(song3[count3]) == -1 || Convert.ToInt32(song4[count4]) == -1)
            {
				stop_tick++; //----- FINISH PLAY STOP PLAY
				if (stop_tick > 200)
				{
					timer1.Stop();
					EndPanel.Visible = true;
					GameplayPanel.Visible = false;
					MainPanel.Visible = true;
					end_combo_label.Text = "Combo: " + combo_label.Text;
					end_max_combo_label.Text = "Max combo: " + Convert.ToString(max_combo) + "/" + Convert.ToString(actual_max_combo);
					end_miss_label.Text = "Ratări: " + miss_count_label.Text;
					double nota = getNota(max_combo, actual_max_combo, miss_count);
					end_nota.Text = "Nota: " + Convert.ToString(nota);
					DateTimeOffset now = DateTimeOffset.UtcNow;
					long unixTimeMilliseconds = now.ToUnixTimeMilliseconds();
					if (nota == 10) nota = 99.9;
					File.WriteAllText(File.ReadAllText(@"..\..\..\selected_song.temp") + @"\scores\-" + Convert.ToString(nota*10) + "-" + Convert.ToString(unixTimeMilliseconds) , user);

					tick = -70;
					offset = 0;
					stop_tick = 0;

					actual_max_combo = 0;
					combo = 0;
					max_combo = 0;
					miss_count = 0;

					circle1 = 0;
					circle2 = 0;
					circle3 = 0;
					circle4 = 0;

					count1 = 0;
					count2 = 0;
					count3 = 0;
					count4 = 0;

					s_held = false;
					d_held = false;
					k_held = false;
					l_held = false;

					if (audio != null)
					{
						audio.Stop();
						audio = null;
					}

				}
				return;
            }
			int size = Convert.ToInt32(chart1circle1.Size.Height / 2);

			if (Convert.ToInt32(song1[count1]) == tick)
			{
				count1++;
				notes1[circle1].Location = new Point(size, -1 * size * 2);
				circle1++;
				actual_max_combo++;
				if (circle1 > 9) circle1 = 0;
			}
			if (Convert.ToInt32(song2[count2]) == tick)
			{
				count2++;
				notes2[circle2].Location = new Point(size, -1 * size *2);
				circle2++;
				actual_max_combo++;
				if (circle2 > 9) circle2 = 0;
			}
			if (Convert.ToInt32(song3[count3]) == tick)
			{
				count3++;
				notes3[circle3].Location = new Point(size, -1 * size * 2);
				circle3++;
				actual_max_combo++;
				if (circle3 > 9) circle3 = 0;
			}
			if (Convert.ToInt32(song4[count4]) == tick)
			{
				count4++;
				notes4[circle4].Location = new Point(size, -1 * size * 2);
				circle4++;
				actual_max_combo++;
				if (circle4 > 9) circle4 = 0;
			}

			tick = tick + 1;

			if (tick != offset) return; if (File.Exists("muzica_off.setting")) return;

			string selectedSong = System.IO.File.ReadAllText(@"..\..\..\selected_song.temp");
			string songPath = selectedSong + @"\audio.wav";
			audio = new SoundPlayer(songPath);
			audio.Play();
		}

		private void addMiss(int x)
		{
			combo = 0;
			miss_count++;
			playSound(10 + x);
			combo_label.Text = "0x";
			miss_count_label.Text = Convert.ToString(miss_count);
        }

		private void addCombo(int x)
        {
			combo++;
			if (max_combo < combo) max_combo = combo;
			playSound(6+x);
			combo_label.Text = Convert.ToString(combo)+"x";
			max_combo_label.Text = Convert.ToString(max_combo)+"x";
		}

		private void key_heldS()
        {
			if (s_held) return;
			s_held = true;
			playSound(3);
			chart1_key.BackColor = Color.FromArgb(110, 110, 70);
			bool miss = true;
			if (tick < 0) return;

			foreach (var circle in notes1)
				if (circle.Location.X > 0 && circle.Location.Y > this.Height*.65)
                {
					addCombo(1);
					circle.Location = new Point(-1000, 0);
					miss = false;
					break;
				}
			if (!miss) return;
			addMiss(1);
		}

		private void key_heldD()
		{
			if (d_held) return;
			d_held = true;
			playSound(4);
			chart2_key.BackColor = System.Drawing.Color.FromArgb(110, 110, 70);
			bool miss = true;
			if (tick < 0) return;

			foreach (var circle in notes2)
				if (circle.Location.X > 0 && circle.Location.Y > this.Height * .65)
				{
					addCombo(2);
					circle.Location = new Point(-1000, 0);
					miss = false;
					break;
				}
			if (!miss) return;
			addMiss(2);
		}

		private void key_heldK()
		{
			if (k_held) return;
			k_held = true;
			playSound(5);
			chart3_key.BackColor = System.Drawing.Color.FromArgb(110, 110, 70);
			bool miss = true;
			if (tick < 0) return;

			foreach (var circle in notes3)
				if (circle.Location.X > 0 && circle.Location.Y > this.Height * .65)
				{
					addCombo(3);
					circle.Location = new Point(-1000, 0);
					miss = false;
					break;
				}
			if (!miss) return;
			addMiss(3);
		}

		private void key_heldL()
		{
			if (l_held) return;
			l_held = true;
			playSound(6);
			chart4_key.BackColor = System.Drawing.Color.FromArgb(110, 110, 70);
			bool miss = true;
			if (tick < 0) return;

			foreach (var circle in notes4)
				if (circle.Location.X > 0 && circle.Location.Y > this.Height * .65)
				{
					addCombo(4);
					circle.Location = new Point(-1000, 0);
					miss = false;
					break;
				}
			if (!miss) return;
			addMiss(4);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			addCircles();
			int add_value = Convert.ToInt32(chart1circle1.Height * .15);

			foreach (var circle in notes1) 
			{ 
				circle.Location = new Point(circle.Location.X, circle.Location.Y + add_value);
				if (circle.Location.X > 0 && circle.Location.Y > this.Height)
                {
					addMiss(1);
					circle.Location = new Point(-1000, 0);
                }
			}

			foreach (var circle in notes2)
			{
				circle.Location = new Point(circle.Location.X, circle.Location.Y + add_value);
				if (circle.Location.X > 0 && circle.Location.Y > this.Height)
				{
					addMiss(2);
					circle.Location = new Point(-1000, 0);
				}
			}

			foreach (var circle in notes3)
			{
				circle.Location = new Point(circle.Location.X, circle.Location.Y + add_value);
				if (circle.Location.X > 0 && circle.Location.Y > this.Height)
				{
					addMiss(3);
					circle.Location = new Point(-1000, 0);
				}
			}

			foreach (var circle in notes4)
			{
				circle.Location = new Point(circle.Location.X, circle.Location.Y + add_value);
				if (circle.Location.X > 0 && circle.Location.Y > this.Height)
				{
					addMiss(4);
					circle.Location = new Point(-1000, 0);
				}
			}

			if (Keyboard.IsKeyDown(Key.S))
                key_heldS();
			else
			{
				s_held = false;
				chart1_key.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
			}

			if (Keyboard.IsKeyDown(Key.D))
				key_heldD();
			else
            {
				chart2_key.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
				d_held = false;
			}

			if (Keyboard.IsKeyDown(Key.K))
				key_heldK();
			else
			{
				k_held = false;
				chart3_key.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
			}

			if (Keyboard.IsKeyDown(Key.L))
				key_heldL();
			else
			{
				l_held = false;
				chart4_key.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
			}
		}

        private void button_MouseEnter(object sender, EventArgs e)
        {
			playSound(0);
			if (sender.ToString().Split(',')[0] == "System.Windows.Forms.Button")
				return;
			PictureBox btn = sender as PictureBox;
			var color = btn.BackColor;
			var R = color.R+35; var G = color.G+35; var B = color.B+35;
			if (R > 255) R = R - 70;
			if (B > 255) B = B - 70;
			if (G > 255) G = G - 70;

			btn.BackColor = System.Drawing.Color.FromArgb(R, G, B);
		}

        private void button_MouseLeave(object sender, EventArgs e)
        {
			if (sender.ToString().Split(',')[0] == "System.Windows.Forms.Button")
				return;
			PictureBox btn = sender as PictureBox;
			btn.BackColor = btn.Parent.BackColor;
		}

		public void WriteTextSafe(string text)
		{
			if (_temp.InvokeRequired)
			{
				// Call this same method but append THREAD2 to the text
				Action safeWrite = delegate { WriteTextSafe($"{text} (THREAD2)"); };
				_temp.Invoke(safeWrite);
			}
			else
				_temp.Text = text;
		}

		public void ThreadProc()
		{
			while (File.Exists("is_logging.in"))
				Thread.Sleep(500);

			is_logging_in = false;
			if (File.Exists("username.in"))
				WriteTextSafe(_temp.Text + "s");
		}

		private void logare_button_Click(object sender, EventArgs e)
		{
			try
			{
				logare.Close();
			}
			catch {}
			playSound(2);
			logare = new LoginForm();
			logare.Show();
			is_logging_in = true;
			if (File.Exists("is.admin"))
				File.Delete("is.admin");
			File.Create("is_logging.in").Close();
			Thread t = new Thread(new ThreadStart(ThreadProc));
			t.Start();
		}

        private void admin_button_Click(object sender, EventArgs e)
        {
			playSound(2);
			try
			{
				adminForm.Close();
			}
			catch { }
			adminForm = new admin();
			adminForm.Show();
		}

        private void delogare_button_Click(object sender, EventArgs e)
        {
			playSound(2);
			if (File.Exists("last_login.u"))
				File.Delete("last_login.u");
			if (File.Exists("is.admin"))
				File.Delete("is.admin");

			logare_button.Visible = true;
			delogare_button.Visible = false;
			username_label.Visible = false;
			admin_button.Visible = false;
			user = null;
		}

        private void _temp_TextChanged(object sender, EventArgs e)
        {
			user = File.ReadAllText("username.in");
			logare_button.Visible = false;
			username_label.Text = "Logat ca: " + user;
			username_label.Visible = true;
			delogare_button.Visible = true;
			File.Delete("username.in");
			playSound(1);
			if (File.Exists("is.admin"))
			{
				is_admin = true;
				username_label.Text = "Logat ca: " + user + " (admin)";
				admin_button.Visible = true;
			}
		}

		private void retry_button_Click(object sender, EventArgs e)
        {
			EndPanel.Visible = false;
			playSound(1);
			combo = 0;
			max_combo = 0;
			miss_count = 0;
			actual_max_combo = 0;
			combo_label.Text = "0x";
			max_combo_label.Text = "0x";
			miss_count_label.Text = "0";
			PlayPanel.Visible = false;
			MainPanel.Visible = true;
			string selectedSong = System.IO.File.ReadAllText(@"..\..\..\selected_song.temp");

			if (songSelect1.AutoSize)
				songSelect1.AutoSize = false;
			GameplayPanel.Visible = true;

			song1 = (System.IO.File.ReadAllText(selectedSong + @"\timing1.txt")).Split(
				new string[] { "\r\n", "\r", "\n" },
				StringSplitOptions.None
			);
			song2 = (System.IO.File.ReadAllText(selectedSong + @"\timing2.txt")).Split(
				new string[] { "\r\n", "\r", "\n" },
				StringSplitOptions.None
			);
			song3 = (System.IO.File.ReadAllText(selectedSong + @"\timing3.txt")).Split(
				new string[] { "\r\n", "\r", "\n" },
				StringSplitOptions.None
			);
			song4 = (System.IO.File.ReadAllText(selectedSong + @"\timing4.txt")).Split(
				new string[] { "\r\n", "\r", "\n" },
				StringSplitOptions.None
			);

			offset = Convert.ToInt32(System.IO.File.ReadAllText(selectedSong + @"\offset.txt"));
			timer1.Start();
		}

        private void back_button3_Click(object sender, EventArgs e)
        {
			EndPanel.Visible = false;
			MainPanel.Visible = true;
			GameplayPanel.Visible = false;
		}

    }
}
