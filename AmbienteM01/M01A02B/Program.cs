using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A02B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estud\tonauta");
            Console.WriteLine("Estud\bonauta");
            Console.WriteLine("Estudonauta\a");
            Console.WriteLine("Estudonau\rta");
            Console.WriteLine("\\Estudonauta\\");
            Console.WriteLine(@"\Estudonauta\");
            Console.WriteLine("\"Estudonauta\"");

            Console.ReadKey();
        }
    }
}
