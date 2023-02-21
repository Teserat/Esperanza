using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Osoba
    {
        // Pole 
        private string imie;
        private string nazwisko;
        private string adresZamieszkania;
        private int iloscSamochodow = 0;
        private string[] tablicaNumerowRejestracyjnych;


        // Konstruktor inicjujący
        public Osoba()
        {
            tablicaNumerowRejestracyjnych = new string[3]; ;
            imie = "nie podano";
            nazwisko = "nie podano";
            adresZamieszkania = "nie podano";
        }
        // Konstruktor 
        public Osoba(string imie_, string nazwisko_, string adresZamieszkania_, int iloscSamochodow_)
        {

            tablicaNumerowRejestracyjnych = new string[3];
            imie = imie_;
            nazwisko = nazwisko_;
            adresZamieszkania = adresZamieszkania_;
            iloscSamochodow = iloscSamochodow_;
        }
        // Właściwości
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
        public string AdresZamieszkania
        {
            get { return adresZamieszkania; }
            set { adresZamieszkania = value; }
        }
        public int IloscSamochodow
        {
            get { return iloscSamochodow; }
            set { iloscSamochodow = value; }
        }


        // Metody
        public void DodajSamochod(string nrRejestracyjny)
        {
            tablicaNumerowRejestracyjnych[iloscSamochodow] = nrRejestracyjny;
            iloscSamochodow++;
            return;
        }
        public void UsunSamochod(string nrRejestracyjny)
        {
            if (iloscSamochodow == 0)
            {
                Console.WriteLine("Osoba nie posiada przypisanych samochodów");
            }
            else
            {
                var number = 0;
                var carNumber = nrRejestracyjny;
                for (int i = 1; i <= 3; i++)
                {
                    if (tablicaNumerowRejestracyjnych[number] == carNumber)
                    {
                        Console.Write("Pojazd o numerze rejestracyjnym {0}, został usunięty", carNumber);
                        tablicaNumerowRejestracyjnych[number] = null;
                        iloscSamochodow--;
                        return;
                    }
                    number++;
                }
            }
        }
        public void WypiszInfo()
        {
            Console.WriteLine();
            Console.WriteLine("\nPojazdy, posiadane przez osobę {0}", imie);
            foreach (var i in tablicaNumerowRejestracyjnych)
            {
                if (i != null)
                {
                    Console.WriteLine("{0}", i);
                }
            }
        }
    }
}
