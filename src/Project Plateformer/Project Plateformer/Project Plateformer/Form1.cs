using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Plateformer

{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, jumping, isGameOver;

        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;

        int horizontalSpeed = 5;
        int verticalSpeed = 3;
        int speed = 0;

        int enemyOneSpeed = 5;
        int enemyTwoSpeed = 3;

        




        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        



        private void MainGameTimeEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;
            Player.Top += jumpSpeed;

            if (goLeft == true)
            {
                Player.Left -= playerSpeed;
            }
            if (goRight == true)
            {
                Player.Left += playerSpeed;
            }
            if (jumping == true && force < 0)
            {
                jumping = false;
            }
            if (jumping == true)
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Plateform")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;
                        Player.Top = x.Top - Player.Height ;
                    }
                    x.BringToFront();
                }
                if (x is PictureBox && x.Tag == "Coin")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        score++;
                    }
                }
                if (x is PictureBox && x.Tag == "mob")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTime.Stop();
                        isGameOver = true;
                        txtScore.Text = "Score: " + score + Environment.NewLine + "You were killed in your journey!!";
                    }
                }

            } 
            

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
               
            }


        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (jumping)
            {
                jumping = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver)
            {
                restartGame();
            }

        }
        private void restartGame()
        {
            jumping = false;
            goLeft = false;
            goRight = false;
            isGameOver = false;
            score = 0;
            txtScore.Text = "Score: " + score;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }

            Player.Left = 68;
            Player.Top = 334;

            mob1.Left = 402;
            mob1.Top = 263;
            gameTime.Start();


        }

    }
}
