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
            this.pictureBoxLandscape = new System.Windows.Forms.PictureBox();
            this.pictureBoxMainCharacter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLandscape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainCharacter)).BeginInit();
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
            // pictureBoxLandscape
            // 
            this.pictureBoxLandscape.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLandscape.Image = global::AppForStudyingOssetianWords.Properties.Resources.landscape;
            this.pictureBoxLandscape.Location = new System.Drawing.Point(0, -2);
            this.pictureBoxLandscape.Name = "pictureBoxLandscape";
            this.pictureBoxLandscape.Size = new System.Drawing.Size(1920, 309);
            this.pictureBoxLandscape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLandscape.TabIndex = 1;
            this.pictureBoxLandscape.TabStop = false;
            // 
            // pictureBoxMainCharacter
            // 
            this.pictureBoxMainCharacter.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMainCharacter.Image = global::AppForStudyingOssetianWords.Properties.Resources.mainCharacterForward;
            this.pictureBoxMainCharacter.Location = new System.Drawing.Point(95, 711);
            this.pictureBoxMainCharacter.Name = "pictureBoxMainCharacter";
            this.pictureBoxMainCharacter.Size = new System.Drawing.Size(114, 103);
            this.pictureBoxMainCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMainCharacter.TabIndex = 0;
            this.pictureBoxMainCharacter.TabStop = false;
            // 
            // FormAnimalsOnField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(214)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1536, 762);
            this.Controls.Add(this.pictureBoxMainCharacter);
            this.Controls.Add(this.pictureBoxLandscape);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAnimalsOnField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Животные на поле";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.global_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAnimalsOnField_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLandscape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainCharacter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.PictureBox pictureBoxMainCharacter;
        private System.Windows.Forms.Timer timerAnimation;
        private System.Windows.Forms.PictureBox pictureBoxLandscape;
    }
}