using System;
//przed puszczeniem do git, dodaj gitignore
namespace Program
{
    class Program2
    {
        static int infoBlock = 1;
        static void Main(string[] args)
        {
            //Sprawdzenie własne Zad.1 true ON // false OFF
            if (false)
            {
                Info("Własny przykład Osoby");
                Osoba o1 = new Osoba("Janek", "Kowalski", "22-01-1999");
                o1.WypiszInfo();
                Info("Własny przykład Studenta");
                Student s1 = new Student("Tolek", "Krejzolek", "15-02-2001", 2333, 33, 222);
                s1.WypiszInfo();
                Info("Własny przykład Piłkarza");
                Pilkarz p1 = new Pilkarz("Konstanty", "Niemaniak", "24-05-1995", "Napastnik", "Sokoły-Podlaskie");
                p1.WypiszInfo();
                Console.ReadKey();
            }
            //Sprawdzenie testem wykładowcy zadania 1 i 2 - musi być wartość "true" , w przeciwnym razie "false"
            if(false)
            {
                Info("Test wykłądowcy weryfikujący z Zad.1");

                Osoba o = new Osoba("Adam", "Miś", "20.03.1980");
                Osoba o2 = new Student("Michał", "kot", "13.04.1998", 2, 1, 12345);
                Osoba o3 = new Pilkarz("mateusz", "żbik", "10.08.1986", "obrońca", "fC czestochowa");
                o.WypiszInfo();
                o2.WypiszInfo();
                o3.WypiszInfo();
                Student s = new Student("krzysztof", ")eż", "22.12.1990", 2, 5, 54321);
                Pilkarz p = new Pilkarz("Piotr", "Kos", "14.09.1984", "napastnik", "FC Politechnika");
                
                s.WypiszInfo();
                p.WypiszInfo();

                ((Pilkarz)o3).StrzelGola();
                p.StrzelGola();
                p.StrzelGola();
                o3.WypiszInfo();
                p.WypiszInfo();
                Console.ReadKey();

                Info("Test weryfikujący z Zad.2");

                ((Student)o2).DodajOcene("PO", "20.02.2011", 5.0);
                ((Student)o2).DodajOcene("Bazy danych", "13.02.2011", 4.0);
                o2.WypiszInfo();
                s.DodajOcene("Bazy danych", "01.05.2011", 5.0);
                s.DodajOcene("AW₩", "11.05.2011", 5.0);
                s.DodajOcene("AW₩", "02.04.2011", 4.5);
                s.WypiszInfo();
                s.UsunOcene("AW₩", "02.04.2011", 4.5);
                s.WypiszInfo();
                s.DodajOcene("AWw", "02.04.2011", 4.5);
                s.UsunOceny("AMaN");
                s.WypiszInfo();
                s.DodajOcene("AWw", "02.04.2011", 4.5);
                s.UsunOceny();
                s.WypiszInfo();
                Console.ReadKey();

            }

            //Sprawdzenie testem włąsnym Zad.2
            Info("Wipisanie wartości tablicy ocen, po wpisaniu ocen");
            Student stu1 = new Student("Jeremi", "Paszczyszak", "15-02-2004", 2333, 33, 222);
            stu1.DodajOcene("Polski", "12-02-2002", 2);
            stu1.DodajOcene("Matematyka", "10-01-2002", 1);
            stu1.DodajOcene("Polski", "02-02-2002", 4);
            stu1.DodajOcene("Geografia", "12-02-2002", 3);
            stu1.DodajOcene("Geografia", "19-02-2002", 5);
            stu1.WypiszOceny();
            Info("Sprawdzenie ile ocen jest z Polskiego");
            stu1.WypiszOceny("Polski");
            Info("Usuwam 1 ocenę (poprawiona, 2 na 4) i drukuję listę ocen");
            stu1.UsunOcene("Polski", "12-02-2002", 2);
            stu1.WypiszOceny();
            Info("Usuwam oceny z Geografii");
            stu1.UsunOceny("Geografia");
            stu1.WypiszOceny();
            Info("Wypisz info z ocenami");
            stu1.WypiszInfo();
            Info("Usuwam wszystkie oceny");
            stu1.UsunOceny();
            stu1.WypiszOceny();
            // Weryfikacja własna zad 3 - domowego
            Info("Test utworzenia nowej klasy z dziedziczeniem");
            PilkarzNozny pn1 = new PilkarzNozny("Muniek", "Szybczak", "31-12-2011", "Napastnik", "Wisła Kraków");
            pn1.StrzelGola();
            pn1.WypiszInfo();

            Console.ReadKey();

        }
        static void Info(string info)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---BEGINNING--OF--BLOCK----- {0}" + " {1}", infoBlock, info);
            infoBlock++;
            Console.ResetColor();
        }
    }
}
// Klasa  bazowa i pochodna zamiast nazewnictwa rodzic/dziecko
// https://kisi.pcz.pl/~pnajgebauer/obiektowe/