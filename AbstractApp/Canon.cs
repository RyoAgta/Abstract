using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractApp
{
    internal class Canon : Printer
    {
        public override void printWord() 
        {
            Console.WriteLine("jenis printer {0}", JenisPrinter);
            Console.WriteLine("Rilis pada tahun {0}", thnRilis);
            Console.WriteLine("Canon printer printing....");
            Console.WriteLine("Canon display dimension : 10*11");
        }
    }
}
