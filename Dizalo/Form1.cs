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
