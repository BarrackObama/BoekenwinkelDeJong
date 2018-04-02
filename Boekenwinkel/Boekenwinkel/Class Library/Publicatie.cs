using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekenwinkel.Class_Library
{
    public abstract class Publicatie
    {
        private string Titel;
        private string Auteur;
        private Enum_Taal Taal;
        private Afmeting Afmetingen;
        private int Gewicht;
        private decimal Prijs;

        public string titel { get { return Titel; } set { Titel = value; } }
        public string auteur { get { return Auteur; } set { Auteur = value; } }
        public Enum_Taal taal { get { return Taal; } set { Taal = value; } }
        public Afmeting afmetingen { get { return Afmetingen; } set { Afmetingen = value; } }
        public int gewicht { get { return Gewicht; } set { Gewicht = value; } }
        public decimal prijs { get { return Prijs; } set { Prijs = value; } }

        public Afmeting Afmeting
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Publicatie(string Titel, string Auteur, Enum_Taal Taal, Afmeting Afmetingen, int Gewicht, decimal Prijs)
        {
            Titel = titel;
            Auteur = auteur;
            Taal = taal;
            Afmetingen = afmetingen;
            Gewicht = gewicht;
            Prijs = prijs;

        }
        
        
    }
}
