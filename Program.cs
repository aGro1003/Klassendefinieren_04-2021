using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassendefinieren_04_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto meinAuto = new Auto("Opel");
            Auto deinAuto = new Auto("Porsche");

            meinAuto.AlterinJahren = 2;
            deinAuto.AlterinJahren = 5;

            meinAuto.AktuelleGeschwindigkeit();
            deinAuto.AktuelleGeschwindigkeit();

            meinAuto.Beschleunigenauf100kmh();
            deinAuto.Beschleunigenauf100kmh();

            meinAuto.AktuelleGeschwindigkeit();
            deinAuto.AktuelleGeschwindigkeit();
        }
    }
}
