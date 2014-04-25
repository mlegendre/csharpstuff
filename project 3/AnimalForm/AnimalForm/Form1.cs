using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalForm
{
    public partial class Form1 : Form
    {
        //Instantiate extended classes.
        Mouse mighty = new Mouse();

        Dog Pluto = new Dog();

        Cat buba = new Cat();

        Rhino micahicalikijonbombalo = new Rhino();
        public Form1()
        {
            InitializeComponent();
            //Assign property values in extended classes
            mighty.Talk = "Hi my name is Mighty Mouse.";
            mighty.Eat = "I eat Evil-doers for breakfast.";
            mighty.Move = "I'm pretty much way too fast for you.";
            mighty.Skin = "my skin is so soft i get all the ladies.";

            Pluto.Talk = "Pluto says Bowow.";
            Pluto.Eat = "Pluto eats Cats.";
            Pluto.Move = "I move by leaps and bounds.";
            Pluto.Skin = "My skin is hairy, and I like it.";
                   
            buba.Talk = "Buba is borned in the streets, meow";
            buba.Eat = "Buba loves to eat Mighty Mice";
            buba.Move = "no need, the mice come right to me.";
            buba.Skin = "my skin is so so hairy i lick it and cough up hairballs.";
            
            micahicalikijonbombalo.Talk = "I think i grunt sometimes";
            micahicalikijonbombalo.Eat = "I eat foliage... and slow natives";
            micahicalikijonbombalo.Move = "I take my time, because I don't care";
            micahicalikijonbombalo.Skin = "my skin is rough.";
        }

        private void btnLegs_Click(object sender, EventArgs e)
        {
            if (rbtnMouse.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = mighty.Legs.ToString();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.mouse2;
            }

            if (rbtnDog.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = Pluto.Legs.ToString();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.pluto;
            }

            if (rbtnCat.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = buba.Legs.ToString();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.fatcat;
            }

            if (rbtnRhino.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = micahicalikijonbombalo.Legs.ToString();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.rhino3;
            }
        }

        private void btnEats_Click(object sender, EventArgs e)
        {
            if (rbtnMouse.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = mighty.Eat.ToString();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.mouse5;
            }
            
            if (rbtnDog.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = Pluto.Eat.ToString();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.plutoeat;
            }

            if (rbtnCat.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = buba.Eat.ToString();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.cat1;
            }

            if (rbtnRhino.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = micahicalikijonbombalo.Eat.ToString();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.rhinosit;
            }
        }

        private void btnSkin_Click(object sender, EventArgs e)
        {
            if (rbtnMouse.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = mighty.Skin.ToString();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.Mighty_Mouse;
            }

            if (rbtnDog.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = Pluto.Skin.ToString();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.pluto2;
            }

            if (rbtnCat.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = buba.Skin.ToString();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.catcat;
            }

            if (rbtnRhino.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = micahicalikijonbombalo.Skin.ToString();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.rhinoarmor;
            }

        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (rbtnMouse.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = mighty.Move.ToString();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.mouse4;
            }

            if (rbtnDog.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = Pluto.Move.ToString();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.plutomany;
            }

            if (rbtnCat.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = buba.Move.ToString();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.drunkcat;
            }

            if (rbtnRhino.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = micahicalikijonbombalo.Move.ToString();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.rhino2;
            }
        }

        private void btnTalk_Click(object sender, EventArgs e)
        {
            if (rbtnMouse.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = mighty.Talk.ToString();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.mouse2;
            }

            if (rbtnDog.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = Pluto.Talk.ToString();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.pluto3;
            }
            if (rbtnCat.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = buba.Talk.ToString();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.fattycat;
            }

            if (rbtnRhino.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = micahicalikijonbombalo.Talk.ToString();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.rhino3;
            }

        }

        private void btnUnique_Click(object sender, EventArgs e)
        {
            if (rbtnMouse.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = mighty.MouseUnique();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.catmove;
            }

            if (rbtnDog.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = Pluto.DogUnique();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.plutoarmy;
            }

            if (rbtnCat.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = buba.CatUnique();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.catfat;
            }

            if (rbtnRhino.Checked)
            {
                txtMessage1.Visible = true;
                txtMessage1.Text = micahicalikijonbombalo.RhinoUnique();
                txtMessage1.WordWrap = true;
                txtMessage1.Multiline = true;
                AnimalPicture.Visible = true;
                AnimalPicture.Image = Properties.Resources.rhinoagain;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        


     }
}

        
        
           