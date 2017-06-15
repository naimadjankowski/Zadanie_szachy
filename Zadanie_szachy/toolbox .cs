using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_szachy
{
   sealed class toolbox
    {
        private static Szachownica szachownica = new Szachownica();
        private toolbox() { }

        public static Szachownica szachownicaInstance
        {
            get
            {
                return szachownica;
            }
        }
    }
}
