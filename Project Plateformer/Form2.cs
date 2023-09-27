using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// import form1 to use fonction from form1
using Project_Plateformer;



namespace Project_Plateformer
{
    public partial class Form2 : Form

    {

        bool goLeft, goRight, jumping, isGameOver;


        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;



        int mob1Speed = 2;
        bool end = false;





        SoundPlayer music;
        public Form2()
        {
            InitializeComponent();
            // import the public function "Deplacement" from Form1.cs
            
            
            // import the public function "MainGameTimeEvent" from Form1.cs
           

            
        }
       

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       
        private void MainGameTimeEvent (object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            Player.Top += jumpSpeed;
            Form1 f1 = new Form1();
            f1.Deplacement();
            f1.collision(sender, e);
            
            

            // import the public function "Deplacement" from Form1












        }
        public void keyIsDown(object sender, KeyEventArgs e)
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




        public void keyIsUp(object sender, KeyEventArgs e)
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
            /*if (e.KeyCode == Keys.Enter && isGameOver)
            {
                restartGame();
            }*/



        }
    }
}
