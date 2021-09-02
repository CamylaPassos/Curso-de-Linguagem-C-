using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variaveis
            byte n = 20;
            Console.WriteLine("A variável n tem " + n);
            Console.WriteLine("n é do tipo " + n.GetType());
            Console.ReadKey();

            var nome = "Camyla";
            Console.WriteLine("A variável nome tem " + nome);
            Console.WriteLine("nome é do tipo " + nome.GetType());
            Console.ReadKey();
        }
    }
}
