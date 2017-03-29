using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4._2
{
    class Smartphone : Dekorator
    {
        private string _rodzaj;


        public Smartphone(ZwyklyTelefon zwyklyTelefon, string rodzaj)
            : base(zwyklyTelefon)
        {
            _rodzaj = rodzaj;
            this.zwyklytelefon = zwyklyTelefon;
        }

        
        public void pokazTyp()
        {
            Console.WriteLine("Rodzaj telefonu: " + _rodzaj);
        }

        public void odbierzPolaczenie()
        {
            Console.WriteLine("Telefon odebrał połączenie.");
        }

        public void odrzucPolaczenie()
        {
            Console.WriteLine("Telefon odrzucił połączenie.");
        }


    }
}
