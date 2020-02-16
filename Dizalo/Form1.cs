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
        //Početno riješenje sa OOP
        public FormDizalo()
        {
            InitializeComponent();

        }

        //Dizalo_svojstva
        Dizalo_Svojstva.Dizalo_svojstva Dizalo_Svojstva = new Dizalo_Svojstva.Dizalo_svojstva();

        //Osoba
        Osoba Osoba = new Osoba();
        #region Vizualni dio dizala-Slika
        //Dizalo se nalazi na prizemlju
        public void prizemlje()
        {
            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            picprizemlje.Image = new Bitmap(wanted_path.ToString() + @"\Dizalo_Svojstva\dizalo.jpg");
            picprizemlje.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1kat.Image = new Bitmap(wanted_path.ToString() + @"\Dizalo_Svojstva\NemaDizala.jpg");
            pic1kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2kat.Image = new Bitmap(wanted_path.ToString() + @"\Dizalo_Svojstva\NemaDizala.jpg");
            pic2kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3kat.Image = new Bitmap(wanted_path.ToString() + @"\Dizalo_Svojstva\NemaDizala.jpg");
            pic3kat.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Dizalo se nalazi na 1 katu
        public void kat1()
        {
            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            picprizemlje.Image = new Bitmap(wanted_path.ToString() + @"\Dizalo_Svojstva\NemaDizala.jpg");
            picprizemlje.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1kat.Image = new Bitmap(wanted_path.ToString() + @"\Dizalo_Svojstva\dizalo.jpg");
            pic1kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2kat.Image = new Bitmap(wanted_path.ToString() + @"\Dizalo_Svojstva\NemaDizala.jpg");
            pic2kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3kat.Image = new Bitmap(wanted_path.ToString() + @"\Dizalo_Svojstva\NemaDizala.jpg");
            pic3kat.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Dizalo se nalazi na 2 katu
        public void kat2()
        {
            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            picprizemlje.Image = new Bitmap(wanted_path.ToString() + @"\Dizalo_Svojstva\NemaDizala.jpg");
            picprizemlje.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1kat.Image = new Bitmap(wanted_path.ToString() + @"\Dizalo_Svojstva\NemaDizala.jpg");
            pic1kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2kat.Image = new Bitmap(wanted_path.ToString() + @"\Dizalo_Svojstva\dizalo.jpg");
            pic2kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3kat.Image = new Bitmap(wanted_path.ToString() + @"\Dizalo_Svojstva\NemaDizala.jpg");
            pic3kat.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Dizalo se nalazi na 3 katu
        public void kat3()
        {
            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            picprizemlje.Image = new Bitmap(wanted_path.ToString() + @"\Dizalo_Svojstva\NemaDizala.jpg");
            picprizemlje.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1kat.Image = new Bitmap(wanted_path.ToString() + @"\Dizalo_Svojstva\NemaDizala.jpg");
            pic1kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2kat.Image = new Bitmap(wanted_path.ToString() + @"\Dizalo_Svojstva\NemaDizala.jpg");
            pic2kat.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3kat.Image = new Bitmap(wanted_path.ToString() + @"\Dizalo_Svojstva\dizalo.jpg");
            pic3kat.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        #endregion

        #region Greške
        //Greška o broju kata
        public void greška_kat()
        {
            string message = "Ne možete putovati na isti kat! \nOdaberite kat na koji želite ići.";
            string title = "Greška";
            MessageBox.Show(message, title);
            greška_brosobe();
        }

        //Greška o broju osoba
        public void greška_osobe()
        {
            string message = "Ne može 0 osoba putovati! \nOdaberite koji broj osoba putuje.";
            string title = "Greška";
            MessageBox.Show(message, title);
            greška_brosobe();
        }

        //Greška o broju osoba
        public void greška_brosobe()
        {
            textTrenutnoOsoba.Text = "0";
            textSlobodnomjesta.Text = "0";
        }
        #endregion

        #region Podaci
        public void podaci(string kat) {
            if (checkSpori.Checked == true)
            {
                Dizalo_Svojstva.sporirad();
                if (kat == "Prizemlje") { prizemlje(); }
                else if (kat == "1 kat") { kat1(); }
                else if (kat == "2 kat") { kat2(); }
                else { kat3(); }
            }
            else if (checkBrzi.Checked == true)
            {
                if (kat == "Prizemlje") { prizemlje(); }
                else if (kat == "1 kat") { kat1(); }
                else if (kat == "2 kat") { kat2(); }
                else { kat3(); }
            }
            else
            {
                Dizalo_Svojstva.srednjirad();
                if (kat == "Prizemlje") { prizemlje(); }
                else if (kat == "1 kat") { kat1(); }
                else if (kat == "2 kat") { kat2(); }
                else { kat3(); }
            }
        }
        #endregion

        private void FormDizalo_Load_1(object sender, EventArgs e)
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
        
        #region Button
        private void butPokreni_Click(object sender, EventArgs e)
        {
            // Dizalo se u početku nalazi na prizemlju
            //Broj osoba je 0
            textTrenutniKat.Text = "Prizemlje";
            textTrenutnoOsoba.Text = "0";
            textSlobodnomjesta.Text = "10";
            prizemlje();
        }

        private void btnprizemlje_Click(object sender, EventArgs e)
        {
            string brosoba = this.brosprizemlje.SelectedItem.ToString();
            int br = Int32.Parse(brosoba);
            if (br == 0)
            {
                greška_osobe();
                return;
            }
            int max = Osoba.maxosoba;
            int osoba = max - br;
            textTrenutnoOsoba.Text = br.ToString();
            textSlobodnomjesta.Text = osoba.ToString();

            //Combobox - BR kat
            string brkat = this.comboprizemlje.SelectedItem.ToString();
            textTrenutniKat.Text = brkat;

            if (brkat == "Prizemlje")
            {
                greška_kat();
                textTrenutniKat.Text = "";
                return;
            }
            else {
                podaci(brkat);
            }
        }

        private void btn1kat_Click(object sender, EventArgs e)
        {
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
            if (brkat == "1 kat")
            {
                greška_kat();
                textTrenutniKat.Text = "";
                return;
            }
            else
            {
                podaci(brkat);
            }
        }

        private void btn2kat_Click(object sender, EventArgs e)
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
            if (brkat == "2 kat")
            {
                greška_kat();
                textTrenutniKat.Text = "";
                return;
            }
            else
            {
                podaci(brkat);
            }
        }

        private void btn3kat_Click(object sender, EventArgs e)
        {
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
            if (brkat == "3 kat")
            {
                greška_kat();
                textTrenutniKat.Text = "";
                return;
            }
            else
            {
                podaci(brkat);
            }
        }
        #endregion

        private void checkSpori_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSpori.Checked == true) { checkSpori.Checked = true; checkSrednji.Checked = false; checkBrzi.Checked = false; }
            if (checkSrednji.Checked == true) { checkSrednji.Checked = true; checkSpori.Checked = false; checkBrzi.Checked = false; }
            if (checkBrzi.Checked == true) { checkBrzi.Checked = true; checkSpori.Checked = false; checkSrednji.Checked = false; }
        }
    }
}
