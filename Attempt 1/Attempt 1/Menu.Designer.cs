namespace Attempt_1
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Play = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Play
            // 
            Play.Location = new Point(474, 447);
            Play.Name = "Play";
            Play.Size = new Size(309, 49);
            Play.TabIndex = 0;
            Play.Text = "Play";
            Play.UseVisualStyleBackColor = true;
            Play.Click += Play_Click;
            // 
            // button2
            // 
            button2.Location = new Point(474, 528);
            button2.Name = "button2";
            button2.Size = new Size(309, 49);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 798);
            Controls.Add(button2);
            Controls.Add(Play);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Play;
        private Button button2;
    }
}
