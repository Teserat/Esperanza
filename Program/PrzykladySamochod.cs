using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class PrzykladySamochod

    {
        public static void Zadanie1()
        {
            //test na zakonczenie Zad 1(można zwinąć)
            if (true)
            {
                Samochod s1 = new Samochod();
                s1.WypiszInfo();
                s1.Marka = "Fiat";
                s1.Model = "126p";
                s1.IloscDrzwi = 2;
                s1.PojemnoscSilnika = 650;
                s1.SrednieSpalanie = 6.0;
                s1.WypiszInfo();
                Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);
                s2.WypiszInfo();
                double kosztPrzejazdu = s2.ObliczKosztPrzejazdu(30.5, 4.85);
                Console.WriteLine("Koszt przejazdu: " + kosztPrzejazdu);
                Samochod.WypiszIloscSamochodow();
                Console.ReadKey();
            }
            //włąsne notatki(można zwinąć)
            if (true)
            {
                Samochod s3 = new Samochod();
                {
                    s3.Marka = "Toyota";
                    s3.Model = "Supra";
                    s3.IloscDrzwi = 2;
                    s3.PojemnoscSilnika = 3000;
                    s3.SrednieSpalanie = 14.0;
                }
                Garaz g1 = new Garaz();
                g1.Adres = "Polna 13";
                g1.Pojemnosc = 1;
                g1.WprowadzSamochod(s3);
                g1.WypiszInfo();
                Console.WriteLine("------------\n wyjechanie auta z garażu \n------------");
                g1.WyprowadzSamochod();
                g1.WypiszInfo();

                Console.ReadKey();
            }
        }
        public static void Zadanie2()
        {
            // można zwinąć // Test na zakończenie Zadania 2
            Samochod s1 = new Samochod("Fiat", "126p", 2, 650, 6.0);
            Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);
            Garaz g1 = new Garaz();
            g1.Adres = "ul. Garażowa 1";
            g1.Pojemnosc = 1;
            Garaz g2 = new Garaz("ul. Garażowa 2", 2);
            g1.WprowadzSamochod(s1);
            g1.WprowadzSamochod(s1);
            g1.WypiszInfo();
            g1.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s1);
            g2.WypiszInfo();

            g2.WyprowadzSamochod();
            g2.WypiszInfo();

            g2.WyprowadzSamochod();
            // przykłąd z throw exception w kodzie dla usunięcia o raz za dużo
            g2.WyprowadzSamochod();
            Console.ReadKey();
        }
        public static void Zadanie3()
        {
            Osoba o1 = new Osoba();
            Osoba o2 = new Osoba("Jan", "Koniczyna", "Zadupie 1", 0); // Do sprawdzenia konstruktor - chodzi o tablice
            Samochod s1 = new Samochod("Fiat", "126p", 2, 650, 6.0, "DOD 20303");
            Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6, "KORMORAN1");
            Samochod s3 = new Samochod("Yoyota", "Supra", 2, 3000, 14.0, "WAW SUPRA");

            o2.DodajSamochod(s1.NumerRejestracyjny);
            o2.DodajSamochod(s2.NumerRejestracyjny);
            o2.DodajSamochod(s3.NumerRejestracyjny);

            o2.WypiszInfo();

            o2.UsunSamochod(s2.NumerRejestracyjny);

            o2.WypiszInfo();

            Console.ReadKey();
        }
    }
}
