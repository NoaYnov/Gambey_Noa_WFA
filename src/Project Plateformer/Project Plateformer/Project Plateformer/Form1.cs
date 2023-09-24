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

        int mob1Speed = 5;
        int enemyTwoSpeed = 3;
        bool end = false;






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
                Player.BackgroundImage = Properties.Resources.vlcMirror;
            }
            if (goRight == true)
            {
                Player.Left += playerSpeed;
                Player.BackgroundImage = Properties.Resources.vlc;
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
                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (x.Bounds.Y <= Player.Bounds.Y)
                        {
                            Player.Top = x.Top + Player.Height;
                        }
                        else if (Player.Bounds.Y <= x.Bounds.Y + Player.Bounds.Height)
                        {
                            force = 8;
                            Player.Top = x.Top - Player.Height;
                        }
                        if (x.Name == "END")
                        {
                        Console.WriteLine("END");
                        gameTime.Stop();
                        isGameOver = true;
                        end = true;
                        txtScore.Text = "Score: " + score + Environment.NewLine + "You have reached the end of your journey!!";
                         
                        }
                        

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
            mob1.Left -= mob1Speed;
            
            if (mob1.Left < pictureBox1.Left || mob1.Left + mob1.Width > pictureBox1.Left + pictureBox2.Width)
            {
                
                mob1Speed = -mob1Speed;
                
                

            }
            if (Player.Location.Y >= 400)
            {

                this.VerticalScroll.Value = 500;
            }
            // when the player move the background move too
            if (goLeft == true && Player.Left > 400)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "Plateform" || x is PictureBox && x.Tag == "Coin" || x is PictureBox && x.Tag == "mob")
                    {
                        x.Left += playerSpeed;
                    }
                }
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // the screen scroll automatically when the player reach the bottom of the screen
            


        }

        private void Plateform_Click(object sender, EventArgs e)
        {
         
        }

        private void Player_Click(object sender, EventArgs e)
        {
            // erase the white background of the player
            

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
            if (end == true)
            {
                // switch to the next level

            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }

            Player.Left = 68;
            Player.Top = 300;

            mob1.Left = 400;
            mob1.Top = 170;
            gameTime.Start();


        }

    }
}
