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

namespace Dizalo
{
    class Osoba
    {
        //Klasa Osoba se koristi za podatke o osobama koje koriste dizalo
        //Broj osoba,na koji kat osobe žele otići sa dizalom, max broj osoba
        public const int maxosoba = 10;

        protected int brosoba;
        protected string osobekat;

        //Get set
        public int Brosoba_property
        {
            get { return brosoba; }   // get method
            set { brosoba = value; }  // set method
        }

        //Get set
        public string Osobekat_property
        {
            get { return osobekat; }   // get method
            set { osobekat = value; }  // set method
        }
    }
}
