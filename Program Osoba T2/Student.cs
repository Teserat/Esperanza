using System;
using System.Collections.Generic;

namespace Program
{
    class Student : Osoba
    {
        private int rok;
        private int grupa;
        private int numerIndeksu;
        private List<Ocena> oceny = new List<Ocena>();

        public Student(string imie, string nazwisko, string dataUrodzenia, int rok, int grupa, int numerIndeksu) : base(imie, nazwisko, dataUrodzenia)
        {
            this.rok = rok;
            this.grupa = grupa;
            this.numerIndeksu = numerIndeksu;
        }

        public int Rok
        {
            get { return rok; }
            set { rok = value; }
        }
        public int Grupa
        {
            get { return grupa; }
            set { grupa = value; }
        }
        public int NumerIndeksu
        {
            get { return numerIndeksu; }
            set { numerIndeksu = value; }
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine(rok);
            Console.WriteLine(Grupa);
            Console.WriteLine(NumerIndeksu);
            foreach (Ocena ocena in oceny)
            {
                Console.WriteLine(ocena.NazwaPrzedmiotu);
                Console.WriteLine(ocena.Data);
                Console.WriteLine(ocena.Wartosc);
            }

        }
        public void DodajOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            Ocena ocena = new Ocena(nazwaPrzedmiotu,data,wartosc);
            oceny.Add(ocena);
            return;
        }
        public void WypiszOceny()
        {
            if (oceny.Count == 0)
            { 
                Console.WriteLine("Student nie posiada ocen");
                return;
            }
            foreach (Ocena ocena in oceny)
            {
                Console.WriteLine(ocena.NazwaPrzedmiotu);
                Console.WriteLine(ocena.Data);
                Console.WriteLine(ocena.Wartosc);
            }
        }
        public void WypiszOceny(string nazwaPrzedmiotu)
        {
            for(int i = 0; i < oceny.Count; i++)
            {
                if(nazwaPrzedmiotu.Equals(oceny[i].NazwaPrzedmiotu))
                {
                    Console.WriteLine(oceny[i].NazwaPrzedmiotu);
                    Console.WriteLine(oceny[i].Data);
                    Console.WriteLine(oceny[i].Wartosc);
                }
            }
        }
        public void UsunOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            for (int i = 0; i < oceny.Count;)
            {
                Ocena o = oceny[i];
                if (o.NazwaPrzedmiotu == nazwaPrzedmiotu && o.Data == data && o.Wartosc == wartosc)
                {
                    oceny.RemoveAt(i);
                }
                else
                {
                    ++i;
                }
            }
        }
        public void UsunOceny(string nazwaPrzedmiotu)
        {
            for (int i = 0; i < oceny.Count; )
            {
                Ocena o = oceny[i];
                if (o.NazwaPrzedmiotu == nazwaPrzedmiotu)
                {
                    oceny.RemoveAt(i);
                } // jak by było i++ w for, count to by powiększał się licznik ciągle,
                  // powodując błąd, bo  powiększając się gdy usuwa rozminą by się
                  // Musi usuwać się tylko gdy nie dodaje i++, bo np. i = 5 a Count po usunięciu, był by  4 
                else
                {
                    i++;
                }

            }

        }


        public void UsunOceny()
        {
            oceny.Clear();
        }

    }


}
