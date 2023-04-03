using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppForStudyingOssetianWords
{
    public partial class FormResults : Form
    {
        public FormResults()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
        }
    }
}
