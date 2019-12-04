using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            picprizemlje.Image = new Bitmap(wanted_path.ToString()+@"\Slike\dizalo.jpg");
            picprizemlje.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1kat.Image = new Bitmap(wanted_path.ToString() + @"\Slike\NemaDizala.jpg");
            pic1kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2kat.Image = new Bitmap(wanted_path.ToString() + @"\Slike\NemaDizala.jpg");
            pic2kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3kat.Image = new Bitmap(wanted_path.ToString() + @"\Slike\NemaDizala.jpg");
            pic3kat.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Dizalo se nalazi na 1 katu
        public void kat1()
        {
            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            picprizemlje.Image = new Bitmap(wanted_path.ToString() + @"\Slike\NemaDizala.jpg");
            picprizemlje.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1kat.Image = new Bitmap(wanted_path.ToString() + @"\Slike\dizalo.jpg");
            pic1kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2kat.Image = new Bitmap(wanted_path.ToString() + @"\Slike\NemaDizala.jpg");
            pic2kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3kat.Image = new Bitmap(wanted_path.ToString() + @"\Slike\NemaDizala.jpg");
            pic3kat.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Dizalo se nalazi na 2 katu
        public void kat2()
        {
            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            picprizemlje.Image = new Bitmap(wanted_path.ToString() + @"\Slike\NemaDizala.jpg");
            picprizemlje.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1kat.Image = new Bitmap(wanted_path.ToString() + @"\Slike\NemaDizala.jpg");
            pic1kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2kat.Image = new Bitmap(wanted_path.ToString() + @"\Slike\dizalo.jpg");
            pic2kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3kat.Image = new Bitmap(wanted_path.ToString() + @"\Slike\NemaDizala.jpg");
            pic3kat.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Dizalo se nalazi na 3 katu
        public void kat3()
        {
            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            picprizemlje.Image = new Bitmap(wanted_path.ToString() + @"\Slike\NemaDizala.jpg");
            picprizemlje.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1kat.Image = new Bitmap(wanted_path.ToString() + @"\Slike\NemaDizala.jpg");
            pic1kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2kat.Image = new Bitmap(wanted_path.ToString() + @"\Slike\NemaDizala.jpg");
            pic2kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3kat.Image = new Bitmap(wanted_path.ToString() + @"\Slike\dizalo.jpg");
            pic3kat.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Greška o broju kata
        public void greška_kat() {
            string message = "Ne možete putovati na isti kat! \nOdaberite kat na koji želite ići.";
            string title = "Greška";
            MessageBox.Show(message, title);
        }

        //Greška o broju osoba
        public void greška_osobe()
        {
            string message = "Ne može 0 osoba putovati! \nOdaberite koji broj osoba putuje.";
            string title = "Greška";
            MessageBox.Show(message, title);
        }

        //Greška o broju osoba
        public void greška_brosobe()
        {
            textTrenutnoOsoba.Text = "0";
            textSlobodnomjesta.Text = "0";
        }

        //Kreni prizemlje
        public void kreniprizemlje() {
            //Combobox - BR osoba
            string brosoba = this.brosprizemlje.SelectedItem.ToString();
            int br = Int32.Parse(brosoba);
            if (br == 0)
            {
                greška_osobe();
                greška_brosobe();
                return;
            }
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
            else if (brkat == "3 kat")
            {
                kat3();
            }
            else {
                greška_kat();
                greška_brosobe();
                textTrenutniKat.Text = "";
                return;
            }
        }

        //Kreni 1 kat
        public void kreni1kat() {
            //Combobox - BR osoba
            string brosoba = this.bros1kat.SelectedItem.ToString();
            int br = Int32.Parse(brosoba);
            if (br == 0)
            {
                greška_osobe();
                greška_brosobe();
                return;
            }
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
            else if (brkat == "Prizemlje")
            {
                prizemlje();
            }
            else {
                greška_kat();
                greška_brosobe();
                textTrenutniKat.Text = "";
                return;
            }
        }

        //Kreni 2 kat
        public void kreni2kat()
        {
            //Combobox - BR osoba
            string brosoba = this.bros2kat.SelectedItem.ToString();
            int br = Int32.Parse(brosoba);
            if (br == 0)
            {
                greška_osobe();
                greška_brosobe();
                return;
            }
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
            else if (brkat == "Prizemlje")
            {
                prizemlje();
            }
            else {
                greška_kat();
                greška_brosobe();
                textTrenutniKat.Text = "";
                return;
            }
        }

        //Kreni 3 kat
        public void kreni3kat()
        {
            //Combobox - BR osoba
            string brosoba = this.bros3kat.SelectedItem.ToString();
            int br = Int32.Parse(brosoba);
            if (br == 0)
            {
                greška_osobe();
                greška_brosobe();
                return;
            }
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
            else if (brkat == "Prizemlje")
            {
                prizemlje();
            }
            else {
                greška_kat();
                greška_brosobe();
                textTrenutniKat.Text = "";
                return;
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
            textSlobodnomjesta.Text = "10";
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

        private void FormDizalo_Load(object sender, EventArgs e)
        {
            brosprizemlje.SelectedIndex = 0;
            bros1kat.SelectedIndex = 0;
            bros2kat.SelectedIndex = 0;
            bros3kat.SelectedIndex = 0;
            comboprizemlje.SelectedIndex = 0;
            combo1kat.SelectedIndex = 1;
            combo2kat.SelectedIndex = 2;
            combo3kat.SelectedIndex = 3;
        }
    }
}
