using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassendefinieren_04_2021
{
    public class Auto
    {
        private int aktGeschwindigkeit;

        public Auto(string autoMarke)
        {
            Marke = autoMarke;
            AlterinJahren = 0;
            aktGeschwindigkeit = 0;
        }

        public int AlterinJahren { get; set; }  // mit prob


        private string marke;                   // mit probfull

        public string Marke
        {
            get { return marke; }
            set 
            {
                if (value == "Porsche")
                {
                    marke = value;
                }
                else if (value == "Opel")
                {
                    marke = value;
                }
                else
                {
                    Console.Write("Nicht unterstützt ");
                }
            }
        }


        public void Beschleunigenauf100kmh()
        {
            aktGeschwindigkeit = 100;

            if (IstSchnell())
            {
                Console.Write($"Der {marke} hat schnell beschleunigt! Yeah!");
            }
            else
            {
                Console.Write($"Der {marke} hat normal beschleunigt!");
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
            Console.Write($"Die aktuelle Geschwindikeit beträgt: {aktGeschwindigkeit}");
            Console.ReadLine();
        }
    }
}
