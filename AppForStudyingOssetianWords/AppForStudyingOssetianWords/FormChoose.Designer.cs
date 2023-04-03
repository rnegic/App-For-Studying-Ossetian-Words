namespace AppForStudyingOssetianWords
{
    partial class FormChoose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChoose));
            this.labelChoose = new System.Windows.Forms.Label();
            this.buttonAnimalsOnField = new System.Windows.Forms.Button();
            this.buttonWords = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelChoose
            // 
            this.labelChoose.AutoSize = true;
            this.labelChoose.BackColor = System.Drawing.Color.Transparent;
            this.labelChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChoose.Location = new System.Drawing.Point(39, 82);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(501, 42);
            this.labelChoose.TabIndex = 1;
            this.labelChoose.Text = "Выберите режим обучения:";
            // 
            // buttonAnimalsOnField
            // 
            this.buttonAnimalsOnField.Location = new System.Drawing.Point(46, 151);
            this.buttonAnimalsOnField.Name = "buttonAnimalsOnField";
            this.buttonAnimalsOnField.Size = new System.Drawing.Size(247, 235);
            this.buttonAnimalsOnField.TabIndex = 2;
            this.buttonAnimalsOnField.Text = "Здесь в будущем будет красивая картинка";
            this.buttonAnimalsOnField.UseVisualStyleBackColor = true;
            this.buttonAnimalsOnField.Click += new System.EventHandler(this.buttonAnimalsOnField_Click);
            // 
            // buttonWords
            // 
            this.buttonWords.Location = new System.Drawing.Point(369, 151);
            this.buttonWords.Name = "buttonWords";
            this.buttonWords.Size = new System.Drawing.Size(247, 235);
            this.buttonWords.TabIndex = 3;
            this.buttonWords.Text = "и здесь";
            this.buttonWords.UseVisualStyleBackColor = true;
            this.buttonWords.Click += new System.EventHandler(this.buttonWords_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(689, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 235);
            this.button3.TabIndex = 4;
            this.button3.Text = "и здесь";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 144);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(366, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 126);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(674, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 126);
            this.label3.TabIndex = 7;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(46, 613);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(107, 27);
            this.buttonReturn.TabIndex = 8;
            this.buttonReturn.Text = "Назад";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // FormChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonWords);
            this.Controls.Add(this.buttonAnimalsOnField);
            this.Controls.Add(this.labelChoose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormChoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор режима";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChoose;
        private System.Windows.Forms.Button buttonAnimalsOnField;
        private System.Windows.Forms.Button buttonWords;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReturn;
    }
}