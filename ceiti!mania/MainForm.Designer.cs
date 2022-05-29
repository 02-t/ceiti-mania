/*
 * Created by SharpDevelop.
 * User: Alex
 * Date: 5/3/2022
 * Time: 7:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ceiti_mania
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel MainPanel;
		private System.Windows.Forms.PictureBox logo_menu;
		private System.Windows.Forms.PictureBox play_button;
		private System.Windows.Forms.PictureBox exit_button;
		private System.Windows.Forms.PictureBox meniu_button;
		private System.Windows.Forms.PictureBox menu_bar;
		private System.Windows.Forms.PictureBox fullscreen_on;
		private System.Windows.Forms.PictureBox fullscreen_off;
		private System.Windows.Forms.Panel MenuPanel;
		private System.Windows.Forms.Label credits;
		private System.Windows.Forms.Panel PlayPanel;
		private System.Windows.Forms.PictureBox back_button;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.restart_label = new System.Windows.Forms.PictureBox();
            this.low_detail_off = new System.Windows.Forms.PictureBox();
            this.low_detail_on = new System.Windows.Forms.PictureBox();
            this.fullscreen_off = new System.Windows.Forms.PictureBox();
            this.fullscreen_on = new System.Windows.Forms.PictureBox();
            this.muzica_on = new System.Windows.Forms.PictureBox();
            this.sunet_off = new System.Windows.Forms.PictureBox();
            this.sunet_on = new System.Windows.Forms.PictureBox();
            this.muzica_off = new System.Windows.Forms.PictureBox();
            this.menu_bar = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.PictureBox();
            this.meniu_button = new System.Windows.Forms.PictureBox();
            this.play_button = new System.Windows.Forms.PictureBox();
            this.logo_menu = new System.Windows.Forms.PictureBox();
            this._temp = new System.Windows.Forms.Label();
            this.admin_button = new System.Windows.Forms.Button();
            this.delogare_button = new System.Windows.Forms.Button();
            this.logare_button = new System.Windows.Forms.Button();
            this.username_label = new System.Windows.Forms.Label();
            this.credits = new System.Windows.Forms.Label();
            this.PlayPanel = new System.Windows.Forms.Panel();
            this.Go = new System.Windows.Forms.PictureBox();
            this.songSelect1 = new ceiti_mania.SongSelect();
            this.back_button = new System.Windows.Forms.PictureBox();
            this.GameplayPanel = new System.Windows.Forms.Panel();
            this.chart_line = new System.Windows.Forms.PictureBox();
            this.miss_count_label = new System.Windows.Forms.Label();
            this.max_combo_label = new System.Windows.Forms.Label();
            this.combo_label = new System.Windows.Forms.Label();
            this.chart4 = new System.Windows.Forms.Panel();
            this.chart4_key = new System.Windows.Forms.Label();
            this.chart4circle10 = new System.Windows.Forms.PictureBox();
            this.chart4circle9 = new System.Windows.Forms.PictureBox();
            this.chart4circle8 = new System.Windows.Forms.PictureBox();
            this.chart4circle7 = new System.Windows.Forms.PictureBox();
            this.chart4circle6 = new System.Windows.Forms.PictureBox();
            this.chart4circle5 = new System.Windows.Forms.PictureBox();
            this.chart4circle4 = new System.Windows.Forms.PictureBox();
            this.chart4circle3 = new System.Windows.Forms.PictureBox();
            this.chart4circle2 = new System.Windows.Forms.PictureBox();
            this.chart4circle1 = new System.Windows.Forms.PictureBox();
            this.chart3 = new System.Windows.Forms.Panel();
            this.chart3_key = new System.Windows.Forms.Label();
            this.chart3circle10 = new System.Windows.Forms.PictureBox();
            this.chart3circle2 = new System.Windows.Forms.PictureBox();
            this.chart3circle8 = new System.Windows.Forms.PictureBox();
            this.chart3circle1 = new System.Windows.Forms.PictureBox();
            this.chart3circle9 = new System.Windows.Forms.PictureBox();
            this.chart3circle3 = new System.Windows.Forms.PictureBox();
            this.chart3circle6 = new System.Windows.Forms.PictureBox();
            this.chart3circle4 = new System.Windows.Forms.PictureBox();
            this.chart3circle7 = new System.Windows.Forms.PictureBox();
            this.chart3circle5 = new System.Windows.Forms.PictureBox();
            this.chart2 = new System.Windows.Forms.Panel();
            this.chart2circle10 = new System.Windows.Forms.PictureBox();
            this.chart2_key = new System.Windows.Forms.Label();
            this.chart2circle9 = new System.Windows.Forms.PictureBox();
            this.chart2circle8 = new System.Windows.Forms.PictureBox();
            this.chart2circle7 = new System.Windows.Forms.PictureBox();
            this.chart2circle6 = new System.Windows.Forms.PictureBox();
            this.chart2circle5 = new System.Windows.Forms.PictureBox();
            this.chart2circle4 = new System.Windows.Forms.PictureBox();
            this.chart2circle3 = new System.Windows.Forms.PictureBox();
            this.chart2circle2 = new System.Windows.Forms.PictureBox();
            this.chart2circle1 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.Panel();
            this.chart1circle10 = new System.Windows.Forms.PictureBox();
            this.chart1_key = new System.Windows.Forms.Label();
            this.chart1circle9 = new System.Windows.Forms.PictureBox();
            this.chart1circle8 = new System.Windows.Forms.PictureBox();
            this.chart1circle7 = new System.Windows.Forms.PictureBox();
            this.chart1circle6 = new System.Windows.Forms.PictureBox();
            this.chart1circle5 = new System.Windows.Forms.PictureBox();
            this.chart1circle4 = new System.Windows.Forms.PictureBox();
            this.chart1circle3 = new System.Windows.Forms.PictureBox();
            this.chart1circle2 = new System.Windows.Forms.PictureBox();
            this.chart1circle1 = new System.Windows.Forms.PictureBox();
            this.chart_bg1 = new System.Windows.Forms.PictureBox();
            this.back_button2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.EndPanel = new System.Windows.Forms.Panel();
            this.retry_button = new System.Windows.Forms.PictureBox();
            this.back_button3 = new System.Windows.Forms.PictureBox();
            this.end_max_combo_label = new System.Windows.Forms.Label();
            this.end_miss_label = new System.Windows.Forms.Label();
            this.end_combo_label = new System.Windows.Forms.Label();
            this.end_nota = new System.Windows.Forms.Label();
            this.felicitari_img = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restart_label)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.low_detail_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.low_detail_on)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullscreen_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullscreen_on)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muzica_on)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunet_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunet_on)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muzica_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meniu_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_menu)).BeginInit();
            this.PlayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Go)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).BeginInit();
            this.GameplayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_line)).BeginInit();
            this.chart4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4circle10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4circle9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4circle8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4circle7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4circle6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4circle5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4circle4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4circle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4circle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4circle1)).BeginInit();
            this.chart3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3circle10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3circle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3circle8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3circle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3circle9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3circle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3circle6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3circle4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3circle7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3circle5)).BeginInit();
            this.chart2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2circle10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2circle9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2circle8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2circle7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2circle6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2circle5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2circle4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2circle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2circle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2circle1)).BeginInit();
            this.chart1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1circle10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1circle9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1circle8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1circle7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1circle6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1circle5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1circle4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1circle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1circle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1circle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_bg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button2)).BeginInit();
            this.EndPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retry_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.felicitari_img)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.DarkGray;
            this.MainPanel.Controls.Add(this.MenuPanel);
            this.MainPanel.Controls.Add(this.exit_button);
            this.MainPanel.Controls.Add(this.meniu_button);
            this.MainPanel.Controls.Add(this.play_button);
            this.MainPanel.Controls.Add(this.logo_menu);
            this.MainPanel.Controls.Add(this._temp);
            this.MainPanel.Controls.Add(this.admin_button);
            this.MainPanel.Controls.Add(this.delogare_button);
            this.MainPanel.Controls.Add(this.logare_button);
            this.MainPanel.Controls.Add(this.username_label);
            this.MainPanel.Controls.Add(this.credits);
            this.MainPanel.Location = new System.Drawing.Point(0, 23);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1921, 1057);
            this.MainPanel.TabIndex = 0;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.MenuPanel.Controls.Add(this.restart_label);
            this.MenuPanel.Controls.Add(this.low_detail_off);
            this.MenuPanel.Controls.Add(this.low_detail_on);
            this.MenuPanel.Controls.Add(this.fullscreen_off);
            this.MenuPanel.Controls.Add(this.fullscreen_on);
            this.MenuPanel.Controls.Add(this.muzica_on);
            this.MenuPanel.Controls.Add(this.sunet_off);
            this.MenuPanel.Controls.Add(this.sunet_on);
            this.MenuPanel.Controls.Add(this.muzica_off);
            this.MenuPanel.Controls.Add(this.menu_bar);
            this.MenuPanel.Location = new System.Drawing.Point(12, 33);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(473, 613);
            this.MenuPanel.TabIndex = 7;
            this.MenuPanel.Visible = false;
            // 
            // restart_label
            // 
            this.restart_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.restart_label.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.restart_label.Image = ((System.Drawing.Image)(resources.GetObject("restart_label.Image")));
            this.restart_label.Location = new System.Drawing.Point(26, 70);
            this.restart_label.Name = "restart_label";
            this.restart_label.Size = new System.Drawing.Size(410, 79);
            this.restart_label.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restart_label.TabIndex = 13;
            this.restart_label.TabStop = false;
            this.restart_label.Visible = false;
            // 
            // low_detail_off
            // 
            this.low_detail_off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.low_detail_off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.low_detail_off.Image = ((System.Drawing.Image)(resources.GetObject("low_detail_off.Image")));
            this.low_detail_off.Location = new System.Drawing.Point(26, 473);
            this.low_detail_off.Name = "low_detail_off";
            this.low_detail_off.Size = new System.Drawing.Size(410, 79);
            this.low_detail_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.low_detail_off.TabIndex = 12;
            this.low_detail_off.TabStop = false;
            this.low_detail_off.Click += new System.EventHandler(this.low_detail_off_Click);
            this.low_detail_off.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.low_detail_off.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // low_detail_on
            // 
            this.low_detail_on.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.low_detail_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.low_detail_on.Image = ((System.Drawing.Image)(resources.GetObject("low_detail_on.Image")));
            this.low_detail_on.Location = new System.Drawing.Point(16, 505);
            this.low_detail_on.Name = "low_detail_on";
            this.low_detail_on.Size = new System.Drawing.Size(410, 79);
            this.low_detail_on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.low_detail_on.TabIndex = 11;
            this.low_detail_on.TabStop = false;
            this.low_detail_on.Visible = false;
            this.low_detail_on.Click += new System.EventHandler(this.low_detail_on_Click);
            this.low_detail_on.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.low_detail_on.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // fullscreen_off
            // 
            this.fullscreen_off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.fullscreen_off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fullscreen_off.Image = ((System.Drawing.Image)(resources.GetObject("fullscreen_off.Image")));
            this.fullscreen_off.Location = new System.Drawing.Point(26, 221);
            this.fullscreen_off.Name = "fullscreen_off";
            this.fullscreen_off.Size = new System.Drawing.Size(410, 79);
            this.fullscreen_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fullscreen_off.TabIndex = 5;
            this.fullscreen_off.TabStop = false;
            this.fullscreen_off.Visible = false;
            this.fullscreen_off.Click += new System.EventHandler(this.Fullscreen_offClick);
            this.fullscreen_off.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.fullscreen_off.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // fullscreen_on
            // 
            this.fullscreen_on.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.fullscreen_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fullscreen_on.Image = ((System.Drawing.Image)(resources.GetObject("fullscreen_on.Image")));
            this.fullscreen_on.Location = new System.Drawing.Point(37, 165);
            this.fullscreen_on.Name = "fullscreen_on";
            this.fullscreen_on.Size = new System.Drawing.Size(410, 79);
            this.fullscreen_on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fullscreen_on.TabIndex = 6;
            this.fullscreen_on.TabStop = false;
            this.fullscreen_on.Click += new System.EventHandler(this.Fullscreen_onClick);
            this.fullscreen_on.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.fullscreen_on.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // muzica_on
            // 
            this.muzica_on.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.muzica_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muzica_on.Image = ((System.Drawing.Image)(resources.GetObject("muzica_on.Image")));
            this.muzica_on.Location = new System.Drawing.Point(37, 259);
            this.muzica_on.Name = "muzica_on";
            this.muzica_on.Size = new System.Drawing.Size(410, 79);
            this.muzica_on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.muzica_on.TabIndex = 7;
            this.muzica_on.TabStop = false;
            this.muzica_on.Click += new System.EventHandler(this.muzica_on_Click);
            this.muzica_on.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.muzica_on.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // sunet_off
            // 
            this.sunet_off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.sunet_off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sunet_off.Image = ((System.Drawing.Image)(resources.GetObject("sunet_off.Image")));
            this.sunet_off.Location = new System.Drawing.Point(37, 384);
            this.sunet_off.Name = "sunet_off";
            this.sunet_off.Size = new System.Drawing.Size(410, 79);
            this.sunet_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sunet_off.TabIndex = 9;
            this.sunet_off.TabStop = false;
            this.sunet_off.Visible = false;
            this.sunet_off.Click += new System.EventHandler(this.sunet_off_Click);
            this.sunet_off.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.sunet_off.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // sunet_on
            // 
            this.sunet_on.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.sunet_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sunet_on.Image = ((System.Drawing.Image)(resources.GetObject("sunet_on.Image")));
            this.sunet_on.Location = new System.Drawing.Point(16, 371);
            this.sunet_on.Name = "sunet_on";
            this.sunet_on.Size = new System.Drawing.Size(410, 79);
            this.sunet_on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sunet_on.TabIndex = 10;
            this.sunet_on.TabStop = false;
            this.sunet_on.Click += new System.EventHandler(this.sunet_on_Click);
            this.sunet_on.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.sunet_on.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // muzica_off
            // 
            this.muzica_off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.muzica_off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muzica_off.Image = ((System.Drawing.Image)(resources.GetObject("muzica_off.Image")));
            this.muzica_off.Location = new System.Drawing.Point(37, 306);
            this.muzica_off.Name = "muzica_off";
            this.muzica_off.Size = new System.Drawing.Size(410, 82);
            this.muzica_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.muzica_off.TabIndex = 8;
            this.muzica_off.TabStop = false;
            this.muzica_off.Visible = false;
            this.muzica_off.Click += new System.EventHandler(this.muzica_off_Click);
            this.muzica_off.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.muzica_off.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // menu_bar
            // 
            this.menu_bar.Image = ((System.Drawing.Image)(resources.GetObject("menu_bar.Image")));
            this.menu_bar.Location = new System.Drawing.Point(3, 33);
            this.menu_bar.Name = "menu_bar";
            this.menu_bar.Size = new System.Drawing.Size(465, 720);
            this.menu_bar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu_bar.TabIndex = 4;
            this.menu_bar.TabStop = false;
            // 
            // exit_button
            // 
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.Image = ((System.Drawing.Image)(resources.GetObject("exit_button.Image")));
            this.exit_button.Location = new System.Drawing.Point(663, 417);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(383, 138);
            this.exit_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit_button.TabIndex = 3;
            this.exit_button.TabStop = false;
            this.exit_button.Click += new System.EventHandler(this.Exit_buttonClick);
            this.exit_button.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.exit_button.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // meniu_button
            // 
            this.meniu_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.meniu_button.Image = ((System.Drawing.Image)(resources.GetObject("meniu_button.Image")));
            this.meniu_button.Location = new System.Drawing.Point(663, 254);
            this.meniu_button.Name = "meniu_button";
            this.meniu_button.Size = new System.Drawing.Size(374, 144);
            this.meniu_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meniu_button.TabIndex = 2;
            this.meniu_button.TabStop = false;
            this.meniu_button.Click += new System.EventHandler(this.Meniu_buttonClick);
            this.meniu_button.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.meniu_button.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // play_button
            // 
            this.play_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_button.Image = ((System.Drawing.Image)(resources.GetObject("play_button.Image")));
            this.play_button.Location = new System.Drawing.Point(755, 76);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(374, 132);
            this.play_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.play_button.TabIndex = 1;
            this.play_button.TabStop = false;
            this.play_button.Click += new System.EventHandler(this.Play_buttonClick);
            this.play_button.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.play_button.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // logo_menu
            // 
            this.logo_menu.Image = ((System.Drawing.Image)(resources.GetObject("logo_menu.Image")));
            this.logo_menu.Location = new System.Drawing.Point(96, 76);
            this.logo_menu.Name = "logo_menu";
            this.logo_menu.Size = new System.Drawing.Size(570, 541);
            this.logo_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_menu.TabIndex = 0;
            this.logo_menu.TabStop = false;
            // 
            // _temp
            // 
            this._temp.AutoSize = true;
            this._temp.Location = new System.Drawing.Point(2000, -100);
            this._temp.Name = "_temp";
            this._temp.Size = new System.Drawing.Size(36, 13);
            this._temp.TabIndex = 12;
            this._temp.Text = "_temp";
            this._temp.TextChanged += new System.EventHandler(this._temp_TextChanged);
            // 
            // admin_button
            // 
            this.admin_button.Location = new System.Drawing.Point(84, 28);
            this.admin_button.Name = "admin_button";
            this.admin_button.Size = new System.Drawing.Size(75, 23);
            this.admin_button.TabIndex = 10;
            this.admin_button.Text = "Admin";
            this.admin_button.UseVisualStyleBackColor = true;
            this.admin_button.Visible = false;
            this.admin_button.Click += new System.EventHandler(this.admin_button_Click);
            this.admin_button.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.admin_button.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // delogare_button
            // 
            this.delogare_button.Location = new System.Drawing.Point(3, 28);
            this.delogare_button.Name = "delogare_button";
            this.delogare_button.Size = new System.Drawing.Size(75, 23);
            this.delogare_button.TabIndex = 10;
            this.delogare_button.Text = "Delogare";
            this.delogare_button.UseVisualStyleBackColor = true;
            this.delogare_button.Visible = false;
            this.delogare_button.Click += new System.EventHandler(this.delogare_button_Click);
            this.delogare_button.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.delogare_button.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // logare_button
            // 
            this.logare_button.Location = new System.Drawing.Point(3, 3);
            this.logare_button.Name = "logare_button";
            this.logare_button.Size = new System.Drawing.Size(75, 23);
            this.logare_button.TabIndex = 9;
            this.logare_button.Text = "Logare";
            this.logare_button.UseVisualStyleBackColor = true;
            this.logare_button.Click += new System.EventHandler(this.logare_button_Click);
            this.logare_button.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.logare_button.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(3, 4);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(169, 18);
            this.username_label.TabIndex = 11;
            this.username_label.Text = "Logat ca: g_alex (admin)";
            this.username_label.Visible = false;
            // 
            // credits
            // 
            this.credits.Dock = System.Windows.Forms.DockStyle.Right;
            this.credits.Location = new System.Drawing.Point(0, 0);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(1921, 1057);
            this.credits.TabIndex = 8;
            this.credits.Text = "Realizat de Celcinschi Alexei P-1932\r\n02-t pe GitHub";
            this.credits.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PlayPanel
            // 
            this.PlayPanel.BackColor = System.Drawing.Color.DarkGray;
            this.PlayPanel.Controls.Add(this.Go);
            this.PlayPanel.Controls.Add(this.songSelect1);
            this.PlayPanel.Controls.Add(this.back_button);
            this.PlayPanel.Location = new System.Drawing.Point(290, 3);
            this.PlayPanel.Name = "PlayPanel";
            this.PlayPanel.Size = new System.Drawing.Size(1322, 687);
            this.PlayPanel.TabIndex = 1;
            this.PlayPanel.Visible = false;
            // 
            // Go
            // 
            this.Go.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Go.Image = ((System.Drawing.Image)(resources.GetObject("Go.Image")));
            this.Go.Location = new System.Drawing.Point(606, -3);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(244, 133);
            this.Go.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Go.TabIndex = 2;
            this.Go.TabStop = false;
            this.Go.Click += new System.EventHandler(this.PlaySong_Click);
            this.Go.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.Go.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // songSelect1
            // 
            this.songSelect1.Location = new System.Drawing.Point(140, 148);
            this.songSelect1.Name = "songSelect1";
            this.songSelect1.Size = new System.Drawing.Size(819, 536);
            this.songSelect1.TabIndex = 1;
            // 
            // back_button
            // 
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.Image = ((System.Drawing.Image)(resources.GetObject("back_button.Image")));
            this.back_button.Location = new System.Drawing.Point(34, 23);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(319, 119);
            this.back_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_button.TabIndex = 0;
            this.back_button.TabStop = false;
            this.back_button.Click += new System.EventHandler(this.Back_buttonClick);
            this.back_button.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.back_button.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // GameplayPanel
            // 
            this.GameplayPanel.BackColor = System.Drawing.Color.Black;
            this.GameplayPanel.Controls.Add(this.chart_line);
            this.GameplayPanel.Controls.Add(this.miss_count_label);
            this.GameplayPanel.Controls.Add(this.max_combo_label);
            this.GameplayPanel.Controls.Add(this.combo_label);
            this.GameplayPanel.Controls.Add(this.chart4);
            this.GameplayPanel.Controls.Add(this.chart3);
            this.GameplayPanel.Controls.Add(this.chart2);
            this.GameplayPanel.Controls.Add(this.chart1);
            this.GameplayPanel.Controls.Add(this.chart_bg1);
            this.GameplayPanel.Controls.Add(this.back_button2);
            this.GameplayPanel.Location = new System.Drawing.Point(158, 6);
            this.GameplayPanel.Name = "GameplayPanel";
            this.GameplayPanel.Size = new System.Drawing.Size(1169, 688);
            this.GameplayPanel.TabIndex = 2;
            this.GameplayPanel.Visible = false;
            // 
            // chart_line
            // 
            this.chart_line.BackColor = System.Drawing.Color.DarkGreen;
            this.chart_line.Location = new System.Drawing.Point(233, 600);
            this.chart_line.Name = "chart_line";
            this.chart_line.Size = new System.Drawing.Size(739, 2);
            this.chart_line.TabIndex = 6;
            this.chart_line.TabStop = false;
            // 
            // miss_count_label
            // 
            this.miss_count_label.AutoSize = true;
            this.miss_count_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miss_count_label.ForeColor = System.Drawing.Color.Crimson;
            this.miss_count_label.Location = new System.Drawing.Point(3, 600);
            this.miss_count_label.MinimumSize = new System.Drawing.Size(300, 0);
            this.miss_count_label.Name = "miss_count_label";
            this.miss_count_label.Size = new System.Drawing.Size(300, 42);
            this.miss_count_label.TabIndex = 9;
            this.miss_count_label.Text = "0";
            this.miss_count_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max_combo_label
            // 
            this.max_combo_label.AutoSize = true;
            this.max_combo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_combo_label.ForeColor = System.Drawing.Color.Orange;
            this.max_combo_label.Location = new System.Drawing.Point(3, 513);
            this.max_combo_label.MinimumSize = new System.Drawing.Size(300, 0);
            this.max_combo_label.Name = "max_combo_label";
            this.max_combo_label.Size = new System.Drawing.Size(300, 42);
            this.max_combo_label.TabIndex = 8;
            this.max_combo_label.Text = "0";
            this.max_combo_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_label
            // 
            this.combo_label.AutoSize = true;
            this.combo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_label.ForeColor = System.Drawing.Color.Snow;
            this.combo_label.Location = new System.Drawing.Point(3, 405);
            this.combo_label.MinimumSize = new System.Drawing.Size(300, 0);
            this.combo_label.Name = "combo_label";
            this.combo_label.Size = new System.Drawing.Size(300, 108);
            this.combo_label.TabIndex = 7;
            this.combo_label.Text = "0x";
            this.combo_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart4
            // 
            this.chart4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.chart4.Controls.Add(this.chart4_key);
            this.chart4.Controls.Add(this.chart4circle10);
            this.chart4.Controls.Add(this.chart4circle9);
            this.chart4.Controls.Add(this.chart4circle8);
            this.chart4.Controls.Add(this.chart4circle7);
            this.chart4.Controls.Add(this.chart4circle6);
            this.chart4.Controls.Add(this.chart4circle5);
            this.chart4.Controls.Add(this.chart4circle4);
            this.chart4.Controls.Add(this.chart4circle3);
            this.chart4.Controls.Add(this.chart4circle2);
            this.chart4.Controls.Add(this.chart4circle1);
            this.chart4.Location = new System.Drawing.Point(789, 0);
            this.chart4.Name = "chart4";
            this.chart4.Size = new System.Drawing.Size(147, 688);
            this.chart4.TabIndex = 4;
            // 
            // chart4_key
            // 
            this.chart4_key.AutoSize = true;
            this.chart4_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chart4_key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chart4_key.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart4_key.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chart4_key.Location = new System.Drawing.Point(57, 389);
            this.chart4_key.MaximumSize = new System.Drawing.Size(42, 42);
            this.chart4_key.MinimumSize = new System.Drawing.Size(42, 42);
            this.chart4_key.Name = "chart4_key";
            this.chart4_key.Size = new System.Drawing.Size(42, 42);
            this.chart4_key.TabIndex = 29;
            this.chart4_key.Text = "L";
            this.chart4_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart4circle10
            // 
            this.chart4circle10.Image = ((System.Drawing.Image)(resources.GetObject("chart4circle10.Image")));
            this.chart4circle10.Location = new System.Drawing.Point(-150, 0);
            this.chart4circle10.Name = "chart4circle10";
            this.chart4circle10.Size = new System.Drawing.Size(147, 130);
            this.chart4circle10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart4circle10.TabIndex = 18;
            this.chart4circle10.TabStop = false;
            // 
            // chart4circle9
            // 
            this.chart4circle9.Image = ((System.Drawing.Image)(resources.GetObject("chart4circle9.Image")));
            this.chart4circle9.Location = new System.Drawing.Point(-150, 0);
            this.chart4circle9.Name = "chart4circle9";
            this.chart4circle9.Size = new System.Drawing.Size(147, 130);
            this.chart4circle9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart4circle9.TabIndex = 17;
            this.chart4circle9.TabStop = false;
            // 
            // chart4circle8
            // 
            this.chart4circle8.Image = ((System.Drawing.Image)(resources.GetObject("chart4circle8.Image")));
            this.chart4circle8.Location = new System.Drawing.Point(-150, 0);
            this.chart4circle8.Name = "chart4circle8";
            this.chart4circle8.Size = new System.Drawing.Size(147, 130);
            this.chart4circle8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart4circle8.TabIndex = 16;
            this.chart4circle8.TabStop = false;
            // 
            // chart4circle7
            // 
            this.chart4circle7.Image = ((System.Drawing.Image)(resources.GetObject("chart4circle7.Image")));
            this.chart4circle7.Location = new System.Drawing.Point(-150, 0);
            this.chart4circle7.Name = "chart4circle7";
            this.chart4circle7.Size = new System.Drawing.Size(147, 130);
            this.chart4circle7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart4circle7.TabIndex = 15;
            this.chart4circle7.TabStop = false;
            // 
            // chart4circle6
            // 
            this.chart4circle6.Image = ((System.Drawing.Image)(resources.GetObject("chart4circle6.Image")));
            this.chart4circle6.Location = new System.Drawing.Point(-150, 0);
            this.chart4circle6.Name = "chart4circle6";
            this.chart4circle6.Size = new System.Drawing.Size(147, 130);
            this.chart4circle6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart4circle6.TabIndex = 14;
            this.chart4circle6.TabStop = false;
            // 
            // chart4circle5
            // 
            this.chart4circle5.Image = ((System.Drawing.Image)(resources.GetObject("chart4circle5.Image")));
            this.chart4circle5.Location = new System.Drawing.Point(-150, 0);
            this.chart4circle5.Name = "chart4circle5";
            this.chart4circle5.Size = new System.Drawing.Size(147, 130);
            this.chart4circle5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart4circle5.TabIndex = 13;
            this.chart4circle5.TabStop = false;
            // 
            // chart4circle4
            // 
            this.chart4circle4.Image = ((System.Drawing.Image)(resources.GetObject("chart4circle4.Image")));
            this.chart4circle4.Location = new System.Drawing.Point(-150, 0);
            this.chart4circle4.Name = "chart4circle4";
            this.chart4circle4.Size = new System.Drawing.Size(147, 130);
            this.chart4circle4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart4circle4.TabIndex = 12;
            this.chart4circle4.TabStop = false;
            // 
            // chart4circle3
            // 
            this.chart4circle3.Image = ((System.Drawing.Image)(resources.GetObject("chart4circle3.Image")));
            this.chart4circle3.Location = new System.Drawing.Point(-150, 0);
            this.chart4circle3.Name = "chart4circle3";
            this.chart4circle3.Size = new System.Drawing.Size(147, 130);
            this.chart4circle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart4circle3.TabIndex = 11;
            this.chart4circle3.TabStop = false;
            // 
            // chart4circle2
            // 
            this.chart4circle2.Image = ((System.Drawing.Image)(resources.GetObject("chart4circle2.Image")));
            this.chart4circle2.Location = new System.Drawing.Point(-150, 0);
            this.chart4circle2.Name = "chart4circle2";
            this.chart4circle2.Size = new System.Drawing.Size(147, 130);
            this.chart4circle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart4circle2.TabIndex = 10;
            this.chart4circle2.TabStop = false;
            // 
            // chart4circle1
            // 
            this.chart4circle1.Image = ((System.Drawing.Image)(resources.GetObject("chart4circle1.Image")));
            this.chart4circle1.Location = new System.Drawing.Point(-150, 0);
            this.chart4circle1.Name = "chart4circle1";
            this.chart4circle1.Size = new System.Drawing.Size(147, 130);
            this.chart4circle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart4circle1.TabIndex = 10;
            this.chart4circle1.TabStop = false;
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.chart3.Controls.Add(this.chart3_key);
            this.chart3.Controls.Add(this.chart3circle10);
            this.chart3.Controls.Add(this.chart3circle2);
            this.chart3.Controls.Add(this.chart3circle8);
            this.chart3.Controls.Add(this.chart3circle1);
            this.chart3.Controls.Add(this.chart3circle9);
            this.chart3.Controls.Add(this.chart3circle3);
            this.chart3.Controls.Add(this.chart3circle6);
            this.chart3.Controls.Add(this.chart3circle4);
            this.chart3.Controls.Add(this.chart3circle7);
            this.chart3.Controls.Add(this.chart3circle5);
            this.chart3.Location = new System.Drawing.Point(636, 0);
            this.chart3.Name = "chart3";
            this.chart3.Size = new System.Drawing.Size(147, 688);
            this.chart3.TabIndex = 3;
            // 
            // chart3_key
            // 
            this.chart3_key.AutoSize = true;
            this.chart3_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chart3_key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chart3_key.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart3_key.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chart3_key.Location = new System.Drawing.Point(55, 389);
            this.chart3_key.MaximumSize = new System.Drawing.Size(42, 42);
            this.chart3_key.MinimumSize = new System.Drawing.Size(42, 42);
            this.chart3_key.Name = "chart3_key";
            this.chart3_key.Size = new System.Drawing.Size(42, 42);
            this.chart3_key.TabIndex = 20;
            this.chart3_key.Text = "K";
            this.chart3_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart3circle10
            // 
            this.chart3circle10.Image = ((System.Drawing.Image)(resources.GetObject("chart3circle10.Image")));
            this.chart3circle10.Location = new System.Drawing.Point(-150, 0);
            this.chart3circle10.Name = "chart3circle10";
            this.chart3circle10.Size = new System.Drawing.Size(147, 130);
            this.chart3circle10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart3circle10.TabIndex = 28;
            this.chart3circle10.TabStop = false;
            // 
            // chart3circle2
            // 
            this.chart3circle2.Image = ((System.Drawing.Image)(resources.GetObject("chart3circle2.Image")));
            this.chart3circle2.Location = new System.Drawing.Point(-150, 0);
            this.chart3circle2.Name = "chart3circle2";
            this.chart3circle2.Size = new System.Drawing.Size(147, 130);
            this.chart3circle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart3circle2.TabIndex = 20;
            this.chart3circle2.TabStop = false;
            // 
            // chart3circle8
            // 
            this.chart3circle8.Image = ((System.Drawing.Image)(resources.GetObject("chart3circle8.Image")));
            this.chart3circle8.Location = new System.Drawing.Point(-150, 0);
            this.chart3circle8.Name = "chart3circle8";
            this.chart3circle8.Size = new System.Drawing.Size(147, 130);
            this.chart3circle8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart3circle8.TabIndex = 27;
            this.chart3circle8.TabStop = false;
            // 
            // chart3circle1
            // 
            this.chart3circle1.Image = ((System.Drawing.Image)(resources.GetObject("chart3circle1.Image")));
            this.chart3circle1.Location = new System.Drawing.Point(-150, 0);
            this.chart3circle1.Name = "chart3circle1";
            this.chart3circle1.Size = new System.Drawing.Size(147, 130);
            this.chart3circle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart3circle1.TabIndex = 20;
            this.chart3circle1.TabStop = false;
            // 
            // chart3circle9
            // 
            this.chart3circle9.Image = ((System.Drawing.Image)(resources.GetObject("chart3circle9.Image")));
            this.chart3circle9.Location = new System.Drawing.Point(-150, 0);
            this.chart3circle9.Name = "chart3circle9";
            this.chart3circle9.Size = new System.Drawing.Size(147, 130);
            this.chart3circle9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart3circle9.TabIndex = 26;
            this.chart3circle9.TabStop = false;
            // 
            // chart3circle3
            // 
            this.chart3circle3.Image = ((System.Drawing.Image)(resources.GetObject("chart3circle3.Image")));
            this.chart3circle3.Location = new System.Drawing.Point(-150, 0);
            this.chart3circle3.Name = "chart3circle3";
            this.chart3circle3.Size = new System.Drawing.Size(147, 130);
            this.chart3circle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart3circle3.TabIndex = 21;
            this.chart3circle3.TabStop = false;
            // 
            // chart3circle6
            // 
            this.chart3circle6.Image = ((System.Drawing.Image)(resources.GetObject("chart3circle6.Image")));
            this.chart3circle6.Location = new System.Drawing.Point(-150, 0);
            this.chart3circle6.Name = "chart3circle6";
            this.chart3circle6.Size = new System.Drawing.Size(141, 130);
            this.chart3circle6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart3circle6.TabIndex = 25;
            this.chart3circle6.TabStop = false;
            // 
            // chart3circle4
            // 
            this.chart3circle4.Image = ((System.Drawing.Image)(resources.GetObject("chart3circle4.Image")));
            this.chart3circle4.Location = new System.Drawing.Point(-150, 0);
            this.chart3circle4.Name = "chart3circle4";
            this.chart3circle4.Size = new System.Drawing.Size(147, 130);
            this.chart3circle4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart3circle4.TabIndex = 22;
            this.chart3circle4.TabStop = false;
            // 
            // chart3circle7
            // 
            this.chart3circle7.Image = ((System.Drawing.Image)(resources.GetObject("chart3circle7.Image")));
            this.chart3circle7.Location = new System.Drawing.Point(-150, 0);
            this.chart3circle7.Name = "chart3circle7";
            this.chart3circle7.Size = new System.Drawing.Size(147, 130);
            this.chart3circle7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart3circle7.TabIndex = 24;
            this.chart3circle7.TabStop = false;
            // 
            // chart3circle5
            // 
            this.chart3circle5.Image = ((System.Drawing.Image)(resources.GetObject("chart3circle5.Image")));
            this.chart3circle5.Location = new System.Drawing.Point(-150, 0);
            this.chart3circle5.Name = "chart3circle5";
            this.chart3circle5.Size = new System.Drawing.Size(147, 130);
            this.chart3circle5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart3circle5.TabIndex = 23;
            this.chart3circle5.TabStop = false;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.chart2.Controls.Add(this.chart2circle10);
            this.chart2.Controls.Add(this.chart2_key);
            this.chart2.Controls.Add(this.chart2circle9);
            this.chart2.Controls.Add(this.chart2circle8);
            this.chart2.Controls.Add(this.chart2circle7);
            this.chart2.Controls.Add(this.chart2circle6);
            this.chart2.Controls.Add(this.chart2circle5);
            this.chart2.Controls.Add(this.chart2circle4);
            this.chart2.Controls.Add(this.chart2circle3);
            this.chart2.Controls.Add(this.chart2circle2);
            this.chart2.Controls.Add(this.chart2circle1);
            this.chart2.Location = new System.Drawing.Point(483, 0);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(147, 688);
            this.chart2.TabIndex = 2;
            // 
            // chart2circle10
            // 
            this.chart2circle10.Image = ((System.Drawing.Image)(resources.GetObject("chart2circle10.Image")));
            this.chart2circle10.Location = new System.Drawing.Point(-150, 0);
            this.chart2circle10.Name = "chart2circle10";
            this.chart2circle10.Size = new System.Drawing.Size(147, 130);
            this.chart2circle10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart2circle10.TabIndex = 19;
            this.chart2circle10.TabStop = false;
            // 
            // chart2_key
            // 
            this.chart2_key.AutoSize = true;
            this.chart2_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chart2_key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chart2_key.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart2_key.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chart2_key.Location = new System.Drawing.Point(51, 389);
            this.chart2_key.MaximumSize = new System.Drawing.Size(42, 42);
            this.chart2_key.MinimumSize = new System.Drawing.Size(42, 42);
            this.chart2_key.Name = "chart2_key";
            this.chart2_key.Size = new System.Drawing.Size(42, 42);
            this.chart2_key.TabIndex = 11;
            this.chart2_key.Text = "D";
            this.chart2_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart2circle9
            // 
            this.chart2circle9.Image = ((System.Drawing.Image)(resources.GetObject("chart2circle9.Image")));
            this.chart2circle9.Location = new System.Drawing.Point(-150, 0);
            this.chart2circle9.Name = "chart2circle9";
            this.chart2circle9.Size = new System.Drawing.Size(147, 130);
            this.chart2circle9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart2circle9.TabIndex = 18;
            this.chart2circle9.TabStop = false;
            // 
            // chart2circle8
            // 
            this.chart2circle8.Image = ((System.Drawing.Image)(resources.GetObject("chart2circle8.Image")));
            this.chart2circle8.Location = new System.Drawing.Point(-150, 0);
            this.chart2circle8.Name = "chart2circle8";
            this.chart2circle8.Size = new System.Drawing.Size(147, 130);
            this.chart2circle8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart2circle8.TabIndex = 17;
            this.chart2circle8.TabStop = false;
            // 
            // chart2circle7
            // 
            this.chart2circle7.Image = ((System.Drawing.Image)(resources.GetObject("chart2circle7.Image")));
            this.chart2circle7.Location = new System.Drawing.Point(-150, 0);
            this.chart2circle7.Name = "chart2circle7";
            this.chart2circle7.Size = new System.Drawing.Size(147, 130);
            this.chart2circle7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart2circle7.TabIndex = 16;
            this.chart2circle7.TabStop = false;
            // 
            // chart2circle6
            // 
            this.chart2circle6.Image = ((System.Drawing.Image)(resources.GetObject("chart2circle6.Image")));
            this.chart2circle6.Location = new System.Drawing.Point(-150, 0);
            this.chart2circle6.Name = "chart2circle6";
            this.chart2circle6.Size = new System.Drawing.Size(147, 130);
            this.chart2circle6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart2circle6.TabIndex = 15;
            this.chart2circle6.TabStop = false;
            // 
            // chart2circle5
            // 
            this.chart2circle5.Image = ((System.Drawing.Image)(resources.GetObject("chart2circle5.Image")));
            this.chart2circle5.Location = new System.Drawing.Point(-150, 0);
            this.chart2circle5.Name = "chart2circle5";
            this.chart2circle5.Size = new System.Drawing.Size(147, 130);
            this.chart2circle5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart2circle5.TabIndex = 14;
            this.chart2circle5.TabStop = false;
            // 
            // chart2circle4
            // 
            this.chart2circle4.Image = ((System.Drawing.Image)(resources.GetObject("chart2circle4.Image")));
            this.chart2circle4.Location = new System.Drawing.Point(-150, 0);
            this.chart2circle4.Name = "chart2circle4";
            this.chart2circle4.Size = new System.Drawing.Size(147, 130);
            this.chart2circle4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart2circle4.TabIndex = 13;
            this.chart2circle4.TabStop = false;
            // 
            // chart2circle3
            // 
            this.chart2circle3.Image = ((System.Drawing.Image)(resources.GetObject("chart2circle3.Image")));
            this.chart2circle3.Location = new System.Drawing.Point(-150, 0);
            this.chart2circle3.Name = "chart2circle3";
            this.chart2circle3.Size = new System.Drawing.Size(147, 130);
            this.chart2circle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart2circle3.TabIndex = 12;
            this.chart2circle3.TabStop = false;
            // 
            // chart2circle2
            // 
            this.chart2circle2.Image = ((System.Drawing.Image)(resources.GetObject("chart2circle2.Image")));
            this.chart2circle2.Location = new System.Drawing.Point(-150, 0);
            this.chart2circle2.Name = "chart2circle2";
            this.chart2circle2.Size = new System.Drawing.Size(147, 130);
            this.chart2circle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart2circle2.TabIndex = 11;
            this.chart2circle2.TabStop = false;
            // 
            // chart2circle1
            // 
            this.chart2circle1.Image = global::ceiti_mania.Properties.Resources.circle6;
            this.chart2circle1.Location = new System.Drawing.Point(-150, 0);
            this.chart2circle1.Name = "chart2circle1";
            this.chart2circle1.Size = new System.Drawing.Size(147, 130);
            this.chart2circle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart2circle1.TabIndex = 10;
            this.chart2circle1.TabStop = false;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.chart1.Controls.Add(this.chart1circle10);
            this.chart1.Controls.Add(this.chart1_key);
            this.chart1.Controls.Add(this.chart1circle9);
            this.chart1.Controls.Add(this.chart1circle8);
            this.chart1.Controls.Add(this.chart1circle7);
            this.chart1.Controls.Add(this.chart1circle6);
            this.chart1.Controls.Add(this.chart1circle5);
            this.chart1.Controls.Add(this.chart1circle4);
            this.chart1.Controls.Add(this.chart1circle3);
            this.chart1.Controls.Add(this.chart1circle2);
            this.chart1.Controls.Add(this.chart1circle1);
            this.chart1.Location = new System.Drawing.Point(330, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(147, 688);
            this.chart1.TabIndex = 1;
            // 
            // chart1circle10
            // 
            this.chart1circle10.Image = ((System.Drawing.Image)(resources.GetObject("chart1circle10.Image")));
            this.chart1circle10.Location = new System.Drawing.Point(-150, 0);
            this.chart1circle10.Name = "chart1circle10";
            this.chart1circle10.Size = new System.Drawing.Size(147, 130);
            this.chart1circle10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart1circle10.TabIndex = 9;
            this.chart1circle10.TabStop = false;
            // 
            // chart1_key
            // 
            this.chart1_key.AutoSize = true;
            this.chart1_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chart1_key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chart1_key.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart1_key.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chart1_key.Location = new System.Drawing.Point(41, 389);
            this.chart1_key.MaximumSize = new System.Drawing.Size(42, 42);
            this.chart1_key.MinimumSize = new System.Drawing.Size(42, 42);
            this.chart1_key.Name = "chart1_key";
            this.chart1_key.Size = new System.Drawing.Size(42, 42);
            this.chart1_key.TabIndex = 10;
            this.chart1_key.Text = "S";
            this.chart1_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1circle9
            // 
            this.chart1circle9.Image = ((System.Drawing.Image)(resources.GetObject("chart1circle9.Image")));
            this.chart1circle9.Location = new System.Drawing.Point(-150, 0);
            this.chart1circle9.Name = "chart1circle9";
            this.chart1circle9.Size = new System.Drawing.Size(147, 130);
            this.chart1circle9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart1circle9.TabIndex = 8;
            this.chart1circle9.TabStop = false;
            // 
            // chart1circle8
            // 
            this.chart1circle8.Image = ((System.Drawing.Image)(resources.GetObject("chart1circle8.Image")));
            this.chart1circle8.Location = new System.Drawing.Point(-150, 0);
            this.chart1circle8.Name = "chart1circle8";
            this.chart1circle8.Size = new System.Drawing.Size(147, 130);
            this.chart1circle8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart1circle8.TabIndex = 7;
            this.chart1circle8.TabStop = false;
            // 
            // chart1circle7
            // 
            this.chart1circle7.Image = ((System.Drawing.Image)(resources.GetObject("chart1circle7.Image")));
            this.chart1circle7.Location = new System.Drawing.Point(-150, 0);
            this.chart1circle7.Name = "chart1circle7";
            this.chart1circle7.Size = new System.Drawing.Size(147, 130);
            this.chart1circle7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart1circle7.TabIndex = 6;
            this.chart1circle7.TabStop = false;
            // 
            // chart1circle6
            // 
            this.chart1circle6.Image = ((System.Drawing.Image)(resources.GetObject("chart1circle6.Image")));
            this.chart1circle6.Location = new System.Drawing.Point(-150, 0);
            this.chart1circle6.Name = "chart1circle6";
            this.chart1circle6.Size = new System.Drawing.Size(147, 130);
            this.chart1circle6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart1circle6.TabIndex = 5;
            this.chart1circle6.TabStop = false;
            // 
            // chart1circle5
            // 
            this.chart1circle5.Image = ((System.Drawing.Image)(resources.GetObject("chart1circle5.Image")));
            this.chart1circle5.Location = new System.Drawing.Point(-150, 0);
            this.chart1circle5.Name = "chart1circle5";
            this.chart1circle5.Size = new System.Drawing.Size(147, 130);
            this.chart1circle5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart1circle5.TabIndex = 4;
            this.chart1circle5.TabStop = false;
            // 
            // chart1circle4
            // 
            this.chart1circle4.Image = ((System.Drawing.Image)(resources.GetObject("chart1circle4.Image")));
            this.chart1circle4.Location = new System.Drawing.Point(-150, 0);
            this.chart1circle4.Name = "chart1circle4";
            this.chart1circle4.Size = new System.Drawing.Size(147, 130);
            this.chart1circle4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart1circle4.TabIndex = 3;
            this.chart1circle4.TabStop = false;
            // 
            // chart1circle3
            // 
            this.chart1circle3.Image = ((System.Drawing.Image)(resources.GetObject("chart1circle3.Image")));
            this.chart1circle3.Location = new System.Drawing.Point(-150, 0);
            this.chart1circle3.Name = "chart1circle3";
            this.chart1circle3.Size = new System.Drawing.Size(147, 130);
            this.chart1circle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart1circle3.TabIndex = 2;
            this.chart1circle3.TabStop = false;
            // 
            // chart1circle2
            // 
            this.chart1circle2.Image = ((System.Drawing.Image)(resources.GetObject("chart1circle2.Image")));
            this.chart1circle2.Location = new System.Drawing.Point(-150, 0);
            this.chart1circle2.Name = "chart1circle2";
            this.chart1circle2.Size = new System.Drawing.Size(147, 130);
            this.chart1circle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart1circle2.TabIndex = 1;
            this.chart1circle2.TabStop = false;
            // 
            // chart1circle1
            // 
            this.chart1circle1.Image = ((System.Drawing.Image)(resources.GetObject("chart1circle1.Image")));
            this.chart1circle1.Location = new System.Drawing.Point(-150, 0);
            this.chart1circle1.Name = "chart1circle1";
            this.chart1circle1.Size = new System.Drawing.Size(147, 130);
            this.chart1circle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart1circle1.TabIndex = 0;
            this.chart1circle1.TabStop = false;
            // 
            // chart_bg1
            // 
            this.chart_bg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(7)))), ((int)(((byte)(23)))));
            this.chart_bg1.Location = new System.Drawing.Point(330, 0);
            this.chart_bg1.Name = "chart_bg1";
            this.chart_bg1.Size = new System.Drawing.Size(606, 688);
            this.chart_bg1.TabIndex = 5;
            this.chart_bg1.TabStop = false;
            // 
            // back_button2
            // 
            this.back_button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button2.Image = ((System.Drawing.Image)(resources.GetObject("back_button2.Image")));
            this.back_button2.Location = new System.Drawing.Point(38, 23);
            this.back_button2.Name = "back_button2";
            this.back_button2.Size = new System.Drawing.Size(100, 50);
            this.back_button2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_button2.TabIndex = 0;
            this.back_button2.TabStop = false;
            this.back_button2.Click += new System.EventHandler(this.back2_Click);
            this.back_button2.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.back_button2.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EndPanel
            // 
            this.EndPanel.Controls.Add(this.retry_button);
            this.EndPanel.Controls.Add(this.back_button3);
            this.EndPanel.Controls.Add(this.end_max_combo_label);
            this.EndPanel.Controls.Add(this.end_miss_label);
            this.EndPanel.Controls.Add(this.end_combo_label);
            this.EndPanel.Controls.Add(this.end_nota);
            this.EndPanel.Controls.Add(this.felicitari_img);
            this.EndPanel.Location = new System.Drawing.Point(49, 3);
            this.EndPanel.Name = "EndPanel";
            this.EndPanel.Size = new System.Drawing.Size(1200, 663);
            this.EndPanel.TabIndex = 3;
            this.EndPanel.Visible = false;
            // 
            // retry_button
            // 
            this.retry_button.Image = ((System.Drawing.Image)(resources.GetObject("retry_button.Image")));
            this.retry_button.Location = new System.Drawing.Point(753, 534);
            this.retry_button.Name = "retry_button";
            this.retry_button.Size = new System.Drawing.Size(328, 111);
            this.retry_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.retry_button.TabIndex = 6;
            this.retry_button.TabStop = false;
            this.retry_button.Click += new System.EventHandler(this.retry_button_Click);
            this.retry_button.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.retry_button.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // back_button3
            // 
            this.back_button3.Image = ((System.Drawing.Image)(resources.GetObject("back_button3.Image")));
            this.back_button3.Location = new System.Drawing.Point(147, 534);
            this.back_button3.Name = "back_button3";
            this.back_button3.Size = new System.Drawing.Size(325, 111);
            this.back_button3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_button3.TabIndex = 5;
            this.back_button3.TabStop = false;
            this.back_button3.Click += new System.EventHandler(this.back_button3_Click);
            this.back_button3.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.back_button3.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // end_max_combo_label
            // 
            this.end_max_combo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_max_combo_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(88)))), ((int)(((byte)(26)))));
            this.end_max_combo_label.Location = new System.Drawing.Point(0, 389);
            this.end_max_combo_label.Name = "end_max_combo_label";
            this.end_max_combo_label.Size = new System.Drawing.Size(1200, 67);
            this.end_max_combo_label.TabIndex = 4;
            this.end_max_combo_label.Text = "Max combo: 250x";
            this.end_max_combo_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // end_miss_label
            // 
            this.end_miss_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_miss_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            this.end_miss_label.Location = new System.Drawing.Point(0, 456);
            this.end_miss_label.Name = "end_miss_label";
            this.end_miss_label.Size = new System.Drawing.Size(1200, 67);
            this.end_miss_label.TabIndex = 3;
            this.end_miss_label.Text = "Ratări: 20";
            this.end_miss_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // end_combo_label
            // 
            this.end_combo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_combo_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(88)))), ((int)(((byte)(26)))));
            this.end_combo_label.Location = new System.Drawing.Point(0, 322);
            this.end_combo_label.Name = "end_combo_label";
            this.end_combo_label.Size = new System.Drawing.Size(1200, 67);
            this.end_combo_label.TabIndex = 2;
            this.end_combo_label.Text = "Combo: 250x";
            this.end_combo_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // end_nota
            // 
            this.end_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_nota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.end_nota.Location = new System.Drawing.Point(3, 202);
            this.end_nota.Name = "end_nota";
            this.end_nota.Size = new System.Drawing.Size(1200, 95);
            this.end_nota.TabIndex = 1;
            this.end_nota.Text = "Nota: 10";
            this.end_nota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // felicitari_img
            // 
            this.felicitari_img.Image = ((System.Drawing.Image)(resources.GetObject("felicitari_img.Image")));
            this.felicitari_img.Location = new System.Drawing.Point(0, 0);
            this.felicitari_img.Name = "felicitari_img";
            this.felicitari_img.Size = new System.Drawing.Size(1200, 174);
            this.felicitari_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.felicitari_img.TabIndex = 0;
            this.felicitari_img.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.EndPanel);
            this.Controls.Add(this.GameplayPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.PlayPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ceiti!mania";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.SizeChanged += new System.EventHandler(this.MainForm_Resize);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restart_label)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.low_detail_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.low_detail_on)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullscreen_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullscreen_on)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muzica_on)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunet_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunet_on)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muzica_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meniu_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_menu)).EndInit();
            this.PlayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Go)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).EndInit();
            this.GameplayPanel.ResumeLayout(false);
            this.GameplayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_line)).EndInit();
            this.chart4.ResumeLayout(false);
            this.chart4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4circle10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4circle9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4circle8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4circle7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4circle6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4circle5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4circle4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4circle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4circle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4circle1)).EndInit();
            this.chart3.ResumeLayout(false);
            this.chart3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3circle10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3circle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3circle8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3circle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3circle9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3circle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3circle6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3circle4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3circle7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3circle5)).EndInit();
            this.chart2.ResumeLayout(false);
            this.chart2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2circle10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2circle9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2circle8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2circle7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2circle6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2circle5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2circle4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2circle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2circle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2circle1)).EndInit();
            this.chart1.ResumeLayout(false);
            this.chart1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1circle10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1circle9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1circle8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1circle7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1circle6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1circle5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1circle4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1circle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1circle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1circle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_bg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button2)).EndInit();
            this.EndPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.retry_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.felicitari_img)).EndInit();
            this.ResumeLayout(false);

		}

        private SongSelect songSelect1;
        private System.Windows.Forms.PictureBox Go;
        private System.Windows.Forms.Panel GameplayPanel;
        private System.Windows.Forms.PictureBox back_button2;
        private System.Windows.Forms.PictureBox chart_line;
        private System.Windows.Forms.Panel chart4;
        private System.Windows.Forms.PictureBox chart4circle10;
        private System.Windows.Forms.PictureBox chart4circle9;
        private System.Windows.Forms.PictureBox chart4circle8;
        private System.Windows.Forms.PictureBox chart4circle7;
        private System.Windows.Forms.PictureBox chart4circle6;
        private System.Windows.Forms.PictureBox chart4circle5;
        private System.Windows.Forms.PictureBox chart4circle4;
        private System.Windows.Forms.PictureBox chart4circle3;
        private System.Windows.Forms.PictureBox chart4circle2;
        private System.Windows.Forms.PictureBox chart4circle1;
        private System.Windows.Forms.Panel chart3;
        private System.Windows.Forms.PictureBox chart3circle10;
        private System.Windows.Forms.PictureBox chart3circle2;
        private System.Windows.Forms.PictureBox chart3circle8;
        private System.Windows.Forms.PictureBox chart3circle1;
        private System.Windows.Forms.PictureBox chart3circle9;
        private System.Windows.Forms.PictureBox chart3circle3;
        private System.Windows.Forms.PictureBox chart3circle6;
        private System.Windows.Forms.PictureBox chart3circle4;
        private System.Windows.Forms.PictureBox chart3circle7;
        private System.Windows.Forms.PictureBox chart3circle5;
        private System.Windows.Forms.Panel chart2;
        private System.Windows.Forms.PictureBox chart2circle10;
        private System.Windows.Forms.PictureBox chart2circle9;
        private System.Windows.Forms.PictureBox chart2circle8;
        private System.Windows.Forms.PictureBox chart2circle7;
        private System.Windows.Forms.PictureBox chart2circle6;
        private System.Windows.Forms.PictureBox chart2circle5;
        private System.Windows.Forms.PictureBox chart2circle4;
        private System.Windows.Forms.PictureBox chart2circle3;
        private System.Windows.Forms.PictureBox chart2circle2;
        private System.Windows.Forms.PictureBox chart2circle1;
        private System.Windows.Forms.Panel chart1;
        private System.Windows.Forms.PictureBox chart1circle10;
        private System.Windows.Forms.PictureBox chart1circle9;
        private System.Windows.Forms.PictureBox chart1circle8;
        private System.Windows.Forms.PictureBox chart1circle7;
        private System.Windows.Forms.PictureBox chart1circle6;
        private System.Windows.Forms.PictureBox chart1circle5;
        private System.Windows.Forms.PictureBox chart1circle4;
        private System.Windows.Forms.PictureBox chart1circle3;
        private System.Windows.Forms.PictureBox chart1circle2;
        private System.Windows.Forms.PictureBox chart1circle1;
        private System.Windows.Forms.PictureBox chart_bg1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label chart1_key;
        private System.Windows.Forms.Label chart4_key;
        private System.Windows.Forms.Label chart3_key;
        private System.Windows.Forms.Label chart2_key;
        private System.Windows.Forms.PictureBox sunet_on;
        private System.Windows.Forms.PictureBox sunet_off;
        private System.Windows.Forms.PictureBox muzica_off;
        private System.Windows.Forms.PictureBox muzica_on;
        private System.Windows.Forms.PictureBox low_detail_off;
        private System.Windows.Forms.PictureBox low_detail_on;
        private System.Windows.Forms.PictureBox restart_label;
        private System.Windows.Forms.Button logare_button;
        private System.Windows.Forms.Button delogare_button;
        private System.Windows.Forms.Button admin_button;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label _temp;
        private System.Windows.Forms.Label miss_count_label;
        private System.Windows.Forms.Label max_combo_label;
        private System.Windows.Forms.Label combo_label;
        private System.Windows.Forms.Panel EndPanel;
        private System.Windows.Forms.PictureBox felicitari_img;
        private System.Windows.Forms.Label end_max_combo_label;
        private System.Windows.Forms.Label end_miss_label;
        private System.Windows.Forms.Label end_combo_label;
        private System.Windows.Forms.Label end_nota;
        private System.Windows.Forms.PictureBox retry_button;
        private System.Windows.Forms.PictureBox back_button3;
    }
}
