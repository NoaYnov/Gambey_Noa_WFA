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
using System.Diagnostics;

namespace Project_Plateformer

{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, jumping, isGameOver;
        

        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;

        

        int mob1Speed = 2;
        bool end = false;





        SoundPlayer music;
        public Form1()
        {
            InitializeComponent();
            Player.Top = 300;
       
            music = new SoundPlayer(Properties.Resources.resu);
            music.PlayLooping();



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

                            while (force > 0)
                            {
                                force -= 1;
                                Player.Top = x.Top + Player.Height;
                            }


                        }
                        else if (Player.Bounds.Y <= x.Bounds.Y + Player.Bounds.Height && Player.Bounds.X + Player.Width >= x.Bounds.X + 8 && Player.Bounds.X <= x.Bounds.X + x.Width - 8)
                        {
                            force = 8;
                            if (!jumping)
                            {
                                jumpSpeed = 0;
                            }
                            else
                            {
                                jumpSpeed = -10;
                            }

                            Player.Top = x.Top - Player.Height + 1;


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

                if (x is PictureBox && (string)x.Tag == "Coin")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        score++;
                    }
                }


            }
        }
        private void deathMob()
        {
            //si le bas du joueur touche le haut du mob alors le mob meurt sinon si il touche le mob sur le coté le joueur meurt 
            if (Player.Bounds.IntersectsWith(mob1.Bounds) && mob1.Visible == true)
            {
                if (Player.Bounds.Y + Player.Height <= mob1.Bounds.Y + 5)
                {
                    Debug.WriteLine("test1");
                    mob1.Visible = false;
                    mob1.Tag = "";
                    mob1Speed = 0;
                    jumpSpeed = -10;
                    force = 8;
                    score++;
                }
                else
                {
                    Debug.WriteLine("test2");
                    gameTime.Stop();
                    isGameOver = true;
                    txtScore.Text = "Score: " + score + Environment.NewLine + "You Lose";
                }
            }
        }

        

        private void deplacement()
        {
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
        }
        private void deplacementMob()
        {
            if (mob1.Visible != false)
            {

                mob1.Left -= mob1Speed;

                if (mob1.Left < pictureBox1.Left || mob1.Left + mob1.Width > pictureBox1.Left + pictureBox2.Width)
                {

                    mob1Speed = -mob1Speed;



                }
            }
                deathMob();
        }




        private void MainGameTimeEvent(object sender, EventArgs e)
        {
            
            this.DoubleBuffered = true;
            txtScore.Text = "Score: " + score;
            // the player don't vibrate when he is on a plateform
            
            Player.Top += jumpSpeed;
            // the player go down to the plateform
            

            
            

           


            deplacement();
            collision(sender, e);
            deplacementMob();
            






            if (Player.Location.Y >= 400)
            {

                this.VerticalScroll.Value = 500;
                // the score move down but always on the top-right when the player fall down
                txtScore.Top = 0;
                

                

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
            // le joueur arrete de trembler quand il est sur une plateforme
            

            

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

            mob1.Left = 350;
            mob1.Tag = "mob";
            gameTime.Start();


        }

    }
}
