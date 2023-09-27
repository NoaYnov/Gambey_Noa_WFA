using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Plateformer;
// import form1 to use the player class


namespace Project_Plateformer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        Form f1 = new Form1();

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Test (object sender, EventArgs e)
        {
            // import the public function "Deplacement" from Form1.cs
            // f1.Deplacement();
        }
        private void MainGameTimeEvent (object sender, EventArgs e)
        {
            // import the public function "Deplacement" from Form1.cs
            
            


           
            

            
        }
    }
}
