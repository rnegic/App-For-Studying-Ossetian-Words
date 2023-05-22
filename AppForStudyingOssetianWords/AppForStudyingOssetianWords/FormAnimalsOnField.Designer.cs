namespace AppForStudyingOssetianWords
{
    partial class FormAnimalsOnField
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMainCharacter = new System.Windows.Forms.PictureBox();
            this.pictureBoxLandscape = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLandscape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 25;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerAnimation
            // 
            this.timerAnimation.Interval = 200;
            this.timerAnimation.Tick += new System.EventHandler(this.timerAnimation_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::AppForStudyingOssetianWords.Properties.Resources.grassButterflies;
            this.pictureBox3.Location = new System.Drawing.Point(1676, 459);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(172, 97);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AppForStudyingOssetianWords.Properties.Resources.grassButterflies;
            this.pictureBox1.Location = new System.Drawing.Point(4, 896);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxMainCharacter
            // 
            this.pictureBoxMainCharacter.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMainCharacter.Image = global::AppForStudyingOssetianWords.Properties.Resources.mainCharacterForward;
            this.pictureBoxMainCharacter.Location = new System.Drawing.Point(68, 459);
            this.pictureBoxMainCharacter.Name = "pictureBoxMainCharacter";
            this.pictureBoxMainCharacter.Size = new System.Drawing.Size(114, 103);
            this.pictureBoxMainCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMainCharacter.TabIndex = 0;
            this.pictureBoxMainCharacter.TabStop = false;
            // 
            // pictureBoxLandscape
            // 
            this.pictureBoxLandscape.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLandscape.Image = global::AppForStudyingOssetianWords.Properties.Resources.landscapeWithFence;
            this.pictureBoxLandscape.Location = new System.Drawing.Point(0, -2);
            this.pictureBoxLandscape.Name = "pictureBoxLandscape";
            this.pictureBoxLandscape.Size = new System.Drawing.Size(1920, 309);
            this.pictureBoxLandscape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLandscape.TabIndex = 1;
            this.pictureBoxLandscape.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::AppForStudyingOssetianWords.Properties.Resources.tree;
            this.pictureBox4.Location = new System.Drawing.Point(142, 750);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(127, 243);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::AppForStudyingOssetianWords.Properties.Resources.tree;
            this.pictureBox5.Location = new System.Drawing.Point(1796, 313);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(127, 243);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // FormAnimalsOnField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(214)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1536, 762);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxMainCharacter);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBoxLandscape);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAnimalsOnField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Животные на поле";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.global_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAnimalsOnField_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLandscape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.PictureBox pictureBoxMainCharacter;
        private System.Windows.Forms.Timer timerAnimation;
        private System.Windows.Forms.PictureBox pictureBoxLandscape;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}