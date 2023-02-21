using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Info();
            {
                //Przykłąd z samochodem, garażem oraz osobami. Wykonywane są metody, wpływające na klasy
                //samochody można dodać, usunąć samochód oraz wyliczyć spalanie, dodać usunąc samochód w garażu
                //oraz przypisać posiadane auta do osoby. Wszystkie obiekty posiadają metodę WypiszInfo() 
                PrzykladySamochod.Zadanie1();
                //PrzykladySamochod.Zadanie2();
                //PrzykladySamochod.Zadanie3();
            }
            





            Console.ReadKey();
        }
        static void Info()
            {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---BEGINNING--OF--TASK------");
            Console.ResetColor();
            }
    }
}

// https://kisi.pcz.pl/~pnajgebauer/obiektowe/