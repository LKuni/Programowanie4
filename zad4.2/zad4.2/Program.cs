using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stwórz interface ITelefon, który będzie posiadał atrybuty:
//Metody: WybierzNumer, WyslijWiadomosc, PokazTyp,
//Stwórz klasę ZwyklyTelefon, który dziedziczy po ITelefon,
//Stwórz klasę Dekorator, która będzie dziedziczyć po ITelefon i implementować założenia wzorca projektowego,
//Stwórz klasę Smartphone, która będzie dziedziczyć po Dekorator
//W konstruktorze przyjmij ZwyklyTelefon oraz rodzaj telefonu,
//Dodaj dwie dodatkowe metody dla klasy Smartphone, które nie powinny być dostępne dla ZwykłyTelefon,
//Wyświetl wyniki metod w konsoli.


namespace zad4._2
{

    
    class Program
    {
        static void Main(string[] args)
        {
            ZwyklyTelefon zwyklyTelefon = new ZwyklyTelefon();
            zwyklyTelefon.pokazTyp();
            zwyklyTelefon.wybierzNumer();
            zwyklyTelefon.wyslijWiadomosc();
            Console.WriteLine("\n");

            Dekorator dekorator = new Dekorator(zwyklyTelefon);
            dekorator.pokazTyp();
            dekorator.wybierzNumer();
            dekorator.wyslijWiadomosc();
            Console.WriteLine("\n");

            Smartphone smartphone = new Smartphone(zwyklyTelefon, "Smartphone");
            smartphone.pokazTyp();
            smartphone.wybierzNumer();
            smartphone.wyslijWiadomosc();
            smartphone.odbierzPolaczenie();
            smartphone.odrzucPolaczenie();

            Console.ReadKey();
        }
    }

    
}
