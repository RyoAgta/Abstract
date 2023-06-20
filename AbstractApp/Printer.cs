using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractApp
{
    public abstract class Printer
    {
        public string JenisPrinter { get; set; }
        public int thnRilis { get; set; }
        public abstract void printWord();
    }
}
