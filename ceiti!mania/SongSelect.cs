using System;
using System.IO;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ceiti_mania
{
    public partial class SongSelect : UserControl
    {
        int count = 0;
        int maxCount = 0;
        string[] Songs;
        
        string songsFolder = @"..\..\..\songs";
        SoundPlayer audio;

        public void resizeScreen()
        {
            int x = this.Width,
                y = this.Height;

            int song_bg_sizeX = Convert.ToInt32((x - 200) * 0.7),
                song_bg_sizeY = Convert.ToInt32((y - 70) * 0.7),
                song_bg_posX = Convert.ToInt32(200 + ((x - 200) / 2 - song_bg_sizeX/2)),
                song_bg_posY = Convert.ToInt32(y/2.6 - song_bg_sizeY/2),
                button_sizeX = Convert.ToInt32(x / 16),
                button_sizeY = Convert.ToInt32(y / 6.35),
                button_posY = Convert.ToInt32(y / 2 - button_sizeY / 2),
                next_posX = Convert.ToInt32(song_bg_sizeX + song_bg_posX),
                back_posX = Convert.ToInt32(song_bg_posX-button_sizeX);

            song_bg.Size = new Size(song_bg_sizeX, song_bg_sizeY);
            song_bg.Location = new Point(song_bg_posX, song_bg_posY);
            next.Size = new Size(button_sizeX, button_sizeY);
            back.Size = new Size(button_sizeX, button_sizeY);
            next.Location = new Point(next_posX, button_posY);
            back.Location = new Point(back_posX, button_posY);
        }

        void ChangeLeaderboard(string path)
        {
            int x = 1;
            leaderboard.Text = "Top note\n";
            var files = Directory.EnumerateFiles(path).OrderByDescending(filename => filename);

            foreach (var file in files)
            {
                string[] sp = file.Split('-');
                string nota = Convert.ToString(Convert.ToDouble(sp[sp.Length - 2]) / 10);
                if (nota == "99.9") nota = "10"; 
                leaderboard.Text = leaderboard.Text + "\n" +
                    Convert.ToString(x) + ". " + File.ReadAllText(file) + " - nota " + nota;
                if (x > 10) break;
                x++;
            }
        }

        private void ChangeSong()
        {
            if (count >= maxCount)
                count = maxCount-1;
            else if (count < 0)
                count = 0;

            string songName = Songs[count];
            song_name.Text = songName.Replace(songsFolder + @"\", string.Empty);
            song_bg.ImageLocation = songName + @"\bg.jpg";
            ChangeLeaderboard(songName + @"\scores");
            if (audio != null) audio.Stop();
            audio = new SoundPlayer(songName+@"\audio.wav");
            if (!File.Exists(@"muzica_off.setting"))
                audio.PlayLooping();
            File.WriteAllText(@"..\..\..\selected_song.temp", Songs[count]);
        }

        private void RefreshSongList()
        {
            Songs = Directory.GetDirectories(songsFolder);
            maxCount = Songs.Length;
            ChangeSong();
        }


        public SongSelect()
        {
            InitializeComponent();
        }

        private void SongSelect_Load(object sender, EventArgs e)
        {
            resizeScreen();
            RefreshSongList();
        }

        private void SongSelect_Resize(object sender, EventArgs e)
        {
            resizeScreen();
        }

        private void back_Click(object sender, EventArgs e)
        {
            count--;
            ChangeSong();
        }

        private void next_Click(object sender, EventArgs e)
        {
            count++;
            ChangeSong();
        }

        private void SongSelect_AutoSizeChanged(object sender, EventArgs e)
        {
            if (this.AutoSize)
                ChangeSong();
            else
            {
                if (audio != null)
                    audio.Stop();
                audio = null;
            }
        }
    }
}
