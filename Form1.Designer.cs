namespace Flappy_Bird
{
    partial class Form1
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
            birdPlayer = new PictureBox();
            pipUp1 = new PictureBox();
            pipLow1 = new PictureBox();
            pipUp2 = new PictureBox();
            pipLow2 = new PictureBox();
            pipUp3 = new PictureBox();
            pipLow3 = new PictureBox();
            pipUp4 = new PictureBox();
            pipLow4 = new PictureBox();
            pipUp5 = new PictureBox();
            pipLow5 = new PictureBox();
            pipUp6 = new PictureBox();
            pipLow6 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            scoreLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)birdPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipUp1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipLow1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipUp2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipLow2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipUp3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipLow3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipUp4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipLow4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipUp5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipLow5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipUp6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipLow6).BeginInit();
            SuspendLayout();
            // 
            // birdPlayer
            // 
            birdPlayer.BackgroundImage = Properties.Resources.flappy_bird;
            birdPlayer.Location = new Point(83, 127);
            birdPlayer.Name = "birdPlayer";
            birdPlayer.Size = new Size(57, 41);
            birdPlayer.TabIndex = 0;
            birdPlayer.TabStop = false;
            // 
            // pipUp1
            // 
            pipUp1.BackgroundImage = Properties.Resources.pipUp1;
            pipUp1.Location = new Point(206, -98);
            pipUp1.Name = "pipUp1";
            pipUp1.Size = new Size(108, 205);
            pipUp1.TabIndex = 1;
            pipUp1.TabStop = false;
            // 
            // pipLow1
            // 
            pipLow1.BackgroundImage = Properties.Resources.pipLow1;
            pipLow1.Location = new Point(206, 197);
            pipLow1.Name = "pipLow1";
            pipLow1.Size = new Size(108, 205);
            pipLow1.TabIndex = 2;
            pipLow1.TabStop = false;
            // 
            // pipUp2
            // 
            pipUp2.BackgroundImage = Properties.Resources.pipUp1;
            pipUp2.Location = new Point(387, -142);
            pipUp2.Name = "pipUp2";
            pipUp2.Size = new Size(108, 205);
            pipUp2.TabIndex = 1;
            pipUp2.TabStop = false;
            // 
            // pipLow2
            // 
            pipLow2.BackgroundImage = Properties.Resources.pipLow1;
            pipLow2.Location = new Point(387, 238);
            pipLow2.Name = "pipLow2";
            pipLow2.Size = new Size(108, 205);
            pipLow2.TabIndex = 2;
            pipLow2.TabStop = false;
            // 
            // pipUp3
            // 
            pipUp3.BackgroundImage = Properties.Resources.pipUp1;
            pipUp3.Location = new Point(527, -168);
            pipUp3.Name = "pipUp3";
            pipUp3.Size = new Size(108, 205);
            pipUp3.TabIndex = 1;
            pipUp3.TabStop = false;
            // 
            // pipLow3
            // 
            pipLow3.BackgroundImage = Properties.Resources.pipLow1;
            pipLow3.Location = new Point(527, 168);
            pipLow3.Name = "pipLow3";
            pipLow3.Size = new Size(108, 205);
            pipLow3.TabIndex = 2;
            pipLow3.TabStop = false;
            // 
            // pipUp4
            // 
            pipUp4.BackgroundImage = Properties.Resources.pipUp1;
            pipUp4.Location = new Point(783, -67);
            pipUp4.Name = "pipUp4";
            pipUp4.Size = new Size(108, 205);
            pipUp4.TabIndex = 1;
            pipUp4.TabStop = false;
            // 
            // pipLow4
            // 
            pipLow4.BackgroundImage = Properties.Resources.pipLow1;
            pipLow4.Location = new Point(783, 236);
            pipLow4.Name = "pipLow4";
            pipLow4.Size = new Size(108, 205);
            pipLow4.TabIndex = 2;
            pipLow4.TabStop = false;
            // 
            // pipUp5
            // 
            pipUp5.BackgroundImage = Properties.Resources.pipUp1;
            pipUp5.Location = new Point(957, -129);
            pipUp5.Name = "pipUp5";
            pipUp5.Size = new Size(108, 205);
            pipUp5.TabIndex = 1;
            pipUp5.TabStop = false;
            // 
            // pipLow5
            // 
            pipLow5.BackgroundImage = Properties.Resources.pipLow1;
            pipLow5.Location = new Point(957, 227);
            pipLow5.Name = "pipLow5";
            pipLow5.Size = new Size(108, 205);
            pipLow5.TabIndex = 2;
            pipLow5.TabStop = false;
            // 
            // pipUp6
            // 
            pipUp6.BackgroundImage = Properties.Resources.pipUp1;
            pipUp6.Location = new Point(1150, -159);
            pipUp6.Name = "pipUp6";
            pipUp6.Size = new Size(108, 205);
            pipUp6.TabIndex = 1;
            pipUp6.TabStop = false;
            // 
            // pipLow6
            // 
            pipLow6.BackgroundImage = Properties.Resources.pipLow1;
            pipLow6.Location = new Point(1150, 145);
            pipLow6.Name = "pipLow6";
            pipLow6.Size = new Size(108, 205);
            pipLow6.TabIndex = 2;
            pipLow6.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 300;
            timer1.Tick += timer1_Tick;
            // 
            // scoreLbl
            // 
            scoreLbl.AutoSize = true;
            scoreLbl.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreLbl.Location = new Point(12, 14);
            scoreLbl.Name = "scoreLbl";
            scoreLbl.Size = new Size(33, 40);
            scoreLbl.TabIndex = 3;
            scoreLbl.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(628, 303);
            Controls.Add(scoreLbl);
            Controls.Add(pipLow4);
            Controls.Add(pipUp4);
            Controls.Add(pipLow6);
            Controls.Add(pipUp6);
            Controls.Add(pipLow5);
            Controls.Add(pipUp5);
            Controls.Add(pipLow3);
            Controls.Add(pipUp3);
            Controls.Add(pipLow2);
            Controls.Add(pipUp2);
            Controls.Add(pipLow1);
            Controls.Add(pipUp1);
            Controls.Add(birdPlayer);
            MaximumSize = new Size(644, 342);
            MinimumSize = new Size(644, 342);
            Name = "Form1";
            Text = "Flappy Bird";
            ((System.ComponentModel.ISupportInitialize)birdPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipUp1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipLow1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipUp2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipLow2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipUp3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipLow3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipUp4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipLow4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipUp5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipLow5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipUp6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipLow6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox birdPlayer;
        private PictureBox pipUp1;
        private PictureBox pipLow1;
        private PictureBox pipUp2;
        private PictureBox pipLow2;
        private PictureBox pipUp3;
        private PictureBox pipLow3;
        private PictureBox pipUp4;
        private PictureBox pipLow4;
        private PictureBox pipUp5;
        private PictureBox pipLow5;
        private PictureBox pipUp6;
        private PictureBox pipLow6;
        private System.Windows.Forms.Timer timer1;
        private Label scoreLbl;
    }
}
