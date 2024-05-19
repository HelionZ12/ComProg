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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            Sign2 = new PictureBox();
            Guide2 = new Label();
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
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.platform;
            pictureBox1.Location = new Point(-1, 844);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 12);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "platform";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.platform;
            pictureBox2.Location = new Point(-1, 685);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1288, 12);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "platform";
            // 
            // player
            // 
            player.BackColor = Color.RosyBrown;
            player.Location = new Point(52, 808);
            player.Name = "player";
            player.Size = new Size(19, 30);
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
            e1Patrol.Location = new Point(510, 844);
            e1Patrol.Name = "e1Patrol";
            e1Patrol.Size = new Size(260, 12);
            e1Patrol.SizeMode = PictureBoxSizeMode.StretchImage;
            e1Patrol.TabIndex = 3;
            e1Patrol.TabStop = false;
            e1Patrol.Tag = "platform";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.platform;
            pictureBox4.Location = new Point(769, 844);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(654, 12);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "platform";
            // 
            // TutorialEn
            // 
            TutorialEn.BackColor = Color.Red;
            TutorialEn.Location = new Point(517, 814);
            TutorialEn.Name = "TutorialEn";
            TutorialEn.Size = new Size(17, 30);
            TutorialEn.TabIndex = 5;
            TutorialEn.TabStop = false;
            TutorialEn.Tag = "Enemy";
            // 
            // verticalPlatform
            // 
            verticalPlatform.BackColor = Color.Sienna;
            verticalPlatform.Location = new Point(1298, 829);
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
            Sign1.Location = new Point(283, 814);
            Sign1.Name = "Sign1";
            Sign1.Size = new Size(17, 30);
            Sign1.TabIndex = 7;
            Sign1.TabStop = false;
            // 
            // Guide1
            // 
            Guide1.AutoSize = true;
            Guide1.Location = new Point(429, 735);
            Guide1.Name = "Guide1";
            Guide1.Size = new Size(193, 20);
            Guide1.TabIndex = 8;
            Guide1.Text = "Try jumping over the enemy";
            Guide1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 9;
            label2.Text = "Controls :";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.platform;
            pictureBox3.Location = new Point(135, 526);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1288, 12);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "platform";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Sienna;
            pictureBox5.Location = new Point(0, 86);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1423, 10);
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "";
            // 
            // Guide3
            // 
            Guide3.AutoSize = true;
            Guide3.Location = new Point(164, 592);
            Guide3.Name = "Guide3";
            Guide3.Size = new Size(232, 20);
            Guide3.TabIndex = 13;
            Guide3.Text = "The Moving Platform has left you!";
            Guide3.Visible = false;
            // 
            // Guide4
            // 
            Guide4.AutoSize = true;
            Guide4.Location = new Point(164, 612);
            Guide4.Name = "Guide4";
            Guide4.Size = new Size(157, 20);
            Guide4.TabIndex = 14;
            Guide4.Text = "Try pushing the button";
            Guide4.Visible = false;
            // 
            // ButtonShow1
            // 
            ButtonShow1.BackColor = Color.DarkGray;
            ButtonShow1.Location = new Point(327, 612);
            ButtonShow1.Name = "ButtonShow1";
            ButtonShow1.Size = new Size(17, 30);
            ButtonShow1.TabIndex = 15;
            ButtonShow1.TabStop = false;
            ButtonShow1.Tag = "";
            ButtonShow1.Visible = false;
            // 
            // Button1
            // 
            Button1.BackColor = Color.DarkGray;
            Button1.Location = new Point(163, 657);
            Button1.Name = "Button1";
            Button1.Size = new Size(17, 30);
            Button1.TabIndex = 16;
            Button1.TabStop = false;
            Button1.Tag = "";
            // 
            // Sign3
            // 
            Sign3.BackColor = Color.Brown;
            Sign3.Location = new Point(494, 657);
            Sign3.Name = "Sign3";
            Sign3.Size = new Size(17, 30);
            Sign3.TabIndex = 17;
            Sign3.TabStop = false;
            // 
            // verticalPlatform2
            // 
            verticalPlatform2.BackColor = Color.Sienna;
            verticalPlatform2.Location = new Point(-1, 528);
            verticalPlatform2.Name = "verticalPlatform2";
            verticalPlatform2.Size = new Size(125, 10);
            verticalPlatform2.TabIndex = 18;
            verticalPlatform2.TabStop = false;
            verticalPlatform2.Tag = "platform";
            verticalPlatform2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-1, 20);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 19;
            label1.Text = "W - To Jump";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-1, 40);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 20;
            label3.Text = "A - To Move Left";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-1, 63);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 21;
            label4.Text = "D - To Move right";
            // 
            // Sign2
            // 
            Sign2.BackColor = Color.Brown;
            Sign2.Location = new Point(1102, 814);
            Sign2.Name = "Sign2";
            Sign2.Size = new Size(17, 30);
            Sign2.TabIndex = 22;
            Sign2.TabStop = false;
            // 
            // Guide2
            // 
            Guide2.AutoSize = true;
            Guide2.Location = new Point(1080, 770);
            Guide2.Name = "Guide2";
            Guide2.Size = new Size(188, 20);
            Guide2.TabIndex = 23;
            Guide2.Text = "Try Getting on the Platform";
            Guide2.Visible = false;
            // 
            // Tutorial_lvl_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 855);
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
        private Label label1;
        private Label label3;
        private Label label4;
        private PictureBox Sign2;
        private Label Guide2;
    }
}