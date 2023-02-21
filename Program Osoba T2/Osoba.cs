using System;

namespace Program
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string dataUrodzenia;

        public Osoba()
        {
            imie = "nie podano";
            nazwisko = "nie podano";
            dataUrodzenia = "nie podano";
        }
        public Osoba(string imie, string nazwisko, string dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
        }

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
        public string DataUrodzenia
        {
            get { return dataUrodzenia; }
            set { dataUrodzenia = value; }
        }

        public virtual void WypiszInfo()
        {
            Console.WriteLine(imie);
            Console.WriteLine(nazwisko);
            Console.WriteLine(dataUrodzenia);
        }
    }
}
