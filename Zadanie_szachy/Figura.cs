using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_szachy
{
    abstract class Figura
    {
        public string Nazwa
        {
            get
            {
                return this.GetType().Name;
            }
        }
        public Pozycja pozycja = null;

        public string Color;
        public delegate void ZmianaPozycji();
        protected Pozycja

        Pozycja
        {
            get { return pozycja; }

            set
            {
                if (null != ZmianaPozycji) ZmianaPozycji();

                pozycja = value;
            }
        }

        public static object KOLOR_CZARNY { get; internal set; }
        public static object KOLOR_BIALY { get; internal set; }

        public virtual bool CzyIstniejeMozliwaoscRuchu(Pozycja nowaPozycja)
        {
            return true;
        }
        Figura()
        {

        }
        Figura(Pozycja pozycja)
        {
            this.pozycja = pozycja;
        }

        public void ZmianaPozycji()
        {
            Console.WriteLine("{Nazwa} nowa pozycja");
        }

        public string ToString()
        {
            return "Pionek: {Color} {Nazwa}";
        }

    }

    public static Figura Figura(string figura, string color)
    {
        switch (figura)
        {
            case "goniec":
                return new Goniec(color);

            case "krol":
                return new Krol(color);


            default:
                throw new Exception("Figura nieznana");

        }
    }
}