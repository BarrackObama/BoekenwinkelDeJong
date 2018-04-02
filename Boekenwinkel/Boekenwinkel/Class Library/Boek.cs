using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekenwinkel.Class_Library
{
    public class Boek : Publicatie
    {
        private string Druk;
        private string ISBN;
        private int MinimumVoorraad;
        private int MaximumVoorraad;
        private int Voorraad;
        private string BestelRegel;

        public string druk
        {
            get
            {
                return Druk;
            }

            set
            {
                Druk = value;
            }
        }

        public string isbn
        {
            get
            {
                return ISBN;
            }

            set
            {
                ISBN = value;
            }
        }

        public int minimumvoorraad
        {
            get
            {
                return MinimumVoorraad;
            }

            set
            {
                MinimumVoorraad = value;
            }
        }

        public int maximumvoorraad
        {
            get
            {
                return MaximumVoorraad;
            }

            set
            {
                MaximumVoorraad = value;
            }
        }

        public string bestelregel
        {
            get
            {
                return BestelRegel;
            }
        }


        public Boek(string Titel, string Auteur, Enum_Taal Taal, Afmeting Afmetingen, int Gewicht, decimal Prijs, string Druk, string ISBN, int MaximumAantal, int MinimumAantal) : base(Titel, Auteur, Taal, Afmetingen, Gewicht, Prijs)
        { 
            Druk = druk;
            ISBN = isbn;
            MaximumAantal = maximumvoorraad;
            MinimumAantal = minimumvoorraad;
        }
    }
}
