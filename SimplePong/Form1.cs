using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePong
{
    public partial class Form1 : Form
    {
        const int WIN = 10;                     // Winning Score
        const int INCREASE_SPEED = 1;           // speed increase factor

        //starting scores
        int playerScore = 0;
        int computerScore = 0;

        const int DISTANCE_FROM_EDGE = 10;      // distance of comp paddle from playing field edge

        bool GoUp, GoDown;                      // Keyboard up and down status

        const int PLAYER_PADDLE_SPEED = 8;      // player speed (pixels)
        int ComputerPaddleSpeed = 6;            // computer paddle speed (pixels)

        const int TIME_DELAY = 10;              // game speed

        // x and y movement constants
        const int SPEED_X = 2;
        const int SPEED_Y = 2;

        // vertical and horizontal movement of ball based on speed consts
        int MoveX = SPEED_X;
        int MoveY = SPEED_Y;

        public void GameLoop()
        {
            /* Main game loop, executing every 10ms from start
             * this: refers to current form class
             * created: boolean, while while loop tests for true is form class is running
             */
            while (this.Created)
            {
                moveBall();
                keepScore();
                detectCollision();
                movePaddle();            
                Refresh();              // repaint form
                // Processes all events in thread queue so program animation doesn't stop during refresh
                Application.DoEvents();
                // pause foreground or program thread for time_delay
                System.Threading.Thread.Sleep(TIME_DELAY);
            }
        }

        private void keepScore()
        {
            if (Ball.Left < 0)
            {
                Ball.Left = ClientSize.Width / 2;
                MoveX = -MoveX;
                MoveX += INCREASE_SPEED;

                if (MoveY < 0)
                {
                    MoveY -= INCREASE_SPEED;
                }
                else
                {
                    MoveY += INCREASE_SPEED;
                }
                computerScore++;
            }

            // computer misses player scores
            if (Ball.Left + Ball.Width > ClientSize.Width)
            {
                Ball.Left = ClientSize.Width / 2;
                MoveX = -MoveX;
                MoveX -= INCREASE_SPEED;

                if (MoveY < 0)
                {
                    MoveY -= INCREASE_SPEED;
                }
                else
                {
                    MoveY += INCREASE_SPEED;
                }
                playerScore++;
            }

            lblScorePlayer.Text = $"Player: {playerScore.ToString()}";
            lblScoreComp.Text = $"Computer: {computerScore.ToString()}";

            if (playerScore >= WIN)
            {
                MessageBox.Show("You Won!");
                playerScore = 0;
                computerScore = 0;
            }
            if (computerScore >= WIN)
            {
                MessageBox.Show("The Computer Won!");
                playerScore = 0;
                computerScore = 0;
            }
        }
        
        // Reverse direction upon ball/paddle collision
        private void detectCollision()
        {
            // flags added to determine which player hit ball last.
            // This avoids collision detection but where ball gets stuck in x/y loop inside paddle
            bool compHitLast = false;
            bool playerHitLast = false;

            if (Ball.Bounds.IntersectsWith(Player.Bounds) && !playerHitLast)
            {
                compHitLast = false;
                playerHitLast = true;
                MoveX = -MoveX; // reverse direction
            }
            if (Ball.Bounds.IntersectsWith(Computer.Bounds) && !compHitLast)
            {
                compHitLast = true;
                playerHitLast = false;
                MoveX = -MoveX; // reverse direction
            }
        }

        private void movePaddle()
        {

            // Computer logic. Need to abstract it and clean up

            // adjust computer paddle on screen resize
            Computer.Left = ClientSize.Width - (Computer.Width + DISTANCE_FROM_EDGE);

            // Move computer paddle up/down

            if (Computer.Bottom < Ball.Bottom && Ball.Left > (ClientSize.Width / 1.4))
            {
                Computer.Top += ComputerPaddleSpeed;
            }

            else if (Computer.Top > Ball.Top && Ball.Left > (ClientSize.Width / 1.4))
            {
                Computer.Top -= ComputerPaddleSpeed;
            }

            // Player Logic

            // up arrow and not at top of form
            if (GoUp && Player.Top > 0)
            {
                Player.Top -= PLAYER_PADDLE_SPEED; // move up
            }

            // down arrow and not at bottom of form
            if (GoDown && Player.Bottom < ClientSize.Height)
            {
                Player.Top += PLAYER_PADDLE_SPEED; //move down
            }
        }

        // logic to move ball on playing field
        private void moveBall()
        {
            // move ball on x and y by adding integers
            Ball.Left = Ball.Left + MoveX;
            Ball.Top = Ball.Top + MoveY;

            if (Ball.Top <= 0 || Ball.Top + Ball.Height >= ClientSize.Height)
            {
                MoveY = -MoveY;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        // key press logic for down press on up/down arrows
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                GoUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                GoDown = true;
            }
        }

        // keypress logic for release on up/down arrows
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                GoUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                GoDown = false;
            }
        }
    }
}
