using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing;

namespace snakeGameThree
{
    public partial class Form1 : Form
    {
        enum Direction { up, down, right, left}
        Direction controller = Direction.down;

        bool gameMode = false;
        bool gameOver = false;
        bool gameCanStart = false;
        bool colorTwo = false;
        int foodWidth = 35, foodHeight = 40, score = 0, scoreValue = 0, speed = 10, speedValue = 0, sodaTime = 3;

        int sodaX, sodaY;

        string difficultyState;

        List<Rect> Snake = new List<Rect>();

        Rect food = new Rect();
        Brush foodColor = Brushes.Azure;

        //**// Sounds //**//
        SoundPlayer biteSound = new SoundPlayer("sounds/bite.wav");
        SoundPlayer clickSound = new SoundPlayer("sounds/click.wav");
        SoundPlayer drinkSound = new SoundPlayer("sounds/drinking.wav");
        SoundPlayer failureSound = new SoundPlayer("sounds/failure.wav");
        //**// ---- //**//

        public Form1()
        {
            InitializeComponent();
            gameTimer.Interval = 1000 / 18;
            labelTimer.Start();
        }

        public void StartGame()
        {
            yorkshirePB.Visible = true;
            GenerateFood();

            Rect head = new Rect();
            head.X = 25;
            head.Y = 50;

            Snake.Add(head);

            // Update game
            gameTimer.Start();

        }

        // Set difficulty
        public void DifficultySet()
        {
            if (difficultyState == "Easy")
            {
                gameCanStart = true;
                speed = 12;
                scoreValue = 5;
                speedValue = speed;
            }
            else if (difficultyState == "Normal")
            {
                gameCanStart = true;
                speed = 16;
                scoreValue = 20;
                speedValue = speed;
            }
            else if (difficultyState == "Hard")
            {
                gameCanStart = true;
                speed = 25;
                scoreValue = 100;
                speedValue = speed;
            }
            else if (difficultyState == "Very Hard!!!")
            {
                gameCanStart = true;
                speed = 32;
                scoreValue = 200;
                speedValue = speed;
            }
            else
                MessageBox.Show("Please, select your difficulty.", "Warning!");
        }

        private void labelTimer_Tick(object sender, EventArgs e)
        {
            if(gameTitle.Visible == true && gameVer.Visible == true && !gameMode)
            {
                gameTitle.Visible = false;
                gameVer.Visible = false;

            } else
            {
                gameTitle.Visible = true;
                gameVer.Visible = true;
            }

            if (gameMode)
            {
                gameTitle.Visible = false;
                gameVer.Visible = false;
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            // Set difficulty
            DifficultySet();

            if (gameCanStart) {
            clickSound.Play();
            gameMode = true;
            startBtn.Visible = false;
            bordersOn.Visible = false;
            bordersOff.Visible = false;
            bordersOnLabel.Visible = false;
            bordersOffLabel.Visible = false;
            labelDev.Visible = false;
            labelSpeed.Visible = true;
            progressBar.Visible = true;
            labelScore.Visible = true;
            scoreCont.Visible = true;
            pressSpace.Visible = true;
            hintLabel.Visible = true;
            easyBtn.Visible = false;
            normalBtn.Visible = false;
            hardBtn.Visible = false;
            veryHardBtn.Visible = false;
            labelDifficulty.Visible = false;

                StartGame();
            }
        }

        /// Game update ///
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //**// Controller //**//
            for (var i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    if (controller == Direction.right)
                        Snake[i].X += speed;
                    else if (controller == Direction.left)
                        Snake[i].X -= speed;
                    else if (controller == Direction.up)
                        Snake[i].Y -= speed;
                    else if (controller == Direction.down)
                        Snake[i].Y += speed;
                } else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }

            /// Eat food
            if (Snake[0].X < food.X + foodWidth && Snake[0].X + Snake[0].Width > food.X &&
                Snake[0].Y < food.Y + foodHeight && Snake[0].Y + Snake[0].Height > food.Y)
                Eat();


            /// Drink soda
            if (Snake[0].X < sodaX + sodaPB.Width -20 && Snake[0].X + Snake[0].Width > sodaX - 20 &&
                Snake[0].Y < sodaY + sodaPB.Height -40 && Snake[0].Y + Snake[0].Height > sodaY- 40 && sodaPB.Visible)
                Drink();


            // Collision with body
            for (int j = 1; j < Snake.Count; j++)
            {
                if (Snake[0].X == Snake[j].X && Snake[0].Y == Snake[j].Y)
                    Die();
            }

            int maxCanvasX = pictureBox.Size.Width - 20;
            int maxCanvasY = pictureBox.Size.Height - 20;

