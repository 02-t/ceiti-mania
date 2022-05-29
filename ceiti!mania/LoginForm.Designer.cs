namespace ceiti_mania
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.login_panel = new System.Windows.Forms.Panel();
            this.show_pass = new System.Windows.Forms.CheckBox();
            this.remember_acc = new System.Windows.Forms.CheckBox();
            this.go = new System.Windows.Forms.PictureBox();
            this.pass_label = new System.Windows.Forms.Label();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.nume_label = new System.Windows.Forms.Label();
            this.user_box = new System.Windows.Forms.TextBox();
            this.logare_picture = new System.Windows.Forms.PictureBox();
            this.menu_bar = new System.Windows.Forms.PictureBox();
            this.close_button = new System.Windows.Forms.PictureBox();
            this.new_user_panel = new System.Windows.Forms.Panel();
            this.pass_label4 = new System.Windows.Forms.Label();
            this.pass3 = new System.Windows.Forms.Label();
            this.pass_box3 = new System.Windows.Forms.TextBox();
            this.show_pass2 = new System.Windows.Forms.CheckBox();
            this.remember2 = new System.Windows.Forms.CheckBox();
            this.go_new_account = new System.Windows.Forms.PictureBox();
            this.pass2 = new System.Windows.Forms.Label();
            this.pass_box2 = new System.Windows.Forms.TextBox();
            this.user2 = new System.Windows.Forms.Label();
            this.username_box2 = new System.Windows.Forms.TextBox();
            this.new_user_button = new System.Windows.Forms.PictureBox();
            this.login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.go)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logare_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).BeginInit();
            this.new_user_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.go_new_account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_user_button)).BeginInit();
            this.SuspendLayout();
            // 
            // login_panel
            // 
            this.login_panel.Controls.Add(this.show_pass);
            this.login_panel.Controls.Add(this.remember_acc);
            this.login_panel.Controls.Add(this.go);
            this.login_panel.Controls.Add(this.pass_label);
            this.login_panel.Controls.Add(this.pass_box);
            this.login_panel.Controls.Add(this.nume_label);
            this.login_panel.Controls.Add(this.user_box);
            this.login_panel.Controls.Add(this.logare_picture);
            this.login_panel.Location = new System.Drawing.Point(0, 52);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(410, 412);
            this.login_panel.TabIndex = 0;
            // 
            // show_pass
            // 
            this.show_pass.AutoSize = true;
            this.show_pass.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.show_pass.Location = new System.Drawing.Point(64, 260);
            this.show_pass.Name = "show_pass";
            this.show_pass.Size = new System.Drawing.Size(137, 26);
            this.show_pass.TabIndex = 7;
            this.show_pass.Text = "Afișează parola";
            this.show_pass.UseVisualStyleBackColor = true;
            this.show_pass.CheckedChanged += new System.EventHandler(this.show_pass_CheckedChanged);
            // 
            // remember_acc
            // 
            this.remember_acc.AutoSize = true;
            this.remember_acc.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remember_acc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.remember_acc.Location = new System.Drawing.Point(64, 292);
            this.remember_acc.Name = "remember_acc";
            this.remember_acc.Size = new System.Drawing.Size(133, 26);
            this.remember_acc.TabIndex = 6;
            this.remember_acc.Text = "Ține-mă minte";
            this.remember_acc.UseVisualStyleBackColor = true;
            this.remember_acc.CheckedChanged += new System.EventHandler(this.remember_acc_CheckedChanged);
            // 
            // go
            // 
            this.go.Image = ((System.Drawing.Image)(resources.GetObject("go.Image")));
            this.go.Location = new System.Drawing.Point(300, 333);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(123, 76);
            this.go.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.go.TabIndex = 5;
            this.go.TabStop = false;
            this.go.Click += new System.EventHandler(this.go_Click);
            this.go.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.go.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.pass_label.Location = new System.Drawing.Point(59, 193);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(80, 29);
            this.pass_label.TabIndex = 4;
            this.pass_label.Text = "Parola";
            // 
            // pass_box
            // 
            this.pass_box.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_box.Location = new System.Drawing.Point(159, 194);
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(187, 30);
            this.pass_box.TabIndex = 3;
            this.pass_box.UseSystemPasswordChar = true;
            this.pass_box.TextChanged += new System.EventHandler(this.key_sound);
            // 
            // nume_label
            // 
            this.nume_label.AutoSize = true;
            this.nume_label.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.nume_label.Location = new System.Drawing.Point(59, 136);
            this.nume_label.Name = "nume_label";
            this.nume_label.Size = new System.Drawing.Size(94, 29);
            this.nume_label.TabIndex = 2;
            this.nume_label.Text = "Numele";
            // 
            // user_box
            // 
            this.user_box.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_box.Location = new System.Drawing.Point(159, 137);
            this.user_box.Name = "user_box";
            this.user_box.Size = new System.Drawing.Size(187, 30);
            this.user_box.TabIndex = 1;
            this.user_box.TextChanged += new System.EventHandler(this.key_sound);
            // 
            // logare_picture
            // 
            this.logare_picture.Image = ((System.Drawing.Image)(resources.GetObject("logare_picture.Image")));
            this.logare_picture.Location = new System.Drawing.Point(93, 16);
            this.logare_picture.Name = "logare_picture";
            this.logare_picture.Size = new System.Drawing.Size(226, 69);
            this.logare_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logare_picture.TabIndex = 0;
            this.logare_picture.TabStop = false;
            this.logare_picture.Click += new System.EventHandler(this.logare_picture_Click);
            this.logare_picture.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.logare_picture.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // menu_bar
            // 
            this.menu_bar.Image = ((System.Drawing.Image)(resources.GetObject("menu_bar.Image")));
            this.menu_bar.Location = new System.Drawing.Point(0, 0);
            this.menu_bar.Name = "menu_bar";
            this.menu_bar.Size = new System.Drawing.Size(410, 53);
            this.menu_bar.TabIndex = 1;
            this.menu_bar.TabStop = false;
            this.menu_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drag_MouseDown);
            this.menu_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drag_MouseMove);
            this.menu_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drag_MouseUp);
            // 
            // close_button
            // 
            this.close_button.Image = ((System.Drawing.Image)(resources.GetObject("close_button.Image")));
            this.close_button.Location = new System.Drawing.Point(357, 0);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(53, 53);
            this.close_button.TabIndex = 2;
            this.close_button.TabStop = false;
            this.close_button.Click += new System.EventHandler(this.closeForm);
            this.close_button.MouseEnter += new System.EventHandler(this.close_button_MouseEnter);
            this.close_button.MouseLeave += new System.EventHandler(this.close_button_MouseLeave);
            // 
            // new_user_panel
            // 
            this.new_user_panel.Controls.Add(this.pass_label4);
            this.new_user_panel.Controls.Add(this.pass3);
            this.new_user_panel.Controls.Add(this.pass_box3);
            this.new_user_panel.Controls.Add(this.show_pass2);
            this.new_user_panel.Controls.Add(this.remember2);
            this.new_user_panel.Controls.Add(this.go_new_account);
            this.new_user_panel.Controls.Add(this.pass2);
            this.new_user_panel.Controls.Add(this.pass_box2);
            this.new_user_panel.Controls.Add(this.user2);
            this.new_user_panel.Controls.Add(this.username_box2);
            this.new_user_panel.Controls.Add(this.new_user_button);
            this.new_user_panel.Location = new System.Drawing.Point(0, 52);
            this.new_user_panel.Name = "new_user_panel";
            this.new_user_panel.Size = new System.Drawing.Size(410, 412);
            this.new_user_panel.TabIndex = 8;
            this.new_user_panel.Visible = false;
            // 
            // pass_label4
            // 
            this.pass_label4.AutoSize = true;
            this.pass_label4.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.pass_label4.Location = new System.Drawing.Point(130, 248);
            this.pass_label4.Name = "pass_label4";
            this.pass_label4.Size = new System.Drawing.Size(27, 16);
            this.pass_label4.TabIndex = 12;
            this.pass_label4.Text = "(x2)";
            // 
            // pass3
            // 
            this.pass3.AutoSize = true;
            this.pass3.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.pass3.Location = new System.Drawing.Point(59, 233);
            this.pass3.Name = "pass3";
            this.pass3.Size = new System.Drawing.Size(80, 29);
            this.pass3.TabIndex = 11;
            this.pass3.Text = "Parola";
            // 
            // pass_box3
            // 
            this.pass_box3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_box3.Location = new System.Drawing.Point(159, 234);
            this.pass_box3.Name = "pass_box3";
            this.pass_box3.Size = new System.Drawing.Size(187, 30);
            this.pass_box3.TabIndex = 10;
            this.pass_box3.UseSystemPasswordChar = true;
            this.pass_box3.TextChanged += new System.EventHandler(this.key_sound);
            // 
            // show_pass2
            // 
            this.show_pass2.AutoSize = true;
            this.show_pass2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_pass2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.show_pass2.Location = new System.Drawing.Point(64, 292);
            this.show_pass2.Name = "show_pass2";
            this.show_pass2.Size = new System.Drawing.Size(151, 26);
            this.show_pass2.TabIndex = 7;
            this.show_pass2.Text = "Afișează parolele";
            this.show_pass2.UseVisualStyleBackColor = true;
            this.show_pass2.CheckedChanged += new System.EventHandler(this.show_pass2_CheckedChanged);
            // 
            // remember2
            // 
            this.remember2.AutoSize = true;
            this.remember2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remember2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.remember2.Location = new System.Drawing.Point(64, 324);
            this.remember2.Name = "remember2";
            this.remember2.Size = new System.Drawing.Size(133, 26);
            this.remember2.TabIndex = 6;
            this.remember2.Text = "Ține-mă minte";
            this.remember2.UseVisualStyleBackColor = true;
            this.remember2.CheckedChanged += new System.EventHandler(this.remember2_CheckedChanged);
            // 
            // go_new_account
            // 
            this.go_new_account.Image = ((System.Drawing.Image)(resources.GetObject("go_new_account.Image")));
            this.go_new_account.Location = new System.Drawing.Point(300, 333);
            this.go_new_account.Name = "go_new_account";
            this.go_new_account.Size = new System.Drawing.Size(123, 76);
            this.go_new_account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.go_new_account.TabIndex = 5;
            this.go_new_account.TabStop = false;
            this.go_new_account.Click += new System.EventHandler(this.go_new_account_Click);
            this.go_new_account.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.go_new_account.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // pass2
            // 
            this.pass2.AutoSize = true;
            this.pass2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.pass2.Location = new System.Drawing.Point(59, 175);
            this.pass2.Name = "pass2";
            this.pass2.Size = new System.Drawing.Size(80, 29);
            this.pass2.TabIndex = 4;
            this.pass2.Text = "Parola";
            // 
            // pass_box2
            // 
            this.pass_box2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_box2.Location = new System.Drawing.Point(159, 176);
            this.pass_box2.Name = "pass_box2";
            this.pass_box2.Size = new System.Drawing.Size(187, 30);
            this.pass_box2.TabIndex = 3;
            this.pass_box2.UseSystemPasswordChar = true;
            this.pass_box2.TextChanged += new System.EventHandler(this.key_sound);
            // 
            // user2
            // 
            this.user2.AutoSize = true;
            this.user2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.user2.Location = new System.Drawing.Point(59, 118);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(94, 29);
            this.user2.TabIndex = 2;
            this.user2.Text = "Numele";
            // 
            // username_box2
            // 
            this.username_box2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_box2.Location = new System.Drawing.Point(159, 119);
            this.username_box2.Name = "username_box2";
            this.username_box2.Size = new System.Drawing.Size(187, 30);
            this.username_box2.TabIndex = 1;
            this.username_box2.TextChanged += new System.EventHandler(this.key_sound);
            // 
            // new_user_button
            // 
            this.new_user_button.Image = ((System.Drawing.Image)(resources.GetObject("new_user_button.Image")));
            this.new_user_button.Location = new System.Drawing.Point(29, 16);
            this.new_user_button.Name = "new_user_button";
            this.new_user_button.Size = new System.Drawing.Size(352, 69);
            this.new_user_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.new_user_button.TabIndex = 0;
            this.new_user_button.TabStop = false;
            this.new_user_button.Click += new System.EventHandler(this.new_user_button_Click);
            this.new_user_button.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.new_user_button.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(409, 455);
            this.Controls.Add(this.new_user_panel);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.menu_bar);
            this.Controls.Add(this.login_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.go)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logare_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).EndInit();
            this.new_user_panel.ResumeLayout(false);
            this.new_user_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.go_new_account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_user_button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.PictureBox menu_bar;
        private System.Windows.Forms.PictureBox close_button;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.Label nume_label;
        private System.Windows.Forms.TextBox user_box;
        private System.Windows.Forms.PictureBox logare_picture;
        private System.Windows.Forms.PictureBox go;
        private System.Windows.Forms.CheckBox show_pass;
        private System.Windows.Forms.CheckBox remember_acc;
        private System.Windows.Forms.Panel new_user_panel;
        private System.Windows.Forms.CheckBox show_pass2;
        private System.Windows.Forms.CheckBox remember2;
        private System.Windows.Forms.PictureBox go_new_account;
        private System.Windows.Forms.Label pass2;
        private System.Windows.Forms.TextBox pass_box2;
        private System.Windows.Forms.Label user2;
        private System.Windows.Forms.TextBox username_box2;
        private System.Windows.Forms.PictureBox new_user_button;
        private System.Windows.Forms.Label pass3;
        private System.Windows.Forms.TextBox pass_box3;
        private System.Windows.Forms.Label pass_label4;
    }
}