namespace DVDLogo
{
    partial class DVDForm
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
            components = new System.ComponentModel.Container();
            BouncingLogo = new PictureBox();
            LogoTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)BouncingLogo).BeginInit();
            SuspendLayout();
            // 
            // BouncingLogo
            // 
            BouncingLogo.BackColor = Color.Red;
            BouncingLogo.Location = new Point(364, 188);
            BouncingLogo.Name = "BouncingLogo";
            BouncingLogo.Size = new Size(50, 50);
            BouncingLogo.TabIndex = 0;
            BouncingLogo.TabStop = false;
            // 
            // LogoTimer
            // 
            LogoTimer.Enabled = true;
            LogoTimer.Interval = 20;
            LogoTimer.Tick += LogoTimer_Tick;
            // 
            // DVDForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(BouncingLogo);
            Name = "DVDForm";
            Text = "Form1";
            ResizeEnd += DVDForm_Resize;
            ((System.ComponentModel.ISupportInitialize)BouncingLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox BouncingLogo;
        private System.Windows.Forms.Timer LogoTimer;
    }
}