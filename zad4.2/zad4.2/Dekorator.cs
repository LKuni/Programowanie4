using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4._2
{
    class Dekorator : ITelefon
    {
        protected ZwyklyTelefon zwyklytelefon;

        public Dekorator(ZwyklyTelefon zwyklyTelefon)
        {
            zwyklytelefon = zwyklyTelefon;
        }

        public void wybierzNumer()
        {
            zwyklytelefon.wybierzNumer();
        }
        public void wyslijWiadomosc()
        {
            zwyklytelefon.wyslijWiadomosc();
        }
        public void pokazTyp()
        {
            zwyklytelefon.pokazTyp();
        }
    }
}
