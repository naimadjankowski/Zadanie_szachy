﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_szachy
{
    class Krol
    {
        private string Nazwa = "Pionek";
        internal object color;

        public Krol(string kolor, Pozycja poz = null; 
            
        base : (Nazwa, Color, poz);
        

        public virtual bool CzyMozliwyRuch(Pozycja nowaPozycja)
        {
            return true;
        }
    }
}