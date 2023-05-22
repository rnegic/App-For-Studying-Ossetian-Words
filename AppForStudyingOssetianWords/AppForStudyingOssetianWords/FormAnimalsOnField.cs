using AppForStudyingOssetianWords.Properties;
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
        List<Pair> animalPictureBoxes = new List<Pair>();

        Random random = new Random();
        string[] animals = { "wolf", "fox", "bear", "hare", "duck", "turtle", "squirrel", "cow", "cat", "dog" };
        //словарь для отображения слов на осетинском
        Dictionary<string, string> dictOssetianAnimals = new Dictionary<string, string>()
        {
            {"animalwolf", "бирæгъ"}, {"animalfox", "рувас"}, {"animalbear", "арс"}, {"animalhare", "тæрхъус"}, {"animalduck", "бабыз"},
            {"animalturtle", "уæртджын хæфс"}, {"animalsquirrel", "æхсæрæг"}, {"animalcow", "хъуг"}, {"animalcat", "гæды"}, {"animaldog", "куыдз"}
        };
        public FormAnimalsOnField()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            //генерируем ровно 10 PictureBox:
            for (int i = 0; i < 10; i++)
            {
                AddAnimalPictureBox(random.Next(10, 1600), random.Next(300, 800), animals[i]);
            }
        }

        private void AddAnimalPictureBox(int x, int y, string animal)
        {

            PictureBox newAnimal = new PictureBox();
            //newAnimal.Image = Properties.Resources.animalcow;
            string resourceName = "animal" + animal;
            newAnimal.Image = (Image)Resources.ResourceManager.GetObject(resourceName);
            newAnimal.Size = new Size(110, 110);
            newAnimal.SizeMode = PictureBoxSizeMode.StretchImage;
            newAnimal.Location = new Point(x, y);
            newAnimal.Tag = resourceName;
            newAnimal.BackColor = Color.Transparent;

            // добавляем животное в список и на форму
            animalPictureBoxes.Add(new Pair { PictureBox = newAnimal, Direction = new Point(7, 1) });
            this.Controls.Add(newAnimal);
        }

        private void FormAnimalsOnField_KeyDown(object sender, KeyEventArgs e)
        {
            //работа над внешним видом главного персонажа
            if (e.KeyCode == Keys.Left)
            {
                pictureBoxMainCharacter.Image = Resources.mainCharacterBackward;
            }
            else if (e.KeyCode == Keys.Right)
            {
                pictureBoxMainCharacter.Image = Resources.mainCharacterForward;
            }

            //проверим, не выходит ли главный герой за пределы формы, прежде чем считывать нажатия клавиш
            if (!(pictureBoxMainCharacter.Location.Y + pictureBoxMainCharacter.Height <= 420 || pictureBoxMainCharacter.Location.X < 0 || pictureBoxMainCharacter.Location.X + pictureBoxMainCharacter.Width + 30 > this.Width
              || pictureBoxMainCharacter.Location.Y < 0 || pictureBoxMainCharacter.Location.Y + pictureBoxMainCharacter.Height + 45 > this.Height))
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
                else if (e.KeyCode == Keys.Up && pictureBoxMainCharacter.Location.Y > 320)
                {
                    pictureBoxMainCharacter.Location = new Point(pictureBoxMainCharacter.Location.X, pictureBoxMainCharacter.Location.Y - 10);
                }
                else if (e.KeyCode == Keys.Down && pictureBoxMainCharacter.Location.Y + pictureBoxMainCharacter.Height + 45 < this.Height)
                {
                    pictureBoxMainCharacter.Location = new Point(pictureBoxMainCharacter.Location.X, pictureBoxMainCharacter.Location.Y + 10);
                }

            }

            //Проверка на то, что все животные пойманы
            if (animalPictureBoxes.Count == 0)
            {
                MessageBox.Show($"Все животные пойманы! \nАлы цæрæгой æрцахстай!");
            }

        }

        //для анимации "удара"
        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            pictureBoxMainCharacter.Image = Resources.mainCharacterForward;
            timerAnimation.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (Pair pair in animalPictureBoxes.ToArray())
            {
                // проверка столкновения с главным героем
                PictureBox animal = pair.PictureBox;
                Point direction = pair.Direction;

                if (animal.Bounds.IntersectsWith(pictureBoxMainCharacter.Bounds))
                {
                    Controls.Remove(animal);
                    animalPictureBoxes.Remove(pair);

                    //появление названия животного на осетинском
                    createLabel((string)animal.Tag);

                    //временный PictureBox, чтобы зафиксировать, какой из PictureBox'ов был использован последний раз(чтобы правильно восстановить его)
                    //PictureBox temp = pictureBoxMainCharacter;

                    timerAnimation.Start();
                    pictureBoxMainCharacter.Image = Resources.MainCharacterSmashMovement;
                    break;
                }
                else
                {
                    animal.Location = new Point(animal.Location.X + direction.X, animal.Location.Y + direction.Y);

                    //если КОСНУЛОСЬ края формы, то двигаться только в обратном направлении
                    //пока не коснется края, двигается по заданному положению, иначе оно умножается на -1

                    if (animal.Location.X + animal.Width > this.ClientSize.Width || animal.Location.Y + animal.Height > this.ClientSize.Height
                        || animal.Location.Y + animal.Height <= 410 || animal.Location.X < 0 || animal.Location.Y < 0)
                    {
                        direction = new Point(direction.X * -1, direction.Y * -1);
                        pair.Direction = direction;
                    }
                }
            }
        }

        //функция для создания названия животного 
        private void createLabel(string name)
        {
            Label label = new Label();
            label.Text = $"{dictOssetianAnimals[name]}";
            label.Name = name;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Location = new Point((this.ClientSize.Width - label.Width-220) / 2, this.ClientSize.Height - 100);
            label.Size = new Size(400, 40);
            label.ForeColor = Color.OrangeRed;
            label.Font = new Font("Timew New Roman", 28, FontStyle.Regular);
            this.Controls.Add(label);

            Timer labelTimer = new Timer();
            labelTimer.Interval = 1200;
            labelTimer.Tick += LabelTimer_Tick;
            labelTimer.Tag = label;
            labelTimer.Start();
        }
        private void LabelTimer_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            timer.Stop();

            Label label = (Label)timer.Tag;
            this.Controls.Remove(label);
        }

        //решение проблемы закрытия основной формы
        private void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
} 