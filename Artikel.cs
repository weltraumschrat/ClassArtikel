using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtikelKlasse
{
    class Artikel
    {
        private int _id;
        private string _bezeichnung;
        private double _volumen;
        private double _preis;

        public Artikel()
        {
        }
        public Artikel(int id)
        {
            _id = id;
            _bezeichnung = Program.testArtikel[id - 1, 0];
            _volumen = Convert.ToDouble(Program.testArtikel[id - 1, 1]);
            _preis = Convert.ToDouble(Program.testArtikel[id - 1, 2]);
        }
        public void Show()
        {
            Console.WriteLine("Artikel #{0} ist {1}, hat ein Volumen von {2} und einen Preis von {3:C}", _id, _bezeichnung,_volumen,_preis);
        }
    }
}
