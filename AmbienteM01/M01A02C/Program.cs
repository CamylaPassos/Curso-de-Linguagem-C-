using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A02C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(10,5);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Olá, Pessoa!");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            Console.SetCursorPosition(10,5);
            Console.WriteLine("Tudo bem com você?");
            Console.ReadKey();
            Console.Clear();
            Console.SetCursorPosition(10, 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Espero que sim!");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
