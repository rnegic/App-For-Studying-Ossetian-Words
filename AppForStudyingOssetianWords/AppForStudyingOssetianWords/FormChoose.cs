using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppForStudyingOssetianWords
{
    public partial class FormChoose : Form
    {
        public FormChoose()
        {
            InitializeComponent();
        }

        private void buttonAnimalsOnField_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAnimalsOnField formAnimalsOnField = new FormAnimalsOnField();
            formAnimalsOnField.Show();
        }

        private void buttonWords_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCombineWordsImages formCombineWordsImages = new FormCombineWordsImages();
            formCombineWordsImages.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCombineSoundWord formCombineSoundWord = new FormCombineSoundWord();
            formCombineSoundWord.Show();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
        }
    }
}
