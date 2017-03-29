using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4._2
{
    class ZwyklyTelefon : ITelefon
    {
        public void wybierzNumer()
        {
            Console.WriteLine("Telefon wybiera numer.");
        }
        public void wyslijWiadomosc()
        {
            Console.WriteLine("Telefon wysyła wiadomość.");
        }
        public void pokazTyp()
        {
            Console.WriteLine("Rodzaj telefonu: ZwyklyTelefon");
        }
    }
}
