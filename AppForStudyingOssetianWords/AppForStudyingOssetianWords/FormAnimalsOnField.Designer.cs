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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnimalsOnField));
            this.pictureBoxMainCharacter = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMainCharacter
            // 
            this.pictureBoxMainCharacter.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainCharacter.Image")));
            this.pictureBoxMainCharacter.Location = new System.Drawing.Point(31, 598);
            this.pictureBoxMainCharacter.Name = "pictureBoxMainCharacter";
            this.pictureBoxMainCharacter.Size = new System.Drawing.Size(131, 110);
            this.pictureBoxMainCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMainCharacter.TabIndex = 0;
            this.pictureBoxMainCharacter.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 25;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormAnimalsOnField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1384, 735);
            this.Controls.Add(this.pictureBoxMainCharacter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAnimalsOnField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Животные на поле";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAnimalsOnField_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainCharacter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMainCharacter;
        private System.Windows.Forms.Timer timer;
    }
}