            // Collision with walls
            if (bordersOn.Checked) {
                // Activate walls
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;

                if (Snake[0].X < 0 || Snake[0].Y < 0 || Snake[0].X > maxCanvasX || Snake[0].Y > maxCanvasY)
                {
                    Die();
                }
            }
           else if (!bordersOn.Checked && !label1.Visible && !label2.Visible && !label3.Visible && !label4.Visible)
            {
                for (var i = 0; i < Snake.Count; i++)
                {
                if (Snake[0].X < 0)
                   Snake[i].X = maxCanvasX;
                if (Snake[0].X > maxCanvasX + 10)
                    Snake[i].X = 0;
                if (Snake[0].Y < 0)
                    Snake[i].Y = maxCanvasY;
                if (Snake[0].Y > maxCanvasY + 10)
                    Snake[i].Y = 0;
                } // for loops end here

            }

            pictureBox.Invalidate();
        }

        //**// Set controller //**//
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameMode == true && gameOver == false) {

            if (e.KeyCode == Keys.Right && controller != Direction.left)
                controller = Direction.right;
            else if (e.KeyCode == Keys.Left && controller != Direction.right)
                controller = Direction.left;
            else if (e.KeyCode == Keys.Up && controller != Direction.down)
                controller = Direction.up;
            else if (e.KeyCode == Keys.Down && controller != Direction.up)
                controller = Direction.down;
            } // check game mode and game over states end here

            // Game over enter function
            if(gameOver)
            {
                if (e.KeyCode == Keys.Enter)
                    Application.Restart();
            }

            // Increase speed of snake
            if (e.KeyCode == Keys.Space && progressBar.Value > 0 && gameOver == false)
            {
                bordersOn.AutoCheck = false;
                bordersOff.AutoCheck = false;
                speed = speedValue + 10;
                progressBar.Value -= 10;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                speed = speedValue;

                if (bordersOn.Checked)
                    bordersOn.Checked = true;
                else if(bordersOff.Checked)
                    bordersOff.Checked = true;
            }
        }

        /// Draw rects
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if(gameMode == true && gameOver == false)
            {
                Graphics canvas = e.Graphics;
                for(var i = 0; i < Snake.Count; i++)
                {
                    Brush snakeColor;

                    if (i == 0)
                        snakeColor = Brushes.DarkRed;

                    else if (!colorTwo)
                    {
                        snakeColor = Brushes.Aqua;
                        colorTwo = true;
                    }
                    else
                    {
                        snakeColor = Brushes.DeepSkyBlue;
                        colorTwo = false;
                    }

                    // Draw snake
                    canvas.FillRectangle(snakeColor, new Rectangle(Snake[i].X, Snake[i].Y, Snake[i].Width, Snake[i].Height));
                }

                // Draw rect
                canvas.FillRectangle(Brushes.Azure, new Rectangle(food.X, food.Y, foodWidth, foodHeight));
            }

        }

        // Create food
        public void GenerateFood()
        {
            //**// FOODS //**//
            string yorkshirePudding = @"images/yorkshire_pudding.png";
            string icecream = @"images/icecream.png";
            string borovets = @"images/borovets.png";
            string eclair = @"images/eclair.png";
            string donut = @"images/donut.png";
            string pizza = @"images/pizza.png";
            string cake = @"images/cake.png";
            ////----////

            int maxCanvasX = pictureBox.Size.Width -20;
            int maxCanvasY = pictureBox.Size.Height -20;

            Random rand = new Random();
            Random randFood = new Random();

            food.X = rand.Next(yorkshirePB.Width, maxCanvasX -yorkshirePB.Width);
            food.Y = rand.Next(yorkshirePB.Height, maxCanvasY -yorkshirePB.Height);

            yorkshirePB.Location = new Point(food.X +27, food.Y +33);

            int foodType = randFood.Next(0, 7);
            if(foodType == 0)
            yorkshirePB.Image = Image.FromFile(yorkshirePudding);
            else if(foodType == 1)
            yorkshirePB.Image = Image.FromFile(icecream);
            else if(foodType == 2)
            yorkshirePB.Image = Image.FromFile(borovets);
            else if (foodType == 3)
            yorkshirePB.Image = Image.FromFile(eclair);
            else if (foodType == 4)
            yorkshirePB.Image = Image.FromFile(donut);
            else if (foodType == 5)
            yorkshirePB.Image = Image.FromFile(pizza);
            else if (foodType == 6)
            yorkshirePB.Image = Image.FromFile(cake);

        }

        // Create soda
        public void GenerateSoda()
        {
            int maxCanvasX = pictureBox.Size.Width -sodaPB.Width;
            int maxCanvasY = pictureBox.Size.Height - sodaPB.Height;
            Random randDrink = new Random();


            sodaX = randDrink.Next(sodaPB.Width, maxCanvasX);
            sodaY = randDrink.Next(sodaPB.Height, maxCanvasY);

            sodaPB.Location = new Point(sodaX, sodaY);
        }

        // Eat food
        public void Eat()
        {
            if(!gameOver) {
            biteSound.Play();
            speed = speedValue;

            Rect food = new Rect();
            food.X = Snake[Snake.Count - 1].X -1;
            food.Y = Snake[Snake.Count - 1].Y;

            Snake.Add(food);
            GenerateFood();

            score += scoreValue;
            scoreCont.Text = score.ToString();

            /// Creating random drinks
            Random randChance = new Random();

            int sodaChance = randChance.Next(0, 10);
            if (sodaChance == 3 || sodaChance == 5 || sodaChance == 7)
            {
                GenerateSoda();
                sodaPB.Visible = true;
                sodaTimer.Start();
            }
            }// game state checks
        }

        private void sodaTimer_Tick(object sender, EventArgs e)
        {
            sodaTime--;

            if(sodaTime == 0 && sodaPB.Visible)
            {
                GenerateSoda();
                sodaPB.Visible = false;
                sodaTime = 3;
                sodaTimer.Stop();
            }

        }

        // Drink soda
        public void Drink()
        {
            drinkSound.Play();
            sodaPB.Visible = false;

            if (progressBar.Value <= 90)
            progressBar.Value += 10;

            GenerateSoda();

            sodaTime = 3;
            sodaTimer.Stop();

        }

        // Die
        public void Die()
        {
            if(gameOver == false)
            failureSound.Play();

            pictureBox.Focus(); // to activate Enter button

            ///** Speed UI hide **//
            progressBar.Visible = false;
            pressSpace.Visible = false;
            hintLabel.Visible = false;
            labelSpeed.Visible = false;
            ////

            labelScore.Font = new Font("Constantia", 24, FontStyle.Bold);
            scoreCont.Font = new Font("Consolas", 24, FontStyle.Bold);


            gameOver = true;
            labelOver.Text = "Your final score is: " + score + "\nPress 'Enter' key to try again.\nGood luck! :)";
            labelOver.Visible = true;
            gameOverTitle.Visible = true;
            sodaPB.Visible = false;
            yorkshirePB.Visible = false;
        }

        ////** UI **////
        private void bordersOn_CheckedChanged(object sender, EventArgs e)
        {
            clickSound.Play();
            if (bordersOn.Checked)
            {
                bordersOn.Checked = true;
                bordersOff.Checked = false;
                bordersOnLabel.ForeColor = Color.WhiteSmoke;
                bordersOnLabel.BackColor = Color.DarkRed;
            }
            if(bordersOff.Checked)
            {
                bordersOff.Checked = true;
                bordersOn.Checked = false;
                bordersOnLabel.ForeColor = Color.Black;
                bordersOnLabel.BackColor = Color.MediumTurquoise;
            }
        }

        private void bordersOff_CheckedChanged(object sender, EventArgs e)
        {
            clickSound.Play();
            if (bordersOff.Checked)
            {
                bordersOff.Checked = true;
                bordersOn.Checked = false;
                bordersOffLabel.ForeColor = Color.WhiteSmoke;
                bordersOffLabel.BackColor = Color.DarkRed;
            }
            if (bordersOn.Checked)
            {
                bordersOn.Checked = true;
                bordersOff.Checked = false;
                bordersOffLabel.ForeColor = Color.Black;
                bordersOffLabel.BackColor = Color.MediumTurquoise;
            }

        }

        /// Difficulty select
        private void select_difficulty(object sender, EventArgs e)
        {
            if(gameMode == false)
            clickSound.Play();

            Button button = (Button)sender;
            difficultyState = button.Text;

            if (difficultyState == "Easy")
            {
                easyBtn.BackColor = Color.Lime;
                easyBtn.ForeColor = Color.Black;
            }
            else
            {
                easyBtn.BackColor = Color.DeepSkyBlue;
                easyBtn.ForeColor = Color.Azure;
            }

            if (difficultyState == "Normal")
            {
                normalBtn.BackColor = Color.Lime;
                normalBtn.ForeColor = Color.Black;
            }
            else
            {
                normalBtn.BackColor = Color.DeepSkyBlue;
                normalBtn.ForeColor = Color.AntiqueWhite;
            }

            if (difficultyState == "Hard")
            {
                hardBtn.BackColor = Color.Lime;
                hardBtn.ForeColor = Color.DarkRed;
            }
            else
            {
                hardBtn.BackColor = Color.DeepSkyBlue;
                hardBtn.ForeColor = Color.DarkRed;
            }

            if (difficultyState == "Very Hard!!!")
            {
                veryHardBtn.BackColor = Color.Crimson;
                veryHardBtn.ForeColor = Color.Black;
            }
            else
            {
                veryHardBtn.BackColor = Color.Crimson;
                veryHardBtn.ForeColor = Color.LightPink;
            }
        }

        private void startBtn_MouseEnter(object sender, EventArgs e)
        {
            startBtn.ForeColor = Color.Black;
        }

        private void startBtn_MouseLeave(object sender, EventArgs e)
        {
            startBtn.ForeColor = Color.WhiteSmoke;
        }
    }
}
