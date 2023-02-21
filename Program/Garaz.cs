using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Garaz
    {
        // pole
        private string adres;
        private int pojemnosc;
        private int liczbaSamochodow = 0;
        private Samochod[] samochody;
        
        //przykłady
        private List<Samochod> samochody2;
        public string Gasnica { get; set;}

        // Konstruktor domyslny
        public Garaz()
        {
            adres = "nieznany";
            pojemnosc = 0;
            samochody = null;
            samochody2 = new List<Samochod>();
        }

        // Konstruktor
        public Garaz(string adres_, int pojemnosc_)
        {
            adres = adres_;
            Pojemnosc = pojemnosc_;
            samochody2 = new List<Samochod>();
        }

        //Właściwości
        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }
        public int Pojemnosc
        {
            get { return pojemnosc; }
            set
            {
                pojemnosc = value;
                samochody = new Samochod[pojemnosc];
            }
        }
        //Metody
        public void WprowadzSamochod(Samochod samochod)
        {
            int length = pojemnosc;
            if(length == liczbaSamochodow)
            {
                Console.WriteLine("Brak miejsca w garażu");
            }
            else
            {
                samochody[liczbaSamochodow] = samochod;
                liczbaSamochodow ++;
            }
        }

        public void WprowadzSamochod2(Samochod samochod)
        {
            samochody2.Add(samochod);
        }
        public Samochod WyprowadzSamochod2()
        {
            var sam = samochody2.LastOrDefault();
            samochody2.RemoveAt(samochody2.Count - 1);
            return sam;
        }
        public Samochod WyprowadzSamochod()
        {
            if (liczbaSamochodow == 0)
            {
               Console.WriteLine("Garaż jest pusty");
               throw new Exception("Garaż jest pusty");
            }
            else
            {
                Samochod samochod = samochody[liczbaSamochodow - 1];
                samochody[liczbaSamochodow - 1] = null;
                liczbaSamochodow--;

                return samochod;
                
            }
        }
        public void WypiszInfo()
        {
            for (int i = 0; i < samochody.Count(); i++)
            {
                if(samochody[i] != null)
                {
                    samochody[i].WypiszInfo();
                }
                
                Console.WriteLine("Adres : " + adres);
                Console.WriteLine("Pojemność garażu : " + pojemnosc);
            }
        }
    }
}
