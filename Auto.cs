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

        public void Beschleunigenauf100kmh()
        {
            if (IstSchnell())
            {
                Console.WriteLine("Ich habe schnell beschleunigt! Yeah!");
            }
            else
            {
                Console.WriteLine("Ich habe normal beschleunigt!");
            }
            
        }

        private bool IstSchnell()
        {
            if (marke == "Porsche")
            {
                return true;
            }

            return false;
        }
    }
}
