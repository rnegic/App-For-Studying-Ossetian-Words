using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppForStudyingOssetianWords
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAnimalsOnField formAnimalsOnField = new FormAnimalsOnField();
            formAnimalsOnField.Show();
        }

        private void buttonResults_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormResults formResults = new FormResults();
            formResults.Show();
        }
    }
}
