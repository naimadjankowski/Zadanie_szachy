using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_szachy
{
    class Krol
    {
        private string Nazwa = "Krolowa";
        internal object kolor;

        public int Pozycja { get; internal set; }

        public Krol(string kolor, Pozycja poz = null; 
            
        base : (public Krol()
        {
        }

        Nazwa, Color, poz);

        public virtual bool CzyIstniejeMozliwaoscRuchu(Pozycja nowaPozycja)
        {
            return true;
        }
    }
}

