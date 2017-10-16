using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ArtikelKlasse
{
    
    class Program
    {
        public static string[,] testArtikel = { { "Kürbis", "2", "1,79" }, { "Forelle", "1,2", "4,99" }, { "Hundefutter", "6", "11,99" } };

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;



            Artikel[] neuerArtikel = { new Artikel(1), new Artikel(2), new Artikel(3) };

            foreach(Artikel produkt in neuerArtikel)
            {
                produkt.Show();
            }

            Console.ReadLine();
        }
    }
}
