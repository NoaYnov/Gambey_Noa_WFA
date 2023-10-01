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
    public partial class Menu : Form
    {
        Form1 frm = new Form1();
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            frm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // change the image of the player
            frm.Player.BackgroundImage = Properties.Resources.vlc;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           

            frm.Player.BackgroundImage = Properties.Resources.vlc;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            frm.Player.BackgroundImage = Properties.Resources.amogus;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            frm.Player.BackgroundImage = Properties.Resources.super;
            frm.Player.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
