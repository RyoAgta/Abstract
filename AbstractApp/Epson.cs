using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractApp
{
    public class Epson : Printer
    {
        public override void printWord()
        {
            Console.WriteLine("jenis printer ini adalah {0}", JenisPrinter);
            Console.WriteLine("Rilis pada tahun {0}", thnRilis);
            Console.WriteLine("Epson printer printing....");
            Console.WriteLine("Printer Windows display dimension : 10*11");
        }
    }
}
