namespace ceiti_mania
{
    partial class SongSelect
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongSelect));
            this.leaderboard = new System.Windows.Forms.Label();
            this.aer = new System.Windows.Forms.Label();
            this.song_name = new System.Windows.Forms.Label();
            this.song_bg = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.next = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.song_bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).BeginInit();
            this.SuspendLayout();
            // 
            // leaderboard
            // 
            this.leaderboard.AutoSize = true;
            this.leaderboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.leaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderboard.ForeColor = System.Drawing.Color.DarkBlue;
            this.leaderboard.Location = new System.Drawing.Point(0, 110);
            this.leaderboard.Name = "leaderboard";
            this.leaderboard.Size = new System.Drawing.Size(179, 145);
            this.leaderboard.TabIndex = 7;
            this.leaderboard.Text = "Leaderboard\r\n\r\nAlex - nota 10\r\nIon - nota 9.6\r\nVasea - nota 3";
            this.leaderboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aer
            // 
            this.aer.AutoSize = true;
            this.aer.Dock = System.Windows.Forms.DockStyle.Top;
            this.aer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aer.Location = new System.Drawing.Point(0, 37);
            this.aer.Name = "aer";
            this.aer.Size = new System.Drawing.Size(0, 73);
            this.aer.TabIndex = 6;
            this.aer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // song_name
            // 
            this.song_name.AutoSize = true;
            this.song_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.song_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.song_name.Location = new System.Drawing.Point(0, 0);
            this.song_name.Name = "song_name";
            this.song_name.Size = new System.Drawing.Size(209, 37);
            this.song_name.TabIndex = 5;
            this.song_name.Text = "Numa Numa";
            this.song_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // song_bg
            // 
            this.song_bg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.song_bg.Location = new System.Drawing.Point(199, 81);
            this.song_bg.Name = "song_bg";
            this.song_bg.Size = new System.Drawing.Size(637, 390);
            this.song_bg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.song_bg.TabIndex = 4;
            this.song_bg.TabStop = false;
            // 
            // back
            // 
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(179, 203);
            this.back.MaximumSize = new System.Drawing.Size(120, 170);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(120, 170);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 8;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // next
            // 
            this.next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next.Image = ((System.Drawing.Image)(resources.GetObject("next.Image")));
            this.next.Location = new System.Drawing.Point(754, 203);
            this.next.MaximumSize = new System.Drawing.Size(120, 170);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(120, 170);
            this.next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.next.TabIndex = 9;
            this.next.TabStop = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // SongSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.leaderboard);
            this.Controls.Add(this.next);
            this.Controls.Add(this.back);
            this.Controls.Add(this.aer);
            this.Controls.Add(this.song_name);
            this.Controls.Add(this.song_bg);
            this.Name = "SongSelect";
            this.Size = new System.Drawing.Size(877, 536);
            this.AutoSizeChanged += new System.EventHandler(this.SongSelect_AutoSizeChanged);
            this.Load += new System.EventHandler(this.SongSelect_Load);
            this.Resize += new System.EventHandler(this.SongSelect_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.song_bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leaderboard;
        private System.Windows.Forms.Label aer;
        private System.Windows.Forms.Label song_name;
        private System.Windows.Forms.PictureBox song_bg;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox next;
    }
}
