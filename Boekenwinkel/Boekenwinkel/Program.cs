using Boekenwinkel.Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekenwinkel
{
    public class Program
    {
        static void Main(string[] args)
        {
            Boekwinkel winkel = new Boekwinkel("06-4011117, onzewinkel@gmail.com ", "ma - vrij : 09:00 - 17:00");

            Console.WriteLine("What would you like to do?");
            Console.WriteLine(" ");
            Console.WriteLine("#1  Add a new Book");
            Console.WriteLine("#2  Show the store contact information");
            // Console.Write(boekwinkelinformatie);

            string s = Console.ReadLine();
            
            if(s == "1")
            {
                
                Console.WriteLine("What edition of the book is it?");
                string druk = Console.ReadLine();
                Console.WriteLine("What is the ISBN?");
                string ISBN = Console.ReadLine();
                Console.WriteLine("What is the maximum amount of books to store in the shop");
                int max = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the minimum amount of books to store in the shop");
                int min = Convert.ToInt32(Console.ReadLine());
                

                Console.WriteLine("What is the title");
                string Titel = Console.ReadLine();
                Console.WriteLine("Who is the author");
                string Auteur = Console.ReadLine();
                Console.WriteLine("What is the language");
                Enum_Taal Taal = Console.ReadLine();
                Console.WriteLine("What is the mass?");
                int Gewicht = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the price");
                Decimal Prijs = Convert.ToDecimal(Console.ReadLine());
                Afmeting afmeting = new Afmeting(20, 20, 20);

                Boek boek1 = new Boek(Titel, Auteur, Taal, afmeting, Gewicht, Prijs, druk, ISBN, max, min);





            }


            if(s == "2")
            {
                string boekwinkelinformatie = winkel.Boekenwinkel();
                Console.WriteLine(boekwinkelinformatie);

            }

           
            Console.ReadKey();
        }
    }
}
