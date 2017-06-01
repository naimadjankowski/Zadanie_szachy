
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_szachy
{
    class Szachownica
    {

        private static readonly Szachownica szachownica = new Szachownica();
        private const int rozmiar = Szachownica.ROZMIAR;

        private string
            ustaw1 = "[x]", ustaw2 = "[ ]";
        private string plansza;
        private object litery;

        public static Szachownica Instance
        {
            get
            {
                return szachownica;
            }
        }

        public List<char> Litery { get; private set; }
        public static int ROZMIAR { get; private set; }

        static Szachownica()
        {
        }

        private Szachownica()
        {
            //parametry
            plansza = new string[rozmiar, rozmiar];
            plansza.Ustaw(ustaw1, ustaw2, rozmiar);
        }

        public string this[Figura f, Pozycja poz]
        {
            get
            {
                return plansza[poz.x, poz.b];
            }
            set
            {
                f.pozycja = poz;
                plansza[poz.a, poz.b] = value;
            }
        }

        static class LiczFigury
        {
            public static int LiczFigury(this Szachownica plansza)
            {
                int = 0;

                foreach 
                    (var b in plansza)
                {
                    a++;
                }

                return a;//zwrot wart 
            }
        }

        public void Wyswietl()
        {
            string t;
            Litery = new Litery()
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H'
            };

            for (int y = 0; y < rozmiar; y++)
            {
                t += (rozmiar - y) + "\t";

                for (int z = 0; z < rozmiar; z++)
                {
                    t += plansza[y, z] + "\t";
                }

                t += '\n';
            }

            t += "\t";
            for (int w = 0; w < litery.Count; w++)
            {
                t += $" {litery.ElementAt(w).ToString().ToUpper()}\t";
            }
            Console.WriteLine(t);
        }

    }
    }
    //Modyfikator override powoduje nadpisanie metody odziedziczonej z typu bazowego
   // Modyfikator  new  ukrywa element członkowski, który jest dziedziczony z klasy bazowe