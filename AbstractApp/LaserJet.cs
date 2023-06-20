using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractApp
{
    internal class LaserJet : Printer
    {
        public override void printWord()
        {
            Console.WriteLine("jenis printer ini adalah {0}", JenisPrinter);
            Console.WriteLine("Rilis pada tahun {0}", thnRilis);
            Console.WriteLine("LaserJet printer printing....");
            Console.WriteLine("LaserJet display dimension : 10*11");
        }
    }
}
