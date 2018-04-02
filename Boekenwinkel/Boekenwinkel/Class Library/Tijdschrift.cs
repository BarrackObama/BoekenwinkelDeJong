using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekenwinkel.Class_Library
{
    public class Tijdschrift : Publicatie
    {
        private string ISSN;
        private int AantalTijdschriftenBestellen;
        private DayOfWeek Besteldag;
        private DayOfWeek PublicatieDag;

        public string issn
        {
            get
            {
                return ISSN;
            }

            set
            {
                ISSN = value;
            }
        }

        public int aantaltijdschriftenbestellen
        {
            get
            {
                return AantalTijdschriftenBestellen;
            }

            set
            {
                AantalTijdschriftenBestellen = value;
            }
        }

        public DayOfWeek besteldag
        {
            get
            {
                return Besteldag;
            }

            set
            {
                Besteldag = value;
            }
        }

        public DayOfWeek publicatiedag
        {
            get
            {
                return PublicatieDag;
            }

            set
            {
                PublicatieDag = value;
            }
        }


        public Tijdschrift(string ISSN, int AantalTijdschriftenBestellen, DayOfWeek Besteldag, DayOfWeek PublicatieDag)
        {
            ISSN = issn;
            AantalTijdschriftenBestellen = aantaltijdschriftenbestellen;
            Besteldag = besteldag;
            PublicatieDag = publicatiedag;

        }
    }
}
