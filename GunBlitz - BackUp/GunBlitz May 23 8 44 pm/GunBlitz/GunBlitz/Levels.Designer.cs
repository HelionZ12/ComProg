namespace GunBlitz
{
    partial class Levels
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
            lvl1 = new Button();
            lvl2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            Chap1Lvl1 = new Button();
            SuspendLayout();
            // 
            // lvl1
            // 
            lvl1.BackColor = Color.Green;
            lvl1.Location = new Point(73, 51);
            lvl1.Margin = new Padding(4, 3, 4, 3);
            lvl1.Name = "lvl1";
            lvl1.Size = new Size(60, 30);
            lvl1.TabIndex = 0;
            lvl1.Text = "lvl-1";
            lvl1.UseVisualStyleBackColor = false;
            lvl1.Click += lvl1_Click;
            // 
            // lvl2
            // 
            lvl2.BackColor = Color.Red;
            lvl2.Location = new Point(71, 87);
            lvl2.Margin = new Padding(4, 3, 4, 3);
            lvl2.Name = "lvl2";
            lvl2.Size = new Size(65, 30);
            lvl2.TabIndex = 1;
            lvl2.Text = "lvl-2";
            lvl2.UseVisualStyleBackColor = false;
            lvl2.Click += lvl2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1734, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 9);
            label2.Name = "label2";
            label2.Size = new Size(164, 21);
            label2.TabIndex = 3;
            label2.Text = "Tutorial Levels";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 184);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 5;
            label3.Text = "Chapter - 1";
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.Location = new Point(71, 123);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(65, 30);
            button1.TabIndex = 6;
            button1.Text = "lvl-3";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Chap1Lvl1
            // 
            Chap1Lvl1.BackColor = Color.Green;
            Chap1Lvl1.Location = new Point(73, 230);
            Chap1Lvl1.Margin = new Padding(4, 3, 4, 3);
            Chap1Lvl1.Name = "Chap1Lvl1";
            Chap1Lvl1.Size = new Size(60, 30);
            Chap1Lvl1.TabIndex = 7;
            Chap1Lvl1.Text = "lvl-1";
            Chap1Lvl1.UseVisualStyleBackColor = false;
            Chap1Lvl1.Click += Chap1Lvl1_Click;
            // 
            // Levels
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 724);
            Controls.Add(Chap1Lvl1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvl2);
            Controls.Add(lvl1);
            Font = new Font("Perpetua Titling MT", 10.8F, FontStyle.Underline, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Levels";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Level Select";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button lvl1;
        private Button lvl2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button Chap1Lvl1;
    }
}