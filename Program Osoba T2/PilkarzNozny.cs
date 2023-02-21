using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class PilkarzNozny : Pilkarz
    {
        public PilkarzNozny(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub) : base(imie, nazwisko, dataUrodzenia, pozycja, klub)
        {

        }

        public override void StrzelGola()
        {
            base.StrzelGola();
            Console.WriteLine("Nożny strzelił!");
        }
    }
}
