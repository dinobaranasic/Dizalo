using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizalo
{
    public partial class FormDizalo : Form
    {
        public FormDizalo()
        {
            InitializeComponent();
        }

        //Dozvoliti samo jedan unos u CheckBox
        private void checkSpori_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSpori.Checked == true)
            {
                checkSpori.Checked = true;
                checkSrednji.Checked = false;
                checkBrzi.Checked = false;
            }
        }

        //Dozvoliti samo jedan unos u CheckBox
        private void checkSrednji_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSrednji.Checked == true)
            {
                checkSpori.Checked = false;
                checkSrednji.Checked = true;
                checkBrzi.Checked = false;
            }
        }

        //Dozvoliti samo jedan unos u CheckBox
        private void checkBrzi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBrzi.Checked == true)
            {
                checkSpori.Checked = false;
                checkSrednji.Checked = false;
                checkBrzi.Checked = true;
            }
        }

        //BTN pokreni pokreće dizalo i dizalo se nalazi u prizemlju
        private void butPokreni_Click(object sender, EventArgs e)
        {
            // Dizalo se u početku nalazi na prizemlju
            //Broj osoba je 0
            textTrenutniKat.Text = "Prizemlje";
            textTrenutnoOsoba.Text = "0";
            picprizemlje.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\dizalo.jpg");
            picprizemlje.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1kat.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\NemaDizala.jpg");
            pic1kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2kat.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\NemaDizala.jpg");
            pic2kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3kat.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\NemaDizala.jpg");
            pic3kat.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //BTN za prizemlje
        private void button1_Click(object sender, EventArgs e)
        {
            //Dizalo se u početku nalazi na prizemlju
            textTrenutniKat.Text = "Prizemlje";
            picprizemlje.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\dizalo.jpg");
            picprizemlje.SizeMode = PictureBoxSizeMode.StretchImage;


            pic1kat.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\dizalo.jpg");
            pic1kat.SizeMode = PictureBoxSizeMode.StretchImage;

            picprizemlje.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\NemaDizala.jpg");
            picprizemlje.SizeMode = PictureBoxSizeMode.StretchImage;


        }
    }
}
