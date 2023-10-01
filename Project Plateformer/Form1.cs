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
        bool reversed = false;

        

        int mob1Speed = 2;
        int mob2Speed = 4;

        bool end = false;





        SoundPlayer music;
        public Form1()
        {
            
            InitializeComponent();
            Player.Top = 300;
       
            music = new SoundPlayer(Properties.Resources.resu);
            music.PlayLooping();



        }

        public void label1_Click(object sender, EventArgs e)
        {

        }
        public void collision() //collision entre le joueur et les plateformes
        {
            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "Plateform")

                {
                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (x.Bounds.Y <= Player.Bounds.Y) // empeche le joueur de traverser la plateforme par le dessous
                        {

                            while (force > 0) // empeche le joueur de resauter quand il se cogne par le dessous
                            {
                                force -= 1;
                                Player.Top = x.Top + Player.Height;
                            }


                        }
                        else if (Player.Bounds.Y <= x.Bounds.Y + Player.Bounds.Height && Player.Bounds.X + Player.Width >= x.Bounds.X + 8 && Player.Bounds.X <= x.Bounds.X + x.Width - 8)
                        {
                            force = 8; // permet un saut classique sans tremblement sur Player
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

                        if (x.Name == "END") //condition de fin quand on arrive au drapeau 
                        {
                            if (score >= 8) // si le joueur a assez de score il gagne
                            {
                                gameTime.Stop();
                                isGameOver = true;

                                txtScore.Text = "Score: " + score + Environment.NewLine + "You Win";

                            }
                            else // sinon il est renvoyé au début
                            {
                                this.VerticalScroll.Value = 0;
                                Player.Left = 68;
                                Player.Top = 300;
                                txtScore.Top = 0;
                                txtScore.Text = "Score: " + score + "\n tu n'as pas assez de score";
                                
                            }












                        }


                    }



                    x.BringToFront();
                }
                if (x is PictureBox && (string)x.Tag == "Mur") // collision entre le joueur et les murs
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        
                        if (goLeft == true)
                        {

                            Player.Left = x.Left + x.Width;
                        }
                        else if (goRight == true)
                        {

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

                if (x is PictureBox && (string)x.Tag == "Coin") // collision avec les pieces qui les fait disparaitre et etre ajouté au score
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        score++;
                    }
                }


            }
        }
        public void deathMob()
        {
            if (Player.Bounds.IntersectsWith(mob1.Bounds) && mob1.Visible == true)
            {
                if (Player.Bounds.Y + Player.Height <= mob1.Bounds.Y + 5) // si le joueur est au dessus du mob il le tue
                {
                    
                    mob1.Visible = false;
                    mob1.Tag = "";
                    mob1Speed = 0;
                    jumpSpeed = -10;
                    force = 8;
                    score++;
                }
                
                else // sinon il meurt et le jeu s'arrete
                {
                    
                    gameTime.Stop();
                    isGameOver = true;
                    txtScore.Text = "Score: " + score + Environment.NewLine + "You Lose";
                }
            }
            
        }

        

        public void Deplacement() // deplacement du joueur (gauche droite et saut)
        {
            if (goLeft == true)
            {
                Player.Left -= playerSpeed;
                if (reversed == false)
                {
                    Player.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    reversed = true;
                }
                



            }
            if (goRight == true)
            {
                Player.Left += playerSpeed;
                if (reversed == true)
                {
                    Player.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    reversed = false;
                }
                
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
        public void deplacementMob() // deplacement du mob qui s'arrete au bord de sa plateforme
        {
            if (mob1.Visible != false)
            {

                mob1.Left -= mob1Speed;

                if (mob1.Left < pictureBox1.Left || mob1.Left + mob1.Width > pictureBox1.Left + pictureBox2.Width)
                {

                    mob1Speed = -mob1Speed;



                }
            }
            

        }




        public void MainGameTimeEvent(object sender, EventArgs e) // evenement qui se passe a chaque tick du timer
        {
            
            this.DoubleBuffered = true; // permet de ne pas avoir de probleme de texture pendant les deplacements
            txtScore.Text = "Score: " + score;
            
            Player.Top += jumpSpeed;
            

            
            

           


            Deplacement();
            collision();
            deplacementMob();
            if (mob1.Visible == true)
            {
                deathMob();
            }
           







            if (Player.Location.Y >= 400) // scroll de l'ecran quand le joueur descend trop bas
            {

                this.VerticalScroll.Value = 500; 
                txtScore.Top = 0;
                

                

            }
            
            if (score >= 4) // ouvre la suite quand le joueur a un score de 4 ou plus
            {
                removable.Visible = false;
                removable.Tag = "";
            }



        }


        public void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            


        }

        public void Plateform_Click(object sender, EventArgs e)
        {
         
        }

        private void Player_Click(object sender, EventArgs e)
        {
            

            

        }

        public void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mob1_Click(object sender, EventArgs e)
        {

        }

        public void keyIsDown(object sender, KeyEventArgs e) // assignement des touches pressées
        {
            if (e.KeyCode == Keys.Q || e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
               
            }
            
            


        }




        public void keyIsUp(object sender, KeyEventArgs e) // assignement des touches relachées
        {

            if (e.KeyCode == Keys.Q || e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
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
        public void restartGame() // remet le jeu a zero quand le joueur perd et appuie sur entrer
        {
            this.VerticalScroll.Value = 0;
            txtScore.Top = 0;
            jumping = false;
            goLeft = false;
            goRight = false;
            isGameOver = false;
            score = 0;
            txtScore.Text = "Score: " + score;
            
            foreach (Control x in this.Controls) // remet les pieces a leur place et les mob
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }
            
            Player.Left = 68;
            Player.Top = 300;

            mob1.Left = 350;
            mob1Speed = 2;
            mob1.Tag = "mob";
            gameTime.Start();
            


        }

    }
}
