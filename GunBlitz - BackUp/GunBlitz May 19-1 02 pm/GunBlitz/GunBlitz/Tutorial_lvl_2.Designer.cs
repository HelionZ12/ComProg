namespace GunBlitz
{
    partial class Tutorial_lvl_2
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            player = new PictureBox();
            verticalPlatform = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            pictureBox14 = new PictureBox();
            Button1 = new PictureBox();
            aa = new PictureBox();
            EnPatrol = new PictureBox();
            pictureBox4 = new PictureBox();
            Gun = new PictureBox();
            TutorialEn = new PictureBox();
            TutorialEn2 = new PictureBox();
            TutorialEn3 = new PictureBox();
            TutorialEn4 = new PictureBox();
            TutorialEn5 = new PictureBox();
            EnPatrol2 = new PictureBox();
            EnPatrol3 = new PictureBox();
            pictureBox5 = new PictureBox();
            EnPatrol6 = new PictureBox();
            EnPatrol5 = new PictureBox();
            EnPatrol4 = new PictureBox();
            HealthBar = new ProgressBar();
            HealthBar2 = new Label();
            ammo2 = new PictureBox();
            ammo1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)verticalPlatform).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Button1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EnPatrol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Gun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TutorialEn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TutorialEn2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TutorialEn3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TutorialEn4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TutorialEn5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EnPatrol2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EnPatrol3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EnPatrol6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EnPatrol5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EnPatrol4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ammo2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.platform;
            pictureBox1.Location = new Point(-1, 797);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1408, 12);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "platform";
            // 
            // player
            // 
            player.BackColor = Color.RosyBrown;
            player.Location = new Point(121, 766);
            player.Name = "player";
            player.Size = new Size(19, 30);
            player.TabIndex = 1;
            player.TabStop = false;
            player.Visible = false;
            // 
            // verticalPlatform
            // 
            verticalPlatform.BackColor = Color.Sienna;
            verticalPlatform.Location = new Point(1282, 320);
            verticalPlatform.Name = "verticalPlatform";
            verticalPlatform.Size = new Size(125, 10);
            verticalPlatform.TabIndex = 14;
            verticalPlatform.TabStop = false;
            verticalPlatform.Tag = "platform";
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += MainEventTimer;
            // 
            // pictureBox14
            // 
            pictureBox14.BackgroundImage = Properties.Resources.platform;
            pictureBox14.Location = new Point(-2, 320);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(1278, 12);
            pictureBox14.TabIndex = 15;
            pictureBox14.TabStop = false;
            pictureBox14.Tag = "platform";
            // 
            // Button1
            // 
            Button1.BackColor = Color.DarkGray;
            Button1.Location = new Point(1247, 781);
            Button1.Name = "Button1";
            Button1.Size = new Size(17, 17);
            Button1.TabIndex = 38;
            Button1.TabStop = false;
            Button1.Tag = "";
            // 
            // aa
            // 
            aa.BackgroundImage = Properties.Resources.platform;
            aa.Location = new Point(-1, 638);
            aa.Name = "aa";
            aa.Size = new Size(304, 12);
            aa.TabIndex = 39;
            aa.TabStop = false;
            aa.Tag = "platform";
            // 
            // EnPatrol
            // 
            EnPatrol.BackgroundImage = Properties.Resources.platform;
            EnPatrol.Location = new Point(-1, 479);
            EnPatrol.Name = "EnPatrol";
            EnPatrol.Size = new Size(304, 12);
            EnPatrol.TabIndex = 40;
            EnPatrol.TabStop = false;
            EnPatrol.Tag = "platform";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.platform;
            pictureBox4.Location = new Point(597, 230);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(114, 12);
            pictureBox4.TabIndex = 41;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "platform";
            // 
            // Gun
            // 
            Gun.Image = Properties.Resources.TestTest___;
            Gun.Location = new Point(597, 179);
            Gun.Name = "Gun";
            Gun.Size = new Size(114, 45);
            Gun.SizeMode = PictureBoxSizeMode.StretchImage;
            Gun.TabIndex = 42;
            Gun.TabStop = false;
            // 
            // TutorialEn
            // 
            TutorialEn.BackColor = Color.Red;
            TutorialEn.Location = new Point(96, 450);
            TutorialEn.Name = "TutorialEn";
            TutorialEn.Size = new Size(17, 30);
            TutorialEn.TabIndex = 43;
            TutorialEn.TabStop = false;
            TutorialEn.Tag = "Enemy";
            // 
            // TutorialEn2
            // 
            TutorialEn2.BackColor = Color.Red;
            TutorialEn2.Location = new Point(301, 450);
            TutorialEn2.Name = "TutorialEn2";
            TutorialEn2.Size = new Size(17, 30);
            TutorialEn2.TabIndex = 44;
            TutorialEn2.TabStop = false;
            TutorialEn2.Tag = "Enemy";
            // 
            // TutorialEn3
            // 
            TutorialEn3.BackColor = Color.Red;
            TutorialEn3.Location = new Point(328, 608);
            TutorialEn3.Name = "TutorialEn3";
            TutorialEn3.Size = new Size(17, 30);
            TutorialEn3.TabIndex = 45;
            TutorialEn3.TabStop = false;
            TutorialEn3.Tag = "Enemy";
            // 
            // TutorialEn4
            // 
            TutorialEn4.BackColor = Color.Red;
            TutorialEn4.Location = new Point(709, 450);
            TutorialEn4.Name = "TutorialEn4";
            TutorialEn4.Size = new Size(17, 30);
            TutorialEn4.TabIndex = 46;
            TutorialEn4.TabStop = false;
            TutorialEn4.Tag = "Enemy";
            // 
            // TutorialEn5
            // 
            TutorialEn5.BackColor = Color.Red;
            TutorialEn5.Location = new Point(777, 608);
            TutorialEn5.Name = "TutorialEn5";
            TutorialEn5.Size = new Size(17, 30);
            TutorialEn5.TabIndex = 47;
            TutorialEn5.TabStop = false;
            TutorialEn5.Tag = "Enemy";
            // 
            // EnPatrol2
            // 
            EnPatrol2.BackgroundImage = Properties.Resources.platform;
            EnPatrol2.Location = new Point(301, 479);
            EnPatrol2.Name = "EnPatrol2";
            EnPatrol2.Size = new Size(304, 12);
            EnPatrol2.TabIndex = 49;
            EnPatrol2.TabStop = false;
            EnPatrol2.Tag = "platform";
            // 
            // EnPatrol3
            // 
            EnPatrol3.BackgroundImage = Properties.Resources.platform;
            EnPatrol3.Location = new Point(600, 479);
            EnPatrol3.Name = "EnPatrol3";
            EnPatrol3.Size = new Size(242, 12);
            EnPatrol3.TabIndex = 50;
            EnPatrol3.TabStop = false;
            EnPatrol3.Tag = "platform";
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.platform;
            pictureBox5.Location = new Point(840, 479);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(436, 12);
            pictureBox5.TabIndex = 51;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "platform";
            // 
            // EnPatrol6
            // 
            EnPatrol6.BackgroundImage = Properties.Resources.platform;
            EnPatrol6.Location = new Point(899, 638);
            EnPatrol6.Name = "EnPatrol6";
            EnPatrol6.Size = new Size(377, 12);
            EnPatrol6.TabIndex = 54;
            EnPatrol6.TabStop = false;
            EnPatrol6.Tag = "platform";
            // 
            // EnPatrol5
            // 
            EnPatrol5.BackgroundImage = Properties.Resources.platform;
            EnPatrol5.Location = new Point(600, 638);
            EnPatrol5.Name = "EnPatrol5";
            EnPatrol5.Size = new Size(304, 12);
            EnPatrol5.TabIndex = 53;
            EnPatrol5.TabStop = false;
            EnPatrol5.Tag = "platform";
            // 
            // EnPatrol4
            // 
            EnPatrol4.BackgroundImage = Properties.Resources.platform;
            EnPatrol4.Location = new Point(301, 638);
            EnPatrol4.Name = "EnPatrol4";
            EnPatrol4.Size = new Size(304, 12);
            EnPatrol4.TabIndex = 52;
            EnPatrol4.TabStop = false;
            EnPatrol4.Tag = "platform";
            // 
            // HealthBar
            // 
            HealthBar.Location = new Point(986, 12);
            HealthBar.Name = "HealthBar";
            HealthBar.Size = new Size(407, 20);
            HealthBar.TabIndex = 55;
            HealthBar.Value = 100;
            HealthBar.Visible = false;
            // 
            // HealthBar2
            // 
            HealthBar2.AutoSize = true;
            HealthBar2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            HealthBar2.Location = new Point(922, 4);
            HealthBar2.Name = "HealthBar2";
            HealthBar2.Size = new Size(58, 35);
            HealthBar2.TabIndex = 56;
            HealthBar2.Text = "HP";
            HealthBar2.Visible = false;
            // 
            // ammo2
            // 
            ammo2.Image = Properties.Resources.ammo_Image;
            ammo2.Location = new Point(12, 4);
            ammo2.Name = "ammo2";
            ammo2.Size = new Size(50, 50);
            ammo2.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo2.TabIndex = 57;
            ammo2.TabStop = false;
            ammo2.Visible = false;
            // 
            // ammo1
            // 
            ammo1.AutoSize = true;
            ammo1.Font = new Font("Stencil", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ammo1.Location = new Point(68, 19);
            ammo1.Name = "ammo1";
            ammo1.Size = new Size(61, 20);
            ammo1.TabIndex = 58;
            ammo1.Text = "Ammo";
            ammo1.Visible = false;
            // 
            // Tutorial_lvl_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 808);
            Controls.Add(ammo1);
            Controls.Add(ammo2);
            Controls.Add(HealthBar2);
            Controls.Add(HealthBar);
            Controls.Add(EnPatrol6);
            Controls.Add(EnPatrol5);
            Controls.Add(EnPatrol4);
            Controls.Add(pictureBox5);
            Controls.Add(EnPatrol3);
            Controls.Add(EnPatrol2);
            Controls.Add(TutorialEn5);
            Controls.Add(TutorialEn4);
            Controls.Add(TutorialEn3);
            Controls.Add(TutorialEn2);
            Controls.Add(TutorialEn);
            Controls.Add(Gun);
            Controls.Add(pictureBox4);
            Controls.Add(EnPatrol);
            Controls.Add(aa);
            Controls.Add(Button1);
            Controls.Add(pictureBox14);
            Controls.Add(verticalPlatform);
            Controls.Add(player);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tutorial_lvl_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tutorial_lvl_2";
            Load += Tutorial_lvl_2_Load;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)verticalPlatform).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)Button1).EndInit();
            ((System.ComponentModel.ISupportInitialize)aa).EndInit();
            ((System.ComponentModel.ISupportInitialize)EnPatrol).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Gun).EndInit();
            ((System.ComponentModel.ISupportInitialize)TutorialEn).EndInit();
            ((System.ComponentModel.ISupportInitialize)TutorialEn2).EndInit();
            ((System.ComponentModel.ISupportInitialize)TutorialEn3).EndInit();
            ((System.ComponentModel.ISupportInitialize)TutorialEn4).EndInit();
            ((System.ComponentModel.ISupportInitialize)TutorialEn5).EndInit();
            ((System.ComponentModel.ISupportInitialize)EnPatrol2).EndInit();
            ((System.ComponentModel.ISupportInitialize)EnPatrol3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)EnPatrol6).EndInit();
            ((System.ComponentModel.ISupportInitialize)EnPatrol5).EndInit();
            ((System.ComponentModel.ISupportInitialize)EnPatrol4).EndInit();
            ((System.ComponentModel.ISupportInitialize)ammo2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox player;
        private PictureBox verticalPlatform;
        private System.Windows.Forms.Timer GameTimer;
        private PictureBox pictureBox14;
        private PictureBox Button1;
        private PictureBox aa;
        private PictureBox EnPatrol;
        private PictureBox pictureBox4;
        private PictureBox Gun;
        private PictureBox TutorialEn;
        private PictureBox TutorialEn2;
        private PictureBox TutorialEn3;
        private PictureBox TutorialEn4;
        private PictureBox TutorialEn5;
        private PictureBox EnPatrol2;
        private PictureBox EnPatrol3;
        private PictureBox pictureBox5;
        private PictureBox EnPatrol6;
        private PictureBox EnPatrol5;
        private PictureBox EnPatrol4;
        private ProgressBar HealthBar;
        private Label HealthBar2;
        private PictureBox ammo2;
        private Label ammo1;
    }
}