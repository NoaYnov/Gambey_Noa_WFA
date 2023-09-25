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
        bool music = false;






        public Form1()
        {
            InitializeComponent();
            Player.Top = 300;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void collision(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                
                if (x is PictureBox && (string)x.Tag == "Plateform")

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
                            txtScore.Text = "Score: " + score + Environment.NewLine + "You Win";

                        }


                    }



                    x.BringToFront();
                }
                if (x is PictureBox && (string)x.Tag == "Mur")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        //le  joueur se cogne contre le mur
                        if (goLeft == true)
                        {
                            //si le joueur est au dessus le mur il peut marcher dessus
                            
                            Player.Left = x.Left + x.Width;
                        }
                        else if (goRight == true)
                        {
                            //si le joueur est au dessus le mur il peut marcher dessus
                     
                            Player.Left = x.Left - Player.Width;
                        }
                        else if (x.Bounds.Y <= Player.Bounds.Y)
                        {
                            Player.Top = x.Top + Player.Height;
                        }
                        else if (Player.Bounds.Y <= x.Bounds.Y + Player.Bounds.Height)
                        {
                            force = 8;
                            Player.Top = x.Top - Player.Height;
                        }




                    }
                }

                if (x is PictureBox && x.Tag == "Coin")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        score++;
                    }
                }
                

            }
        }
        private void deathMob(object sender, EventArgs e)
        {
            //si le bas du joueur touche le haut du mob alors le mob meurt sinon si il touche le mob sur le coté le joueur meurt 
            
        }

        private void Music()
        {
            // import the music
            
            if (music == false)
            {
                SoundPlayer mus = new SoundPlayer(Properties.Resources.resu);
                mus.PlayLooping();
                music = true;
            }
        }


        private void MainGameTimeEvent(object sender, EventArgs e)
        {
            
            this.DoubleBuffered = true;
            txtScore.Text = "Score: " + score;
            Player.Top += jumpSpeed;
            Music();
            

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
            collision(sender,e);

            if (mob1 != null)
            {
                mob1.Left -= mob1Speed;

                if (mob1.Left < pictureBox1.Left || mob1.Left + mob1.Width > pictureBox1.Left + pictureBox2.Width)
                {

                    mob1Speed = -mob1Speed;



                }
            }
            
            
            if (Player.Location.Y >= 400)
            {

                this.VerticalScroll.Value = 500;
                // the score move down but always on the top-right when the player fall down
                txtScore.Top = 0;
                

                

            }
            if (mob1 != null)
            {

            deathMob(sender, e);
            }
            if (score == 4)
            {
                removable.Visible = false;
                removable.Tag = "";
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

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
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
