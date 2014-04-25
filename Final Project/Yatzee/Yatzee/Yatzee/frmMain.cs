using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Yatzee
{
    public partial class frmYatzee : Form
    {
        private static Bitmap die0 = new Bitmap("die0.jpg");
        private static Bitmap die1 = new Bitmap("die1.jpg");
        private static Bitmap die2 = new Bitmap("die2.jpg");
        private static Bitmap die3 = new Bitmap("die3.jpg");
        private static Bitmap die4 = new Bitmap("die4.jpg");
        private static Bitmap die5 = new Bitmap("die5.jpg");
        private static Bitmap die6 = new Bitmap("die6.jpg");
        private Bitmap[] tile = { die0, die1, die2, die3, die4, die5, die6 };
        private PictureBox[] tiles = new PictureBox[6];
        private int[] dice = { 6, 6, 6, 6, 6, 6 };
        private CheckBox[] checks = new CheckBox[6];
        Random randNum = new Random();

        public frmYatzee()
        {
            InitializeComponent();
            resetArrays();
            drawTiles();
        }

        private void resetArrays()
        {
            tile[0] = die0;
            tile[1] = die1;
            tile[2] = die2;
            tile[3] = die3;
            tile[4] = die4;
            tile[5] = die5;
            tile[6] = die6;
            tiles[0] = picDie1;
            tiles[1] = picDie1;
            tiles[2] = picDie2;
            tiles[3] = picDie3;
            tiles[4] = picDie4;
            tiles[5] = picDie5;
            checks[0] = die1check;
            checks[1] = die1check;
            checks[2] = die2check;
            checks[3] = die3check;
            checks[4] = die4check;
            checks[5] = die5check;
            dice[0] = 6;
            dice[1] = 6;
            dice[2] = 6;
            dice[3] = 6;
            dice[4] = 6;
            dice[5] = 6;
        }

        private void drawTiles()
        {
            for (int i = 1; i < 6; ++i)
                tiles[i].Image = tile[dice[i]];
            pnlMain.Refresh();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; ++i)
                if (checks[i].Checked)
                    dice[i] = randNum.Next(6) + 1;
            drawTile();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
        private void drawTile()
        {
            bool same = true;

            for (int i = 1; i < 6; ++i)
            {
                tiles[i].Image = tile[dice[i]];
                if (i > 1 && dice[i] != dice[i - 1])
                {
                    same = false;
                }
                /* else if (same)
                 {
                     label1_click.Visible = true;
                     label1_click.Text = "Yahtzeeeeeeeeeee!!!!!!!";
                 }*/

            }
            if (same)
            {
                label1_click.Visible = true;
                label1_click.Text = "Yahtzeeeeeeeeeee!!!!!!!";

                pnlMain.Refresh();
            }

        }

      

       private void label1_click_Click(object sender, EventArgs e)
       {

       }

       private void label8_Click(object sender, EventArgs e)
       {

       }

       private void label13_Click(object sender, EventArgs e)
       {

       }

       private void label12_Click(object sender, EventArgs e)
       {

       }

       private void label11_Click(object sender, EventArgs e)
       {

       }

       private void label10_Click(object sender, EventArgs e)
       {

       }

       private void label14_Click(object sender, EventArgs e)
       {

       }

       private void label9_Click(object sender, EventArgs e)
       {

       } 
    }
}