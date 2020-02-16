using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dizalo.Properties;

namespace Dizalo.Dizalo_Svojstva
{
    class Dizalo_svojstva
    {
        //Varijable za rad sa svojstvima dizala
        public const int maxbrosoba_dizalo = Osoba.maxosoba;

        protected int dizalosobe;
        protected string dizalokat;
        //FormDizalo dizalo = new FormDizalo();

        //Get set
        public int Dizalosobe_property
        {
            get { return dizalosobe; }   // get method
            set { dizalosobe = value; }  // set method
        }

        //Get set
        public string Dizalokat_property
        {
            get { return dizalokat; }   // get method
            set { dizalokat = value; }  // set method
        }

        //Spori rad dizala
        public void sporirad() {
            Thread.Sleep(3000);
        }

        //Brzi rad dizala
        public void srednjirad()
        {
            Thread.Sleep(3000);
        }

        //Koliko ima slobodno mjesta u dizalo
        public int slobodnomjesta(int trenutno) {
            return dizalosobe = maxbrosoba_dizalo - trenutno;
        }
      
    }
}
