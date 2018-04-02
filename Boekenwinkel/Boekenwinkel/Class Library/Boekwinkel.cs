using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekenwinkel.Class_Library
{
    public class Boekwinkel

    {
        private string Contactinformatie;
        private string Openingstijden;
        private int Voorraad;

        public string contactinformatie
        {
            get
            {
                return Contactinformatie;
            }

            set
            {
                Contactinformatie = value;
            }
        }

        public string openingstijden
        {
            get
            {
                return Openingstijden;
            }

            set
            {
                Openingstijden = value;
            }
        }

        public Publicatie Publicatie
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Boekwinkel(string contactinfo, string openingstijden)
        {
            Contactinformatie = contactinfo;
            Openingstijden = openingstijden;
        }

        public string Boekenwinkel()
        {
            return Contactinformatie + Openingstijden;
        }
    }
}
