namespace GunBlitz
{
    partial class World1Scene_Opening
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
            PlayerPort = new PictureBox();
            Next = new PictureBox();
            Dialog = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PlayerPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Next).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dialog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PlayerPort
            // 
            PlayerPort.BackColor = Color.Transparent;
            PlayerPort.Image = Properties.Resources.Sample_Idle;
            PlayerPort.Location = new Point(598, 34);
            PlayerPort.Name = "PlayerPort";
            PlayerPort.Size = new Size(285, 288);
            PlayerPort.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerPort.TabIndex = 54;
            PlayerPort.TabStop = false;
            // 
            // Next
            // 
            Next.Image = Properties.Resources.NextTemp;
            Next.Location = new Point(1194, 650);
            Next.Name = "Next";
            Next.Size = new Size(175, 68);
            Next.SizeMode = PictureBoxSizeMode.StretchImage;
            Next.TabIndex = 55;
            Next.TabStop = false;
            Next.Click += pictureBox1_Click;
            // 
            // Dialog
            // 
            Dialog.Image = Properties.Resources.World1Opening1;
            Dialog.Location = new Point(307, 360);
            Dialog.Name = "Dialog";
            Dialog.Size = new Size(891, 252);
            Dialog.SizeMode = PictureBoxSizeMode.AutoSize;
            Dialog.TabIndex = 56;
            Dialog.TabStop = false;
            Dialog.Click += Dialog_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SkipTemp;
            pictureBox1.Location = new Point(1258, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // World1Scene_Opening
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1381, 730);
            Controls.Add(pictureBox1);
            Controls.Add(Dialog);
            Controls.Add(Next);
            Controls.Add(PlayerPort);
            Name = "World1Scene_Opening";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "World1Scene_Opening";
            ((System.ComponentModel.ISupportInitialize)PlayerPort).EndInit();
            ((System.ComponentModel.ISupportInitialize)Next).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dialog).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PlayerPort;
        private PictureBox Next;
        private PictureBox Dialog;
        private PictureBox pictureBox1;
    }
}