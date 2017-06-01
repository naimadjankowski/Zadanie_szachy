using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_szachy 
{ 
    internal class Pozycja
    {
        string pole;
        int x;
        int y;
        internal object kolor;

        public string Pole
        {
            get
            {
                return pole;
            }

            set
            {
                pole = value;

                x = LiczX(pole);
                y = LiczY(pole);
            }
        }

        public int C7
        {
            get
            {
                return x;
            }
        }

        public int b
        {
            get
            {
                return y;
            }
        }

        internal static int LiczX(string pole)
        {
            return pole[0] - 'A' + 1;
        }
        internal static int LiczY(string pole)
        {
            return Int32.Parse(pole.Substring(1));
        }

        public Pozycja()
        {
            pole = null;

            x = 0;
            y = 0;
        }
        public Pozycja(string pole)
        {
            this.Pole = pole;
        }

    }
}