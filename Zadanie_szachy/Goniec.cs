using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_szachy
{
    class Goniec
    {
        private string Nazwa = "Goniec";

        public Goniec(string kolor, Pozycja poz = null; 
          
         base : (Nazwa, Color, poz);

        public virtual bool CzyIstniejeMozliwaoscRuchu(Pozycja nowaPozycja)
        {
            return true;
        }
    }
}