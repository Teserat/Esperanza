using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Pilkarz : Osoba
    {
        private string pozycja;
        private string klub;
        private int liczbaGoli = 0;

        public Pilkarz (string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub) : base (imie, nazwisko, dataUrodzenia)
        {
            this.pozycja = pozycja;
            this.klub = klub;
        }

        public string Pozycja
        { 
            get { return pozycja; } 
            set { pozycja = value; } 
        }
        public string Klub
        {
            get { return klub; }
            set { klub = value; }
        }
        public int LiczbaGoli
        {
            get { return liczbaGoli; }
            set { liczbaGoli = value; }
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine(pozycja);
            Console.WriteLine(klub);
            Console.WriteLine(liczbaGoli);
        }
        public virtual void StrzelGola()
        {
            liczbaGoli++;
        }

    }
}
