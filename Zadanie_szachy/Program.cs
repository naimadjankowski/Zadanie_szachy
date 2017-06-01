using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_szachy 
{
    class Program
    {
        static void Main(string[] args)
        {
            Szachownica plansza = Szachownica.Instance;
            Pozycja p = new Pozycja();
            Console.WriteLine("Figury na planszy: ");
            return Szachownica.Wyswietl();

            int FiguryNaPlanszy = plansza.LiczFigury();
            Console.WriteLine("Liczba figur na planszy : " + FiguryNaPlanszy);

            Krol k = new Krol();
            string nazwa = k.GetType().Name;
            k.color = Figura.Color;
            k.color = Figura.KOLOR_CZARNY;

            Console.WriteLine(k.ToString());

            Figura f = k;
            Console.WriteLine(f.ToString());

            Krol p = new Krol();
            p.kolor = Figura.KOLOR_BIALY;
            p.kolor = Figura.KOLOR_CZARNY;

            p.Pole = p.kolor.ToString() + p.nazwa.ToString();


            Krol ko = new Krol();
            ko.kolor = Figura.KOLOR_BIALY;
            ko.kolor = Figura.KOLOR_CZARNY;


            Console.WriteLine(ko.ToString());
            ko.Pozycja = ko.kolor.ToString() + ko.nazwa.ToString();



        }
    }
}