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
        //Dizalo se nalazi na prizemlju
        public void prizemlje()
        {
            picprizemlje.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\dizalo.jpg");
            picprizemlje.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1kat.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\NemaDizala.jpg");
            pic1kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2kat.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\NemaDizala.jpg");
            pic2kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3kat.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\NemaDizala.jpg");
            pic3kat.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Dizalo se nalazi na 1 katu
        public void kat1()
        {
            picprizemlje.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\NemaDizala.jpg");
            picprizemlje.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1kat.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\dizalo.jpg");
            pic1kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2kat.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\NemaDizala.jpg");
            pic2kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3kat.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\NemaDizala.jpg");
            pic3kat.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Dizalo se nalazi na 2 katu
        public void kat2()
        {
            picprizemlje.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\NemaDizala.jpg");
            picprizemlje.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1kat.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\NemaDizala.jpg");
            pic1kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2kat.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\dizalo.jpg");
            pic2kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3kat.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\NemaDizala.jpg");
            pic3kat.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Dizalo se nalazi na 3 katu
        public void kat3()
        {
            picprizemlje.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\NemaDizala.jpg");
            picprizemlje.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1kat.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\NemaDizala.jpg");
            pic1kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2kat.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\NemaDizala.jpg");
            pic2kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3kat.Image = new Bitmap(@"C:\Users\Dino\source\repos\Dizalo\Dizalo\Slike\dizalo.jpg");
            pic3kat.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Kreni prizemlje
        public void kreniprizemlje() {
            //Combobox - BR osoba
            string brosoba = this.brosprizemlje.SelectedItem.ToString();
            int br = Int32.Parse(brosoba);
            int max = Osoba.maxosoba;
            int osoba = max - br;
            textTrenutnoOsoba.Text = br.ToString();
            textSlobodnomjesta.Text = osoba.ToString();

            //Combobox - BR kat
            string brkat = this.comboprizemlje.SelectedItem.ToString();
            textTrenutniKat.Text = brkat;
            if (brkat == "1 kat")
            {
                kat1();
            }
            else if (brkat == "2 kat")
            {
                kat2();
            }
            else
            {
                kat3();
            }
        }

        //Kreni 1 kat
        public void kreni1kat() {
            //Combobox - BR osoba
            string brosoba = this.bros1kat.SelectedItem.ToString();
            int br = Int32.Parse(brosoba);
            int max = Osoba.maxosoba;
            int osoba = max - br;
            textTrenutnoOsoba.Text = br.ToString();
            textSlobodnomjesta.Text = osoba.ToString();

            //Combobox - BR kat
            string brkat = this.combo1kat.SelectedItem.ToString();
            textTrenutniKat.Text = brkat;
            if (brkat == "2 kat")
            {
                kat2();
            }
            else if (brkat == "3 kat")
            {
                kat3();
            }
            else
            {
                prizemlje();
            }
        }

        //Kreni 2 kat
        public void kreni2kat()
        {
            //Combobox - BR osoba
            string brosoba = this.bros2kat.SelectedItem.ToString();
            int br = Int32.Parse(brosoba);
            int max = Osoba.maxosoba;
            int osoba = max - br;
            textTrenutnoOsoba.Text = br.ToString();
            textSlobodnomjesta.Text = osoba.ToString();

            //Combobox - BR kat
            string brkat = this.combo2kat.SelectedItem.ToString();
            textTrenutniKat.Text = brkat;
            if (brkat == "1 kat")
            {
                kat1();
            }
            else if (brkat == "3 kat")
            {
                kat3();
            }
            else
            {
                prizemlje();
            }
        }

        //Kreni 3 kat
        public void kreni3kat()
        {
            //Combobox - BR osoba
            string brosoba = this.bros3kat.SelectedItem.ToString();
            int br = Int32.Parse(brosoba);
            int max = Osoba.maxosoba;
            int osoba = max - br;
            textTrenutnoOsoba.Text = br.ToString();
            textSlobodnomjesta.Text = osoba.ToString();

            //Combobox - BR kat
            string brkat = this.combo3kat.SelectedItem.ToString();
            textTrenutniKat.Text = brkat;
            if (brkat == "1 kat")
            {
                kat1();
            }
            else if (brkat == "2 kat")
            {
                kat2();
            }
            else
            {
                prizemlje();
            }
        }

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
            textSlobodnomjesta.Text = "0";
            prizemlje();
        }

        //BTN za prizemlje
        private void button1_Click(object sender, EventArgs e)
        {

            if (checkSpori.Checked == true)
            {
                checkSpori.Checked = true;
                checkSrednji.Checked = false;
                checkBrzi.Checked = false;
                Thread.Sleep(3000);
                kreniprizemlje();
            }
            else if (checkBrzi.Checked == true)
            {
                checkSpori.Checked = false;
                checkSrednji.Checked = false;
                checkBrzi.Checked = true;
                kreniprizemlje();
            }
            else {
                Thread.Sleep(1500);
                kreniprizemlje();
            }

        }

        //BTN za 1 kat
        private void btn1kat_Click(object sender, EventArgs e)
        {
            if (checkSpori.Checked == true)
            {
                checkSpori.Checked = true;
                checkSrednji.Checked = false;
                checkBrzi.Checked = false;
                Thread.Sleep(3000);
                kreni1kat();
            }
            else if (checkBrzi.Checked == true)
            {
                checkSpori.Checked = false;
                checkSrednji.Checked = false;
                checkBrzi.Checked = true;
                kreni1kat();
            }
            else
            {
                Thread.Sleep(1500);
                kreni1kat();
            }
        }

        //BTN za 2 kat
        private void btn2kat_Click(object sender, EventArgs e)
        {
            if(checkSpori.Checked == true)
            {
                checkSpori.Checked = true;
                checkSrednji.Checked = false;
                checkBrzi.Checked = false;
                Thread.Sleep(3000);
                kreni2kat();
            }
            else if (checkBrzi.Checked == true)
            {
                checkSpori.Checked = false;
                checkSrednji.Checked = false;
                checkBrzi.Checked = true;
                kreni2kat();
            }
            else
            {
                Thread.Sleep(1500);
                kreni2kat();
            }
        }

        //BTN za 3 kat
        private void btn3kat_Click(object sender, EventArgs e)
        {
            if (checkSpori.Checked == true)
            {
                checkSpori.Checked = true;
                checkSrednji.Checked = false;
                checkBrzi.Checked = false;
                Thread.Sleep(3000);
                kreni3kat();
            }
            else if (checkBrzi.Checked == true)
            {
                checkSpori.Checked = false;
                checkSrednji.Checked = false;
                checkBrzi.Checked = true;
                kreni3kat();
            }
            else
            {
                Thread.Sleep(1500);
                kreni3kat();
            }
        }
    }
}
