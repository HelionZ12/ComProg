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
            SuspendLayout();
            // 
            // lvl1
            // 
            lvl1.Location = new Point(47, 47);
            lvl1.Name = "lvl1";
            lvl1.Size = new Size(113, 29);
            lvl1.TabIndex = 0;
            lvl1.Text = "Tutorial lvl-1";
            lvl1.UseVisualStyleBackColor = true;
            lvl1.Click += lvl1_Click;
            // 
            // lvl2
            // 
            lvl2.Location = new Point(47, 82);
            lvl2.Name = "lvl2";
            lvl2.Size = new Size(113, 29);
            lvl2.TabIndex = 1;
            lvl2.Text = "Tutorial lvl-2";
            lvl2.UseVisualStyleBackColor = true;
            lvl2.Click += lvl2_Click;
            // 
            // Levels
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 796);
            Controls.Add(lvl2);
            Controls.Add(lvl1);
            Name = "Levels";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Level Select";
            ResumeLayout(false);
        }

        #endregion

        private Button lvl1;
        private Button lvl2;
    }
}