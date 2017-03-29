using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Stwórz klasę Uczelnia z następującymi atrybutami:
//DataRekrutacji parametr w konstruktorze,
//Metoda RekrutujStudentow - wypisuje datę następnej rekrutacji,
//Utwórz dwa obiekty klasy Uczelnia - UWM oraz Stanford.
//Wypisz datę następnej rekrutacji dla obu uczelni.
//Korzystając z wzorca Singleton przerób klasę Uczelnia, tak aby odpowiadała jego założeniom.
//Ponownie wypisz datę rekrutacji. Czy zauważyłeś różnicę?


namespace zad4._1
{
    class Uczelnia
    {
        private static Uczelnia ob;
        private DateTime DataRekrutacji;

        private Uczelnia() { }

        public static Uczelnia getInstance(DateTime dataRekrutacji)
        {
            if (ob == null)
            {
                ob = new Uczelnia();
                ob.DataRekrutacji = dataRekrutacji;
            }
            return ob;
        }

        public void RekrutujStudentow()
        {
            Console.WriteLine("Rekrutacja odbywa sie: " + this.DataRekrutacji);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {

            Uczelnia UWM = Uczelnia.getInstance     (new DateTime(2018, 4, 12, 13, 12, 12));
            Uczelnia Stanford = Uczelnia.getInstance(new DateTime(2018, 5, 13, 12, 12, 12));

            UWM.RekrutujStudentow();
            Stanford.RekrutujStudentow();

            Console.ReadKey();


        }
    }

    
}
