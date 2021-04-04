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
            Auto meinAuto = new Auto();
            Auto deinAuto = new Auto();

            meinAuto.alterinJahren = 2;
            meinAuto.marke = "Opel";

            deinAuto.alterinJahren = 5;
            deinAuto.marke = "Porsche";

            meinAuto.AktuelleGeschwindigkeit();
            deinAuto.AktuelleGeschwindigkeit();

            meinAuto.Beschleunigenauf100kmh();
            deinAuto.Beschleunigenauf100kmh();

            meinAuto.AktuelleGeschwindigkeit();
            deinAuto.AktuelleGeschwindigkeit();
        }
    }
}
