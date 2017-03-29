using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Za pomocą wybranej implementacji wzorca projektowego Fabryka stwórz aplikację, która odwzoruje działania fabryki składającej podzespoły telefonów komórkowych,
//Założenie: każdy ekran musi być dopasowany do obudowy wytwarzanej przez tego samego producenta.
//Do wykorzystania masz następujące dane:
//Producenci: Samsung, Apple
//Produkt: Obudowa
//Produkt: Ekran

namespace zad4._3
{
    public interface ITelefon
    {
        void zlozTelefon();
    }

    public enum Marki
    {
        Apple, Samsung
    }

    class Samsung : ITelefon
    {
        public void zlozTelefon()
        {
            Telefon telefon = new Telefon();
            telefon.dodajObudowe("Samsung");
            telefon.dodajEkran("Samsung");
            Console.WriteLine("Złożono telefon marki Samsung");
        }
    }

    class Apple : ITelefon
    {
        public void zlozTelefon()
        {
            Telefon telefon = new Telefon();
            telefon.dodajObudowe("Apple");
            telefon.dodajEkran("Apple");
            Console.WriteLine("Złożono telefon marki Apple");
        }
    }


    static class TelefonFactory
    {
        public static ITelefon CreateTelefonObject(Marki markaTyp)
        {
            ITelefon telefon = null;
            switch (markaTyp)
            {
                case Marki.Apple:
                    telefon = new Apple();
                    break;
                case Marki.Samsung:
                    telefon = new Samsung();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("markaTyp", "Nieznana marka telefonu.");
            }
            return telefon;
        }
    }

    class Telefon
    {
        public void dodajObudowe(string firma)
        {
            Console.WriteLine("Dodano obudowę firmy " + firma);
        }

        public void dodajEkran(string firma)
        {
            Console.WriteLine("Dodano ekran firmy " + firma);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ITelefon tel1 = TelefonFactory.CreateTelefonObject(Marki.Apple);
            ITelefon tel2 = TelefonFactory.CreateTelefonObject(Marki.Samsung);

            tel1.zlozTelefon();
            tel2.zlozTelefon();

            Console.ReadKey();
        }
    }

    

    
}
