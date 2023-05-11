using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppForStudyingOssetianWords
{
    public partial class FormAnimalsOnField : Form
    {

        List<PictureBox> animalPictureBoxes = new List<PictureBox>();
        Random random = new Random();
        string[] animals = {"wolf", "fox", "bear", "hare", "duck", "turtle", "squirrel", "cow", "cat", "dog"};
        public FormAnimalsOnField()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            //генерируем здесь ровно 10 PictureBox:

            for (int i = 0; i < 10; i++)
            {
                AddAnimalPictureBox(random.Next(10, 1600), random.Next(10, 800), animals[i]);
            }
        }

        private void AddAnimalPictureBox(int x, int y, string animal)
        {

            PictureBox newAnimal = new PictureBox();
            //newAnimal.Image = Properties.Resources.animalcow;
            string resourceName = "animal" + animal;
            newAnimal.Image = (Image)Properties.Resources.ResourceManager.GetObject(resourceName);

            newAnimal.Size = new Size(110, 110);
            newAnimal.SizeMode = PictureBoxSizeMode.StretchImage;
            newAnimal.Location = new Point(x, y);
            newAnimal.Tag = resourceName;

            // добавляем животное в список и на форму
            animalPictureBoxes.Add(newAnimal);
            this.Controls.Add(newAnimal);
        }

        private void FormAnimalsOnField_KeyDown(object sender, KeyEventArgs e)
        {
            //проверим, не выходит ли главный герой за пределы формы, прежде чем считывать нажатия клавиш
            if (!(pictureBoxMainCharacter.Location.X < 0 || pictureBoxMainCharacter.Location.X + pictureBoxMainCharacter.Width+30 > this.Width
              || pictureBoxMainCharacter.Location.Y < 0 || pictureBoxMainCharacter.Location.Y + pictureBoxMainCharacter.Height+45 > this.Height))
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        pictureBoxMainCharacter.Location = new Point(pictureBoxMainCharacter.Location.X - 10, pictureBoxMainCharacter.Location.Y);
                        break;
                    case Keys.Right:
                        pictureBoxMainCharacter.Location = new Point(pictureBoxMainCharacter.Location.X + 10, pictureBoxMainCharacter.Location.Y);
                        break;
                    case Keys.Up:
                        pictureBoxMainCharacter.Location = new Point(pictureBoxMainCharacter.Location.X, pictureBoxMainCharacter.Location.Y - 10);
                        break;
                    case Keys.Down:
                        pictureBoxMainCharacter.Location = new Point(pictureBoxMainCharacter.Location.X, pictureBoxMainCharacter.Location.Y + 10);
                        break;
                }
            }
            //если выходит, то можно двигаться только внутрь формы
            else
            {
                if (e.KeyCode == Keys.Left && pictureBoxMainCharacter.Location.X > 0)
                {
                    pictureBoxMainCharacter.Location = new Point(pictureBoxMainCharacter.Location.X - 10, pictureBoxMainCharacter.Location.Y);
                }
                else if (e.KeyCode == Keys.Right && pictureBoxMainCharacter.Location.X + pictureBoxMainCharacter.Width + 30 < this.Width)
                {
                    pictureBoxMainCharacter.Location = new Point(pictureBoxMainCharacter.Location.X + 10, pictureBoxMainCharacter.Location.Y);
                }
                else if (e.KeyCode == Keys.Up && pictureBoxMainCharacter.Location.Y > 0)
                {
                    pictureBoxMainCharacter.Location = new Point(pictureBoxMainCharacter.Location.X, pictureBoxMainCharacter.Location.Y - 10);
                }
                else if (e.KeyCode == Keys.Down && pictureBoxMainCharacter.Location.Y + pictureBoxMainCharacter.Height + 45 < this.Height)
                {
                    pictureBoxMainCharacter.Location = new Point(pictureBoxMainCharacter.Location.X, pictureBoxMainCharacter.Location.Y + 10);
                }

            }

            if (animalPictureBoxes.Count == 0)
            {
                MessageBox.Show("Все животные пойманы!");
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox animal in animalPictureBoxes)
            {
                // проверка столкновения с главным героем
                if (animal.Bounds.IntersectsWith(pictureBoxMainCharacter.Bounds))
                {
                    Controls.Remove(animal);
                    animalPictureBoxes.Remove(animal);
                    break;
                }
                else
                {
                    //если не было столкновения, то животные двигаются!!
                    animal.Location = new Point(animal.Location.X + 3, animal.Location.Y+1);
                    if (animal.Location.X > this.ClientSize.Width)
                    {
                        //реализовать, чтобы животные не могли выходить за пределы и двигались в случайном направлении каждый
                        Controls.Remove(animal);
                        animalPictureBoxes.Remove(animal);
                        break;
                    }
                }
            }
        }
    }
}
