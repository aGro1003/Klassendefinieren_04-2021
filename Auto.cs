using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassendefinieren_04_2021
{
    public class Auto
    {
        public string marke;
        public int alterinJahren;
        private int aktGeschwindigkeit;

        public void Beschleunigenauf100kmh()
        {
            aktGeschwindigkeit = 100;

            if (IstSchnell())
            {
                Console.WriteLine("Ich habe schnell beschleunigt! Yeah!");
            }
            else
            {
                Console.WriteLine("Ich habe normal beschleunigt!");
            }
            Console.ReadLine();
        }

        private bool IstSchnell()
        {
            if (marke == "Porsche")
            {
                return true;
            }

            return false;
        }

        public void AktuelleGeschwindigkeit()
        {
            Console.WriteLine($"Die aktuelle Geschwindikeit beträgt: {aktGeschwindigkeit}");
            Console.ReadLine();
        }
    }
}
