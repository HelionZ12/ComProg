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
            SuspendLayout();
            // 
            // lvl1
            // 
            lvl1.Location = new Point(587, 71);
            lvl1.Name = "lvl1";
            lvl1.Size = new Size(113, 29);
            lvl1.TabIndex = 0;
            lvl1.Text = "Tutorial Level";
            lvl1.UseVisualStyleBackColor = true;
            lvl1.Click += lvl1_Click;
            // 
            // Levels
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 796);
            Controls.Add(lvl1);
            Name = "Levels";
            StartPosition = FormStartPosition.Manual;
            Text = "Levels";
            ResumeLayout(false);
        }

        #endregion

        private Button lvl1;
    }
}