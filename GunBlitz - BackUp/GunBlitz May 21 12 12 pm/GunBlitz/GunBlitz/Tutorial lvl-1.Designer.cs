namespace GunBlitz
{
    partial class Tutorial_lvl_1
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
            pictureBox2 = new PictureBox();
            player = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            e1Patrol = new PictureBox();
            pictureBox4 = new PictureBox();
            TutorialEn = new PictureBox();
            verticalPlatform = new PictureBox();
            Sign1 = new PictureBox();
            Guide1 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            Guide3 = new Label();
            Guide4 = new Label();
            ButtonShow1 = new PictureBox();
            Button1 = new PictureBox();
            Sign3 = new PictureBox();
            verticalPlatform2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            Sign2 = new PictureBox();
            Guide2 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            Sign4 = new PictureBox();
            Guide5 = new Label();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            LavaThing = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            LavaThing2 = new PictureBox();
            pictureBox11 = new PictureBox();
            Open = new PictureBox();
            Closed = new PictureBox();
            Key = new PictureBox();
            Knob = new PictureBox();
            label1 = new Label();
            label5 = new Label();
            Sign5 = new PictureBox();
            Guide6 = new Label();
            Show = new PictureBox();
            Sign6 = new PictureBox();
            A2 = new Label();
            A1 = new Label();
            A3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)e1Patrol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TutorialEn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)verticalPlatform).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sign1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ButtonShow1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Button1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sign3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)verticalPlatform2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sign2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sign4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LavaThing).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LavaThing2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Open).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Closed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Key).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Knob).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sign5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Show).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sign6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)A3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.platform;
            pictureBox1.Location = new Point(-1, 802);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 11);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "platform";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.platform;
            pictureBox2.Location = new Point(-1, 651);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1288, 11);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "platform";
            // 
            // player
            // 
            player.BackColor = Color.RosyBrown;
            player.Location = new Point(84, 773);
            player.Name = "player";
            player.Size = new Size(19, 28);
            player.TabIndex = 2;
            player.TabStop = false;
            player.Visible = false;
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += MainEventTimer;
            // 
            // e1Patrol
            // 
            e1Patrol.BackgroundImage = Properties.Resources.platform;
            e1Patrol.Location = new Point(510, 802);
            e1Patrol.Name = "e1Patrol";
            e1Patrol.Size = new Size(260, 11);
            e1Patrol.SizeMode = PictureBoxSizeMode.StretchImage;
            e1Patrol.TabIndex = 3;
            e1Patrol.TabStop = false;
            e1Patrol.Tag = "platform";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.platform;
            pictureBox4.Location = new Point(769, 802);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(654, 11);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "platform";
            // 
            // TutorialEn
            // 
            TutorialEn.BackColor = Color.Red;
            TutorialEn.Location = new Point(517, 773);
            TutorialEn.Name = "TutorialEn";
            TutorialEn.Size = new Size(17, 28);
            TutorialEn.TabIndex = 5;
            TutorialEn.TabStop = false;
            TutorialEn.Tag = "Enemy";
            // 
            // verticalPlatform
            // 
            verticalPlatform.BackColor = Color.Sienna;
            verticalPlatform.Location = new Point(1298, 788);
            verticalPlatform.Name = "verticalPlatform";
            verticalPlatform.Size = new Size(125, 10);
            verticalPlatform.TabIndex = 6;
            verticalPlatform.TabStop = false;
            verticalPlatform.Tag = "platform";
            verticalPlatform.Visible = false;
            // 
            // Sign1
            // 
            Sign1.BackColor = Color.Brown;
            Sign1.Location = new Point(395, 788);
            Sign1.Name = "Sign1";
            Sign1.Size = new Size(13, 16);
            Sign1.TabIndex = 7;
            Sign1.TabStop = false;
            // 
            // Guide1
            // 
            Guide1.AutoSize = true;
            Guide1.Location = new Point(429, 698);
            Guide1.Name = "Guide1";
            Guide1.Size = new Size(181, 19);
            Guide1.TabIndex = 8;
            Guide1.Text = "Try jumping over the enemy";
            Guide1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 19);
            label2.TabIndex = 9;
            label2.Text = "Controls :";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.platform;
            pictureBox3.Location = new Point(135, 500);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1288, 11);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "platform";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Sienna;
            pictureBox5.Location = new Point(0, 82);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1423, 10);
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "";
            // 
            // Guide3
            // 
            Guide3.AutoSize = true;
            Guide3.Location = new Point(164, 562);
            Guide3.Name = "Guide3";
            Guide3.Size = new Size(218, 19);
            Guide3.TabIndex = 13;
            Guide3.Text = "The Moving Platform has left you!";
            Guide3.Visible = false;
            // 
            // Guide4
            // 
            Guide4.AutoSize = true;
            Guide4.Location = new Point(164, 581);
            Guide4.Name = "Guide4";
            Guide4.Size = new Size(147, 19);
            Guide4.TabIndex = 14;
            Guide4.Text = "Try pushing the button";
            Guide4.Visible = false;
            // 
            // ButtonShow1
            // 
            ButtonShow1.BackColor = Color.DarkGray;
            ButtonShow1.Location = new Point(327, 581);
            ButtonShow1.Name = "ButtonShow1";
            ButtonShow1.Size = new Size(17, 16);
            ButtonShow1.TabIndex = 15;
            ButtonShow1.TabStop = false;
            ButtonShow1.Tag = "";
            ButtonShow1.Visible = false;
            // 
            // Button1
            // 
            Button1.BackColor = Color.DarkGray;
            Button1.Location = new Point(163, 636);
            Button1.Name = "Button1";
            Button1.Size = new Size(17, 16);
            Button1.TabIndex = 16;
            Button1.TabStop = false;
            Button1.Tag = "";
            // 
            // Sign3
            // 
            Sign3.BackColor = Color.Brown;
            Sign3.Location = new Point(498, 636);
            Sign3.Name = "Sign3";
            Sign3.Size = new Size(13, 16);
            Sign3.TabIndex = 17;
            Sign3.TabStop = false;
            // 
            // verticalPlatform2
            // 
            verticalPlatform2.BackColor = Color.Sienna;
            verticalPlatform2.Location = new Point(-1, 502);
            verticalPlatform2.Name = "verticalPlatform2";
            verticalPlatform2.Size = new Size(125, 10);
            verticalPlatform2.TabIndex = 18;
            verticalPlatform2.TabStop = false;
            verticalPlatform2.Tag = "platform";
            verticalPlatform2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 40);
            label3.Name = "label3";
            label3.Size = new Size(120, 19);
            label3.TabIndex = 20;
            label3.Text = "A - To Move Left";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 62);
            label4.Name = "label4";
            label4.Size = new Size(122, 19);
            label4.TabIndex = 21;
            label4.Text = "D - To Move right";
            // 
            // Sign2
            // 
            Sign2.BackColor = Color.Brown;
            Sign2.Location = new Point(1106, 786);
            Sign2.Name = "Sign2";
            Sign2.Size = new Size(13, 16);
            Sign2.TabIndex = 22;
            Sign2.TabStop = false;
            // 
            // Guide2
            // 
            Guide2.AutoSize = true;
            Guide2.Location = new Point(1080, 732);
            Guide2.Name = "Guide2";
            Guide2.Size = new Size(179, 19);
            Guide2.TabIndex = 23;
            Guide2.Text = "Try Getting on the Platform";
            Guide2.Visible = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources.platform;
            pictureBox6.Location = new Point(286, 487);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(113, 16);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 24;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "platform";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.OrangeRed;
            pictureBox7.Location = new Point(395, 486);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(1028, 16);
            pictureBox7.TabIndex = 25;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "Lava";
            // 
            // Sign4
            // 
            Sign4.BackColor = Color.Brown;
            Sign4.Location = new Point(201, 484);
            Sign4.Name = "Sign4";
            Sign4.Size = new Size(13, 16);
            Sign4.TabIndex = 26;
            Sign4.TabStop = false;
            // 
            // Guide5
            // 
            Guide5.AutoSize = true;
            Guide5.Location = new Point(125, 395);
            Guide5.Name = "Guide5";
            Guide5.Size = new Size(260, 19);
            Guide5.TabIndex = 27;
            Guide5.Text = "Avoid Touching The Lava It will Kill you!";
            Guide5.Visible = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = Properties.Resources.platform;
            pictureBox8.Location = new Point(429, 424);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(113, 16);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 28;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "platform";
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImage = Properties.Resources.platform;
            pictureBox9.Location = new Point(633, 366);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(113, 16);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 29;
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "platform";
            // 
            // pictureBox10
            // 
            pictureBox10.BackgroundImage = Properties.Resources.platform;
            pictureBox10.Location = new Point(815, 424);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(113, 16);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 30;
            pictureBox10.TabStop = false;
            pictureBox10.Tag = "platform";
            // 
            // LavaThing
            // 
            LavaThing.BackColor = Color.OrangeRed;
            LavaThing.Location = new Point(779, 478);
            LavaThing.Name = "LavaThing";
            LavaThing.Size = new Size(10, 16);
            LavaThing.TabIndex = 32;
            LavaThing.TabStop = false;
            LavaThing.Tag = "Lava";
            // 
            // pictureBox12
            // 
            pictureBox12.BackgroundImage = Properties.Resources.platform;
            pictureBox12.Location = new Point(1298, 294);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(125, 16);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 33;
            pictureBox12.TabStop = false;
            pictureBox12.Tag = "platform";
            // 
            // pictureBox13
            // 
            pictureBox13.BackgroundImage = Properties.Resources.platform;
            pictureBox13.Location = new Point(1000, 378);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(119, 16);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 34;
            pictureBox13.TabStop = false;
            pictureBox13.Tag = "platform";
            // 
            // pictureBox14
            // 
            pictureBox14.BackgroundImage = Properties.Resources.platform;
            pictureBox14.Location = new Point(1164, 343);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(104, 16);
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox14.TabIndex = 35;
            pictureBox14.TabStop = false;
            pictureBox14.Tag = "platform";
            // 
            // LavaThing2
            // 
            LavaThing2.BackColor = Color.OrangeRed;
            LavaThing2.Location = new Point(958, 353);
            LavaThing2.Name = "LavaThing2";
            LavaThing2.Size = new Size(10, 16);
            LavaThing2.TabIndex = 36;
            LavaThing2.TabStop = false;
            LavaThing2.Tag = "Lava";
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.IndianRed;
            pictureBox11.Location = new Point(-1, 687);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(79, 115);
            pictureBox11.TabIndex = 37;
            pictureBox11.TabStop = false;
            // 
            // Open
            // 
            Open.BackColor = Color.Black;
            Open.Location = new Point(5, 698);
            Open.Name = "Open";
            Open.Size = new Size(66, 104);
            Open.TabIndex = 38;
            Open.TabStop = false;
            Open.Visible = false;
            // 
            // Closed
            // 
            Closed.BackColor = Color.Snow;
            Closed.Location = new Point(5, 698);
            Closed.Name = "Closed";
            Closed.Size = new Size(66, 104);
            Closed.TabIndex = 39;
            Closed.TabStop = false;
            // 
            // Key
            // 
            Key.BackColor = Color.Yellow;
            Key.Location = new Point(1324, 265);
            Key.Name = "Key";
            Key.Size = new Size(73, 24);
            Key.TabIndex = 40;
            Key.TabStop = false;
            // 
            // Knob
            // 
            Knob.BackColor = Color.Yellow;
            Knob.Location = new Point(52, 732);
            Knob.Name = "Knob";
            Knob.Size = new Size(10, 24);
            Knob.TabIndex = 41;
            Knob.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 21);
            label1.Name = "label1";
            label1.Size = new Size(91, 19);
            label1.TabIndex = 19;
            label1.Text = "W - To Jump";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(214, 21);
            label5.Name = "label5";
            label5.Size = new Size(174, 19);
            label5.TabIndex = 42;
            label5.Text = "F - to interact with objects";
            // 
            // Sign5
            // 
            Sign5.BackColor = Color.Brown;
            Sign5.Location = new Point(645, 353);
            Sign5.Name = "Sign5";
            Sign5.Size = new Size(13, 16);
            Sign5.TabIndex = 43;
            Sign5.TabStop = false;
            // 
            // Guide6
            // 
            Guide6.AutoSize = true;
            Guide6.Location = new Point(582, 292);
            Guide6.Name = "Guide6";
            Guide6.Size = new Size(228, 19);
            Guide6.TabIndex = 44;
            Guide6.Text = "Get The Key to Complete the Level";
            Guide6.Visible = false;
            // 
            // Show
            // 
            Show.BackColor = Color.Yellow;
            Show.Location = new Point(826, 287);
            Show.Name = "Show";
            Show.Size = new Size(73, 24);
            Show.TabIndex = 45;
            Show.TabStop = false;
            Show.Visible = false;
            // 
            // Sign6
            // 
            Sign6.BackColor = Color.Brown;
            Sign6.Location = new Point(163, 786);
            Sign6.Name = "Sign6";
            Sign6.Size = new Size(13, 16);
            Sign6.TabIndex = 46;
            Sign6.TabStop = false;
            // 
            // A2
            // 
            A2.AutoSize = true;
            A2.Location = new Point(94, 711);
            A2.Name = "A2";
            A2.Size = new Size(110, 19);
            A2.TabIndex = 47;
            A2.Text = "This is a Sign -->";
            // 
            // A1
            // 
            A1.AutoSize = true;
            A1.Location = new Point(163, 687);
            A1.Name = "A1";
            A1.Size = new Size(222, 19);
            A1.TabIndex = 48;
            A1.Text = "Go to it for hints (and other things)";
            // 
            // A3
            // 
            A3.BackColor = Color.Brown;
            A3.Location = new Point(214, 713);
            A3.Name = "A3";
            A3.Size = new Size(13, 16);
            A3.TabIndex = 49;
            A3.TabStop = false;
            // 
            // Tutorial_lvl_1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1423, 812);
            Controls.Add(A3);
            Controls.Add(A1);
            Controls.Add(A2);
            Controls.Add(Sign6);
            Controls.Add(Show);
            Controls.Add(Guide6);
            Controls.Add(Sign5);
            Controls.Add(label5);
            Controls.Add(Knob);
            Controls.Add(Key);
            Controls.Add(Closed);
            Controls.Add(Open);
            Controls.Add(pictureBox11);
            Controls.Add(LavaThing2);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox12);
            Controls.Add(LavaThing);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(Guide5);
            Controls.Add(Sign4);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(Guide2);
            Controls.Add(Sign2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(verticalPlatform2);
            Controls.Add(Sign3);
            Controls.Add(Button1);
            Controls.Add(ButtonShow1);
            Controls.Add(Guide4);
            Controls.Add(Guide3);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(Guide1);
            Controls.Add(Sign1);
            Controls.Add(verticalPlatform);
            Controls.Add(TutorialEn);
            Controls.Add(pictureBox4);
            Controls.Add(e1Patrol);
            Controls.Add(player);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Font = new Font("Sylfaen", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tutorial_lvl_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tutorial_lvl_1";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)e1Patrol).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)TutorialEn).EndInit();
            ((System.ComponentModel.ISupportInitialize)verticalPlatform).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sign1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)ButtonShow1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Button1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sign3).EndInit();
            ((System.ComponentModel.ISupportInitialize)verticalPlatform2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sign2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sign4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)LavaThing).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)LavaThing2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)Open).EndInit();
            ((System.ComponentModel.ISupportInitialize)Closed).EndInit();
            ((System.ComponentModel.ISupportInitialize)Key).EndInit();
            ((System.ComponentModel.ISupportInitialize)Knob).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sign5).EndInit();
            ((System.ComponentModel.ISupportInitialize)Show).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sign6).EndInit();
            ((System.ComponentModel.ISupportInitialize)A3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
        private PictureBox e1Patrol;
        private PictureBox pictureBox4;
        private PictureBox TutorialEn;
        private PictureBox verticalPlatform;
        private PictureBox Sign1;
        private Label Guide1;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private Label Guide3;
        private Label Guide4;
        private PictureBox ButtonShow1;
        private PictureBox Button1;
        private PictureBox Sign3;
        private PictureBox verticalPlatform2;
        private Label label3;
        private Label label4;
        private PictureBox Sign2;
        private Label Guide2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox Sign4;
        private Label Guide5;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox LavaThing;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox LavaThing2;
        private PictureBox pictureBox11;
        private PictureBox Open;
        private PictureBox Closed;
        private PictureBox Key;
        private PictureBox Knob;
        private Label label1;
        private Label label5;
        private PictureBox Sign5;
        private Label Guide6;
        private PictureBox Show;
        private PictureBox Sign6;
        private Label A2;
        private Label A1;
        private PictureBox A3;
    }
}