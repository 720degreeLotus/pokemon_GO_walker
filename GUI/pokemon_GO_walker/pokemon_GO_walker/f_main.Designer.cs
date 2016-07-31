﻿namespace pokemon_GO_walker
{
    partial class f_main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.L_titlebar = new System.Windows.Forms.Label();
            this.L_titlebar_close = new System.Windows.Forms.Label();
            this.B_player1_connect = new System.Windows.Forms.Button();
            this.T_player1_ip = new System.Windows.Forms.TextBox();
            this.T_player1_port = new System.Windows.Forms.TextBox();
            this.T_player1_lat = new System.Windows.Forms.TextBox();
            this.T_player1_lon = new System.Windows.Forms.TextBox();
            this.B_player1_setGps = new System.Windows.Forms.Button();
            this.T_player1_step = new System.Windows.Forms.TextBox();
            this.B_player1_step = new System.Windows.Forms.Button();
            this.TIMER_player1_autowalk = new System.Windows.Forms.Timer(this.components);
            this.B_resetConfig = new System.Windows.Forms.Button();
            this.B_hotkey = new System.Windows.Forms.Button();
            this.L_hotkey_status = new System.Windows.Forms.Label();
            this.B_menu = new System.Windows.Forms.Button();
            this.GROUP_menu = new System.Windows.Forms.GroupBox();
            this.B_menu_close = new System.Windows.Forms.Button();
            this.L_menu_yt = new System.Windows.Forms.Label();
            this.L_menu_project = new System.Windows.Forms.Label();
            this.L_menu_website = new System.Windows.Forms.LinkLabel();
            this.L_menu_email = new System.Windows.Forms.Label();
            this.L_menu_author = new System.Windows.Forms.Label();
            this.TAB_player1_manual = new pokemon_GO_walker.MyTabControl();
            this.TABPAGE_player1_manual = new System.Windows.Forms.TabPage();
            this.B_player1_UP = new System.Windows.Forms.Button();
            this.B_player1_LEFT = new System.Windows.Forms.Button();
            this.B_player1_RIGHT = new System.Windows.Forms.Button();
            this.B_player1_refreshGps = new System.Windows.Forms.Button();
            this.B_player1_DOWN = new System.Windows.Forms.Button();
            this.TABPAGE_player1_autowalk = new System.Windows.Forms.TabPage();
            this.L_player1_autowalk_status = new System.Windows.Forms.Label();
            this.T_player1_autowalk_change = new System.Windows.Forms.TextBox();
            this.L_player1_autowalk_change = new System.Windows.Forms.Label();
            this.L_player1_autowalk_direction = new System.Windows.Forms.Label();
            this.T_player1_autowalk_step = new System.Windows.Forms.TextBox();
            this.L_player1_autowalk_step = new System.Windows.Forms.Label();
            this.T_player1_autowalk_seconds = new System.Windows.Forms.TextBox();
            this.L_player1_autowalk_seconds = new System.Windows.Forms.Label();
            this.C_player1_autowalk_direction = new System.Windows.Forms.ComboBox();
            this.B_player1_autowalk_toggle = new System.Windows.Forms.Button();
            this.TABPAGE_player1_bookmarks = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.TABPAGE_player1_log = new System.Windows.Forms.TabPage();
            this.RTB_player1_log = new System.Windows.Forms.RichTextBox();
            this.GROUP_menu.SuspendLayout();
            this.TAB_player1_manual.SuspendLayout();
            this.TABPAGE_player1_manual.SuspendLayout();
            this.TABPAGE_player1_autowalk.SuspendLayout();
            this.TABPAGE_player1_bookmarks.SuspendLayout();
            this.TABPAGE_player1_log.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_titlebar
            // 
            this.L_titlebar.BackColor = System.Drawing.Color.Chartreuse;
            this.L_titlebar.ForeColor = System.Drawing.Color.Red;
            this.L_titlebar.Location = new System.Drawing.Point(0, 0);
            this.L_titlebar.Name = "L_titlebar";
            this.L_titlebar.Size = new System.Drawing.Size(1225, 12);
            this.L_titlebar.TabIndex = 0;
            this.L_titlebar.Text = "Pokemon GO Walker (by 720° Lotus) Version: 2016-07-31";
            this.L_titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.L_titlebar_MouseDown);
            this.L_titlebar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.L_titlebar_MouseMove);
            // 
            // L_titlebar_close
            // 
            this.L_titlebar_close.BackColor = System.Drawing.Color.Red;
            this.L_titlebar_close.Location = new System.Drawing.Point(1208, 0);
            this.L_titlebar_close.Name = "L_titlebar_close";
            this.L_titlebar_close.Size = new System.Drawing.Size(17, 12);
            this.L_titlebar_close.TabIndex = 1;
            this.L_titlebar_close.Text = "X";
            this.L_titlebar_close.Click += new System.EventHandler(this.L_titlebar_close_Click);
            // 
            // B_player1_connect
            // 
            this.B_player1_connect.BackColor = System.Drawing.Color.Transparent;
            this.B_player1_connect.BackgroundImage = global::pokemon_GO_walker.Properties.Resources.ic_speaker_phone_white_48dp_1x;
            this.B_player1_connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_player1_connect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.B_player1_connect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_player1_connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_player1_connect.Location = new System.Drawing.Point(47, 118);
            this.B_player1_connect.Name = "B_player1_connect";
            this.B_player1_connect.Size = new System.Drawing.Size(44, 46);
            this.B_player1_connect.TabIndex = 2;
            this.B_player1_connect.UseVisualStyleBackColor = false;
            this.B_player1_connect.Click += new System.EventHandler(this.B_player1_connect_Click);
            // 
            // T_player1_ip
            // 
            this.T_player1_ip.BackColor = System.Drawing.Color.Black;
            this.T_player1_ip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.T_player1_ip.ForeColor = System.Drawing.Color.White;
            this.T_player1_ip.Location = new System.Drawing.Point(97, 133);
            this.T_player1_ip.Name = "T_player1_ip";
            this.T_player1_ip.Size = new System.Drawing.Size(108, 20);
            this.T_player1_ip.TabIndex = 3;
            this.T_player1_ip.Text = "192.168.100.100";
            // 
            // T_player1_port
            // 
            this.T_player1_port.BackColor = System.Drawing.Color.Black;
            this.T_player1_port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.T_player1_port.ForeColor = System.Drawing.Color.White;
            this.T_player1_port.Location = new System.Drawing.Point(211, 133);
            this.T_player1_port.Name = "T_player1_port";
            this.T_player1_port.Size = new System.Drawing.Size(46, 20);
            this.T_player1_port.TabIndex = 4;
            this.T_player1_port.Text = "5554";
            // 
            // T_player1_lat
            // 
            this.T_player1_lat.BackColor = System.Drawing.Color.Black;
            this.T_player1_lat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.T_player1_lat.ForeColor = System.Drawing.Color.White;
            this.T_player1_lat.Location = new System.Drawing.Point(97, 187);
            this.T_player1_lat.Name = "T_player1_lat";
            this.T_player1_lat.Size = new System.Drawing.Size(77, 20);
            this.T_player1_lat.TabIndex = 5;
            this.T_player1_lat.Text = "51,5049813";
            // 
            // T_player1_lon
            // 
            this.T_player1_lon.BackColor = System.Drawing.Color.Black;
            this.T_player1_lon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.T_player1_lon.ForeColor = System.Drawing.Color.White;
            this.T_player1_lon.Location = new System.Drawing.Point(180, 187);
            this.T_player1_lon.Name = "T_player1_lon";
            this.T_player1_lon.Size = new System.Drawing.Size(77, 20);
            this.T_player1_lon.TabIndex = 6;
            this.T_player1_lon.Text = "7,1020849";
            // 
            // B_player1_setGps
            // 
            this.B_player1_setGps.BackColor = System.Drawing.Color.Transparent;
            this.B_player1_setGps.BackgroundImage = global::pokemon_GO_walker.Properties.Resources.ic_place_white_48dp_1x;
            this.B_player1_setGps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_player1_setGps.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_player1_setGps.Location = new System.Drawing.Point(47, 170);
            this.B_player1_setGps.Name = "B_player1_setGps";
            this.B_player1_setGps.Size = new System.Drawing.Size(44, 50);
            this.B_player1_setGps.TabIndex = 7;
            this.B_player1_setGps.UseVisualStyleBackColor = false;
            this.B_player1_setGps.Click += new System.EventHandler(this.B_player1_setGps_Click);
            // 
            // T_player1_step
            // 
            this.T_player1_step.BackColor = System.Drawing.Color.Black;
            this.T_player1_step.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.T_player1_step.ForeColor = System.Drawing.Color.White;
            this.T_player1_step.Location = new System.Drawing.Point(97, 236);
            this.T_player1_step.Name = "T_player1_step";
            this.T_player1_step.Size = new System.Drawing.Size(56, 20);
            this.T_player1_step.TabIndex = 13;
            this.T_player1_step.Text = "0,0005";
            // 
            // B_player1_step
            // 
            this.B_player1_step.BackColor = System.Drawing.Color.Transparent;
            this.B_player1_step.BackgroundImage = global::pokemon_GO_walker.Properties.Resources.ic_directions_walk_white_48dp_1x;
            this.B_player1_step.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_player1_step.Enabled = false;
            this.B_player1_step.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_player1_step.Location = new System.Drawing.Point(51, 226);
            this.B_player1_step.Name = "B_player1_step";
            this.B_player1_step.Size = new System.Drawing.Size(40, 46);
            this.B_player1_step.TabIndex = 17;
            this.B_player1_step.UseVisualStyleBackColor = false;
            // 
            // TIMER_player1_autowalk
            // 
            this.TIMER_player1_autowalk.Interval = 10000;
            this.TIMER_player1_autowalk.Tick += new System.EventHandler(this.TIMER_player1_autowalk_Tick);
            // 
            // B_resetConfig
            // 
            this.B_resetConfig.BackColor = System.Drawing.Color.Transparent;
            this.B_resetConfig.BackgroundImage = global::pokemon_GO_walker.Properties.Resources.ic_settings_backup_restore_white_48dp_1x;
            this.B_resetConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B_resetConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_resetConfig.ForeColor = System.Drawing.Color.Red;
            this.B_resetConfig.Location = new System.Drawing.Point(97, 209);
            this.B_resetConfig.Name = "B_resetConfig";
            this.B_resetConfig.Size = new System.Drawing.Size(232, 51);
            this.B_resetConfig.TabIndex = 18;
            this.B_resetConfig.Text = "  Reset Config (not bookmarks!)";
            this.B_resetConfig.UseVisualStyleBackColor = false;
            this.B_resetConfig.Click += new System.EventHandler(this.B_resetConfig_Click);
            // 
            // B_hotkey
            // 
            this.B_hotkey.BackColor = System.Drawing.Color.Transparent;
            this.B_hotkey.BackgroundImage = global::pokemon_GO_walker.Properties.Resources.ic_keyboard_white_48dp_2x;
            this.B_hotkey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_hotkey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_hotkey.Location = new System.Drawing.Point(589, 24);
            this.B_hotkey.Margin = new System.Windows.Forms.Padding(0);
            this.B_hotkey.Name = "B_hotkey";
            this.B_hotkey.Size = new System.Drawing.Size(62, 48);
            this.B_hotkey.TabIndex = 21;
            this.B_hotkey.UseVisualStyleBackColor = false;
            this.B_hotkey.Click += new System.EventHandler(this.B_hotkey_Click);
            this.B_hotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            this.B_hotkey.Leave += new System.EventHandler(this.B_hotkey_Leave);
            // 
            // L_hotkey_status
            // 
            this.L_hotkey_status.AutoSize = true;
            this.L_hotkey_status.BackColor = System.Drawing.Color.Transparent;
            this.L_hotkey_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_hotkey_status.ForeColor = System.Drawing.Color.Red;
            this.L_hotkey_status.Location = new System.Drawing.Point(549, 72);
            this.L_hotkey_status.Name = "L_hotkey_status";
            this.L_hotkey_status.Size = new System.Drawing.Size(151, 20);
            this.L_hotkey_status.TabIndex = 22;
            this.L_hotkey_status.Text = "Hotkeys are inactive";
            // 
            // B_menu
            // 
            this.B_menu.BackColor = System.Drawing.Color.DodgerBlue;
            this.B_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_menu.Location = new System.Drawing.Point(1179, 12);
            this.B_menu.Name = "B_menu";
            this.B_menu.Size = new System.Drawing.Size(46, 28);
            this.B_menu.TabIndex = 23;
            this.B_menu.Text = "Menu";
            this.B_menu.UseVisualStyleBackColor = false;
            this.B_menu.Click += new System.EventHandler(this.B_menu_Click);
            // 
            // GROUP_menu
            // 
            this.GROUP_menu.BackColor = System.Drawing.Color.Black;
            this.GROUP_menu.Controls.Add(this.B_menu_close);
            this.GROUP_menu.Controls.Add(this.L_menu_yt);
            this.GROUP_menu.Controls.Add(this.L_menu_project);
            this.GROUP_menu.Controls.Add(this.L_menu_website);
            this.GROUP_menu.Controls.Add(this.L_menu_email);
            this.GROUP_menu.Controls.Add(this.L_menu_author);
            this.GROUP_menu.Controls.Add(this.B_resetConfig);
            this.GROUP_menu.Enabled = false;
            this.GROUP_menu.ForeColor = System.Drawing.Color.Chartreuse;
            this.GROUP_menu.Location = new System.Drawing.Point(412, 136);
            this.GROUP_menu.Name = "GROUP_menu";
            this.GROUP_menu.Size = new System.Drawing.Size(426, 359);
            this.GROUP_menu.TabIndex = 24;
            this.GROUP_menu.TabStop = false;
            this.GROUP_menu.Text = "Menu";
            this.GROUP_menu.Visible = false;
            // 
            // B_menu_close
            // 
            this.B_menu_close.BackColor = System.Drawing.Color.Red;
            this.B_menu_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_menu_close.ForeColor = System.Drawing.Color.Black;
            this.B_menu_close.Location = new System.Drawing.Point(394, 7);
            this.B_menu_close.Name = "B_menu_close";
            this.B_menu_close.Size = new System.Drawing.Size(31, 20);
            this.B_menu_close.TabIndex = 24;
            this.B_menu_close.Text = "X";
            this.B_menu_close.UseVisualStyleBackColor = false;
            this.B_menu_close.Click += new System.EventHandler(this.B_menu_close_Click);
            // 
            // L_menu_yt
            // 
            this.L_menu_yt.AutoSize = true;
            this.L_menu_yt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_menu_yt.Location = new System.Drawing.Point(24, 168);
            this.L_menu_yt.Name = "L_menu_yt";
            this.L_menu_yt.Size = new System.Drawing.Size(380, 17);
            this.L_menu_yt.TabIndex = 23;
            this.L_menu_yt.Text = "Youtube-Video and more tutorial-stuff coming, if demanded";
            // 
            // L_menu_project
            // 
            this.L_menu_project.AutoSize = true;
            this.L_menu_project.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_menu_project.Location = new System.Drawing.Point(34, 97);
            this.L_menu_project.Name = "L_menu_project";
            this.L_menu_project.Size = new System.Drawing.Size(62, 20);
            this.L_menu_project.TabIndex = 22;
            this.L_menu_project.Text = "Project:";
            // 
            // L_menu_website
            // 
            this.L_menu_website.AutoSize = true;
            this.L_menu_website.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_menu_website.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.L_menu_website.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.L_menu_website.Location = new System.Drawing.Point(93, 97);
            this.L_menu_website.Name = "L_menu_website";
            this.L_menu_website.Size = new System.Drawing.Size(67, 20);
            this.L_menu_website.TabIndex = 21;
            this.L_menu_website.TabStop = true;
            this.L_menu_website.Text = "Website";
            this.L_menu_website.VisitedLinkColor = System.Drawing.Color.Blue;
            this.L_menu_website.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.L_menu_website_LinkClicked);
            // 
            // L_menu_email
            // 
            this.L_menu_email.AutoSize = true;
            this.L_menu_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_menu_email.Location = new System.Drawing.Point(34, 64);
            this.L_menu_email.Name = "L_menu_email";
            this.L_menu_email.Size = new System.Drawing.Size(263, 20);
            this.L_menu_email.TabIndex = 20;
            this.L_menu_email.Text = "Email: 720DegreeLotus@gmail.com";
            // 
            // L_menu_author
            // 
            this.L_menu_author.AutoSize = true;
            this.L_menu_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_menu_author.Location = new System.Drawing.Point(33, 34);
            this.L_menu_author.Name = "L_menu_author";
            this.L_menu_author.Size = new System.Drawing.Size(141, 20);
            this.L_menu_author.TabIndex = 19;
            this.L_menu_author.Text = "Author: 720° Lotus";
            // 
            // TAB_player1_manual
            // 
            this.TAB_player1_manual.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TAB_player1_manual.Controls.Add(this.TABPAGE_player1_manual);
            this.TAB_player1_manual.Controls.Add(this.TABPAGE_player1_autowalk);
            this.TAB_player1_manual.Controls.Add(this.TABPAGE_player1_bookmarks);
            this.TAB_player1_manual.Controls.Add(this.TABPAGE_player1_log);
            this.TAB_player1_manual.Location = new System.Drawing.Point(47, 279);
            this.TAB_player1_manual.Name = "TAB_player1_manual";
            this.TAB_player1_manual.SelectedIndex = 0;
            this.TAB_player1_manual.Size = new System.Drawing.Size(271, 280);
            this.TAB_player1_manual.TabIndex = 15;
            this.TAB_player1_manual.Visible = false;
            // 
            // TABPAGE_player1_manual
            // 
            this.TABPAGE_player1_manual.BackColor = System.Drawing.Color.Black;
            this.TABPAGE_player1_manual.Controls.Add(this.B_player1_UP);
            this.TABPAGE_player1_manual.Controls.Add(this.B_player1_LEFT);
            this.TABPAGE_player1_manual.Controls.Add(this.B_player1_RIGHT);
            this.TABPAGE_player1_manual.Controls.Add(this.B_player1_refreshGps);
            this.TABPAGE_player1_manual.Controls.Add(this.B_player1_DOWN);
            this.TABPAGE_player1_manual.Location = new System.Drawing.Point(4, 25);
            this.TABPAGE_player1_manual.Name = "TABPAGE_player1_manual";
            this.TABPAGE_player1_manual.Padding = new System.Windows.Forms.Padding(3);
            this.TABPAGE_player1_manual.Size = new System.Drawing.Size(263, 251);
            this.TABPAGE_player1_manual.TabIndex = 0;
            this.TABPAGE_player1_manual.Text = "Manual";
            // 
            // B_player1_UP
            // 
            this.B_player1_UP.BackColor = System.Drawing.Color.Transparent;
            this.B_player1_UP.BackgroundImage = global::pokemon_GO_walker.Properties.Resources.ic_keyboard_arrow_up_white_48dp_2x;
            this.B_player1_UP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_player1_UP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_player1_UP.Location = new System.Drawing.Point(83, 2);
            this.B_player1_UP.Name = "B_player1_UP";
            this.B_player1_UP.Size = new System.Drawing.Size(80, 80);
            this.B_player1_UP.TabIndex = 8;
            this.B_player1_UP.UseVisualStyleBackColor = false;
            this.B_player1_UP.Click += new System.EventHandler(this.B_player1_UP_Click);
            // 
            // B_player1_LEFT
            // 
            this.B_player1_LEFT.BackColor = System.Drawing.Color.Transparent;
            this.B_player1_LEFT.BackgroundImage = global::pokemon_GO_walker.Properties.Resources.ic_keyboard_arrow_left_white_48dp_2x;
            this.B_player1_LEFT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_player1_LEFT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_player1_LEFT.Location = new System.Drawing.Point(2, 83);
            this.B_player1_LEFT.Name = "B_player1_LEFT";
            this.B_player1_LEFT.Size = new System.Drawing.Size(80, 80);
            this.B_player1_LEFT.TabIndex = 9;
            this.B_player1_LEFT.UseVisualStyleBackColor = false;
            this.B_player1_LEFT.Click += new System.EventHandler(this.B_player1_LEFT_Click);
            // 
            // B_player1_RIGHT
            // 
            this.B_player1_RIGHT.BackColor = System.Drawing.Color.Transparent;
            this.B_player1_RIGHT.BackgroundImage = global::pokemon_GO_walker.Properties.Resources.ic_keyboard_arrow_right_white_48dp_2x;
            this.B_player1_RIGHT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_player1_RIGHT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_player1_RIGHT.Location = new System.Drawing.Point(164, 83);
            this.B_player1_RIGHT.Name = "B_player1_RIGHT";
            this.B_player1_RIGHT.Size = new System.Drawing.Size(80, 80);
            this.B_player1_RIGHT.TabIndex = 10;
            this.B_player1_RIGHT.UseVisualStyleBackColor = false;
            this.B_player1_RIGHT.Click += new System.EventHandler(this.B_player1_RIGHT_Click);
            // 
            // B_player1_refreshGps
            // 
            this.B_player1_refreshGps.BackColor = System.Drawing.Color.Transparent;
            this.B_player1_refreshGps.BackgroundImage = global::pokemon_GO_walker.Properties.Resources.ic_refresh_white_48dp_2x;
            this.B_player1_refreshGps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_player1_refreshGps.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_player1_refreshGps.Location = new System.Drawing.Point(83, 83);
            this.B_player1_refreshGps.Name = "B_player1_refreshGps";
            this.B_player1_refreshGps.Size = new System.Drawing.Size(80, 80);
            this.B_player1_refreshGps.TabIndex = 12;
            this.B_player1_refreshGps.UseVisualStyleBackColor = false;
            this.B_player1_refreshGps.Click += new System.EventHandler(this.B_player1_refreshGps_Click);
            // 
            // B_player1_DOWN
            // 
            this.B_player1_DOWN.BackColor = System.Drawing.Color.Transparent;
            this.B_player1_DOWN.BackgroundImage = global::pokemon_GO_walker.Properties.Resources.ic_keyboard_arrow_down_white_48dp_2x;
            this.B_player1_DOWN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_player1_DOWN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_player1_DOWN.Location = new System.Drawing.Point(83, 164);
            this.B_player1_DOWN.Name = "B_player1_DOWN";
            this.B_player1_DOWN.Size = new System.Drawing.Size(80, 80);
            this.B_player1_DOWN.TabIndex = 11;
            this.B_player1_DOWN.UseVisualStyleBackColor = false;
            this.B_player1_DOWN.Click += new System.EventHandler(this.B_player1_DOWN_Click);
            // 
            // TABPAGE_player1_autowalk
            // 
            this.TABPAGE_player1_autowalk.BackColor = System.Drawing.Color.Black;
            this.TABPAGE_player1_autowalk.Controls.Add(this.L_player1_autowalk_status);
            this.TABPAGE_player1_autowalk.Controls.Add(this.T_player1_autowalk_change);
            this.TABPAGE_player1_autowalk.Controls.Add(this.L_player1_autowalk_change);
            this.TABPAGE_player1_autowalk.Controls.Add(this.L_player1_autowalk_direction);
            this.TABPAGE_player1_autowalk.Controls.Add(this.T_player1_autowalk_step);
            this.TABPAGE_player1_autowalk.Controls.Add(this.L_player1_autowalk_step);
            this.TABPAGE_player1_autowalk.Controls.Add(this.T_player1_autowalk_seconds);
            this.TABPAGE_player1_autowalk.Controls.Add(this.L_player1_autowalk_seconds);
            this.TABPAGE_player1_autowalk.Controls.Add(this.C_player1_autowalk_direction);
            this.TABPAGE_player1_autowalk.Controls.Add(this.B_player1_autowalk_toggle);
            this.TABPAGE_player1_autowalk.Location = new System.Drawing.Point(4, 25);
            this.TABPAGE_player1_autowalk.Name = "TABPAGE_player1_autowalk";
            this.TABPAGE_player1_autowalk.Padding = new System.Windows.Forms.Padding(3);
            this.TABPAGE_player1_autowalk.Size = new System.Drawing.Size(263, 251);
            this.TABPAGE_player1_autowalk.TabIndex = 1;
            this.TABPAGE_player1_autowalk.Text = "Autowalk";
            // 
            // L_player1_autowalk_status
            // 
            this.L_player1_autowalk_status.BackColor = System.Drawing.Color.Transparent;
            this.L_player1_autowalk_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_player1_autowalk_status.ForeColor = System.Drawing.Color.Red;
            this.L_player1_autowalk_status.Location = new System.Drawing.Point(96, 31);
            this.L_player1_autowalk_status.Name = "L_player1_autowalk_status";
            this.L_player1_autowalk_status.Size = new System.Drawing.Size(88, 40);
            this.L_player1_autowalk_status.TabIndex = 9;
            this.L_player1_autowalk_status.Text = "OFF";
            // 
            // T_player1_autowalk_change
            // 
            this.T_player1_autowalk_change.BackColor = System.Drawing.Color.Black;
            this.T_player1_autowalk_change.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.T_player1_autowalk_change.ForeColor = System.Drawing.Color.White;
            this.T_player1_autowalk_change.Location = new System.Drawing.Point(172, 228);
            this.T_player1_autowalk_change.Name = "T_player1_autowalk_change";
            this.T_player1_autowalk_change.Size = new System.Drawing.Size(31, 20);
            this.T_player1_autowalk_change.TabIndex = 3;
            this.T_player1_autowalk_change.Text = "10";
            // 
            // L_player1_autowalk_change
            // 
            this.L_player1_autowalk_change.BackColor = System.Drawing.Color.Transparent;
            this.L_player1_autowalk_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_player1_autowalk_change.ForeColor = System.Drawing.Color.White;
            this.L_player1_autowalk_change.Location = new System.Drawing.Point(3, 225);
            this.L_player1_autowalk_change.Name = "L_player1_autowalk_change";
            this.L_player1_autowalk_change.Size = new System.Drawing.Size(319, 23);
            this.L_player1_autowalk_change.TabIndex = 8;
            this.L_player1_autowalk_change.Text = "Change direction each           steps";
            // 
            // L_player1_autowalk_direction
            // 
            this.L_player1_autowalk_direction.BackColor = System.Drawing.Color.Transparent;
            this.L_player1_autowalk_direction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_player1_autowalk_direction.ForeColor = System.Drawing.Color.White;
            this.L_player1_autowalk_direction.Location = new System.Drawing.Point(6, 183);
            this.L_player1_autowalk_direction.Name = "L_player1_autowalk_direction";
            this.L_player1_autowalk_direction.Size = new System.Drawing.Size(154, 23);
            this.L_player1_autowalk_direction.TabIndex = 7;
            this.L_player1_autowalk_direction.Text = "(Starting-) Direction";
            // 
            // T_player1_autowalk_step
            // 
            this.T_player1_autowalk_step.BackColor = System.Drawing.Color.Black;
            this.T_player1_autowalk_step.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.T_player1_autowalk_step.ForeColor = System.Drawing.Color.White;
            this.T_player1_autowalk_step.Location = new System.Drawing.Point(100, 143);
            this.T_player1_autowalk_step.Name = "T_player1_autowalk_step";
            this.T_player1_autowalk_step.Size = new System.Drawing.Size(66, 20);
            this.T_player1_autowalk_step.TabIndex = 2;
            this.T_player1_autowalk_step.Text = "0,00005";
            // 
            // L_player1_autowalk_step
            // 
            this.L_player1_autowalk_step.BackColor = System.Drawing.Color.Transparent;
            this.L_player1_autowalk_step.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_player1_autowalk_step.ForeColor = System.Drawing.Color.White;
            this.L_player1_autowalk_step.Location = new System.Drawing.Point(6, 140);
            this.L_player1_autowalk_step.Name = "L_player1_autowalk_step";
            this.L_player1_autowalk_step.Size = new System.Drawing.Size(248, 24);
            this.L_player1_autowalk_step.TabIndex = 6;
            this.L_player1_autowalk_step.Text = "Each step is                   long";
            // 
            // T_player1_autowalk_seconds
            // 
            this.T_player1_autowalk_seconds.BackColor = System.Drawing.Color.Black;
            this.T_player1_autowalk_seconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.T_player1_autowalk_seconds.ForeColor = System.Drawing.Color.White;
            this.T_player1_autowalk_seconds.Location = new System.Drawing.Point(145, 98);
            this.T_player1_autowalk_seconds.Name = "T_player1_autowalk_seconds";
            this.T_player1_autowalk_seconds.Size = new System.Drawing.Size(29, 20);
            this.T_player1_autowalk_seconds.TabIndex = 1;
            this.T_player1_autowalk_seconds.Text = "10";
            // 
            // L_player1_autowalk_seconds
            // 
            this.L_player1_autowalk_seconds.BackColor = System.Drawing.Color.Transparent;
            this.L_player1_autowalk_seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_player1_autowalk_seconds.ForeColor = System.Drawing.Color.White;
            this.L_player1_autowalk_seconds.Location = new System.Drawing.Point(6, 95);
            this.L_player1_autowalk_seconds.Name = "L_player1_autowalk_seconds";
            this.L_player1_autowalk_seconds.Size = new System.Drawing.Size(323, 33);
            this.L_player1_autowalk_seconds.TabIndex = 5;
            this.L_player1_autowalk_seconds.Text = "Make a step every          seconds";
            // 
            // C_player1_autowalk_direction
            // 
            this.C_player1_autowalk_direction.BackColor = System.Drawing.Color.Black;
            this.C_player1_autowalk_direction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C_player1_autowalk_direction.ForeColor = System.Drawing.Color.White;
            this.C_player1_autowalk_direction.FormattingEnabled = true;
            this.C_player1_autowalk_direction.Items.AddRange(new object[] {
            "UP",
            "DOWN",
            "LEFT",
            "RIGHT"});
            this.C_player1_autowalk_direction.Location = new System.Drawing.Point(160, 184);
            this.C_player1_autowalk_direction.Name = "C_player1_autowalk_direction";
            this.C_player1_autowalk_direction.Size = new System.Drawing.Size(64, 21);
            this.C_player1_autowalk_direction.TabIndex = 4;
            this.C_player1_autowalk_direction.Text = "DOWN";
            // 
            // B_player1_autowalk_toggle
            // 
            this.B_player1_autowalk_toggle.BackColor = System.Drawing.Color.Transparent;
            this.B_player1_autowalk_toggle.BackgroundImage = global::pokemon_GO_walker.Properties.Resources.ic_directions_walk_white_48dp_1x;
            this.B_player1_autowalk_toggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_player1_autowalk_toggle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_player1_autowalk_toggle.Location = new System.Drawing.Point(33, 30);
            this.B_player1_autowalk_toggle.Name = "B_player1_autowalk_toggle";
            this.B_player1_autowalk_toggle.Size = new System.Drawing.Size(50, 42);
            this.B_player1_autowalk_toggle.TabIndex = 0;
            this.B_player1_autowalk_toggle.UseVisualStyleBackColor = false;
            this.B_player1_autowalk_toggle.Click += new System.EventHandler(this.B_player1_autowalk_toggle_Click);
            // 
            // TABPAGE_player1_bookmarks
            // 
            this.TABPAGE_player1_bookmarks.BackColor = System.Drawing.Color.Black;
            this.TABPAGE_player1_bookmarks.Controls.Add(this.label1);
            this.TABPAGE_player1_bookmarks.Location = new System.Drawing.Point(4, 25);
            this.TABPAGE_player1_bookmarks.Name = "TABPAGE_player1_bookmarks";
            this.TABPAGE_player1_bookmarks.Padding = new System.Windows.Forms.Padding(3);
            this.TABPAGE_player1_bookmarks.Size = new System.Drawing.Size(263, 251);
            this.TABPAGE_player1_bookmarks.TabIndex = 2;
            this.TABPAGE_player1_bookmarks.Text = "Bookmarks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(22, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coming soon...";
            // 
            // TABPAGE_player1_log
            // 
            this.TABPAGE_player1_log.BackColor = System.Drawing.Color.Black;
            this.TABPAGE_player1_log.Controls.Add(this.RTB_player1_log);
            this.TABPAGE_player1_log.Location = new System.Drawing.Point(4, 25);
            this.TABPAGE_player1_log.Name = "TABPAGE_player1_log";
            this.TABPAGE_player1_log.Padding = new System.Windows.Forms.Padding(3);
            this.TABPAGE_player1_log.Size = new System.Drawing.Size(263, 251);
            this.TABPAGE_player1_log.TabIndex = 3;
            this.TABPAGE_player1_log.Text = "Log";
            // 
            // RTB_player1_log
            // 
            this.RTB_player1_log.BackColor = System.Drawing.Color.Black;
            this.RTB_player1_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_player1_log.ForeColor = System.Drawing.Color.White;
            this.RTB_player1_log.HideSelection = false;
            this.RTB_player1_log.Location = new System.Drawing.Point(6, 6);
            this.RTB_player1_log.Name = "RTB_player1_log";
            this.RTB_player1_log.ReadOnly = true;
            this.RTB_player1_log.Size = new System.Drawing.Size(250, 230);
            this.RTB_player1_log.TabIndex = 0;
            this.RTB_player1_log.Text = "Ready";
            // 
            // f_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::pokemon_GO_walker.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1225, 690);
            this.Controls.Add(this.GROUP_menu);
            this.Controls.Add(this.B_menu);
            this.Controls.Add(this.L_hotkey_status);
            this.Controls.Add(this.B_hotkey);
            this.Controls.Add(this.B_player1_step);
            this.Controls.Add(this.TAB_player1_manual);
            this.Controls.Add(this.T_player1_step);
            this.Controls.Add(this.B_player1_setGps);
            this.Controls.Add(this.T_player1_lon);
            this.Controls.Add(this.T_player1_lat);
            this.Controls.Add(this.T_player1_port);
            this.Controls.Add(this.T_player1_ip);
            this.Controls.Add(this.B_player1_connect);
            this.Controls.Add(this.L_titlebar_close);
            this.Controls.Add(this.L_titlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f_main";
            this.Text = "Pokemon GO Walker (by 720° Lotus)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f_main_FormClosing);
            this.Load += new System.EventHandler(this.f_main_Load);
            this.GROUP_menu.ResumeLayout(false);
            this.GROUP_menu.PerformLayout();
            this.TAB_player1_manual.ResumeLayout(false);
            this.TABPAGE_player1_manual.ResumeLayout(false);
            this.TABPAGE_player1_autowalk.ResumeLayout(false);
            this.TABPAGE_player1_autowalk.PerformLayout();
            this.TABPAGE_player1_bookmarks.ResumeLayout(false);
            this.TABPAGE_player1_bookmarks.PerformLayout();
            this.TABPAGE_player1_log.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_titlebar;
        private System.Windows.Forms.Label L_titlebar_close;
        private System.Windows.Forms.Button B_player1_connect;
        private System.Windows.Forms.TextBox T_player1_ip;
        private System.Windows.Forms.TextBox T_player1_port;
        private System.Windows.Forms.TextBox T_player1_lat;
        private System.Windows.Forms.TextBox T_player1_lon;
        private System.Windows.Forms.Button B_player1_setGps;
        private System.Windows.Forms.Button B_player1_UP;
        private System.Windows.Forms.Button B_player1_LEFT;
        private System.Windows.Forms.Button B_player1_RIGHT;
        private System.Windows.Forms.Button B_player1_DOWN;
        private System.Windows.Forms.Button B_player1_refreshGps;
        private System.Windows.Forms.TextBox T_player1_step;
        private MyTabControl TAB_player1_manual;
        private System.Windows.Forms.TabPage TABPAGE_player1_manual;
        private System.Windows.Forms.TabPage TABPAGE_player1_autowalk;
        private System.Windows.Forms.Button B_player1_autowalk_toggle;
        private System.Windows.Forms.Button B_player1_step;
        private System.Windows.Forms.TextBox T_player1_autowalk_change;
        private System.Windows.Forms.Label L_player1_autowalk_change;
        private System.Windows.Forms.Label L_player1_autowalk_direction;
        private System.Windows.Forms.TextBox T_player1_autowalk_step;
        private System.Windows.Forms.Label L_player1_autowalk_step;
        private System.Windows.Forms.TextBox T_player1_autowalk_seconds;
        private System.Windows.Forms.Label L_player1_autowalk_seconds;
        private System.Windows.Forms.ComboBox C_player1_autowalk_direction;
        private System.Windows.Forms.TabPage TABPAGE_player1_bookmarks;
        private System.Windows.Forms.Label L_player1_autowalk_status;
        private System.Windows.Forms.Timer TIMER_player1_autowalk;
        private System.Windows.Forms.TabPage TABPAGE_player1_log;
        private System.Windows.Forms.RichTextBox RTB_player1_log;
        private System.Windows.Forms.Button B_resetConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_hotkey;
        private System.Windows.Forms.Label L_hotkey_status;
        private System.Windows.Forms.Button B_menu;
        private System.Windows.Forms.GroupBox GROUP_menu;
        private System.Windows.Forms.Label L_menu_email;
        private System.Windows.Forms.Label L_menu_author;
        private System.Windows.Forms.LinkLabel L_menu_website;
        private System.Windows.Forms.Label L_menu_project;
        private System.Windows.Forms.Label L_menu_yt;
        private System.Windows.Forms.Button B_menu_close;
    }
}

