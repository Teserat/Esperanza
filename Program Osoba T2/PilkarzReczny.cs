using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class PilkarzReczny : Pilkarz
    {
        public PilkarzReczny(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub) : base(imie, nazwisko, dataUrodzenia, pozycja, klub)
        {

        }
        public override void StrzelGola()
        {
            base.StrzelGola();
            Console.WriteLine("Ręczny strzelił!");
        }
    }
}
