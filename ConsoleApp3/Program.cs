using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 	вычисления значения функции y=7x^2-3x+4  при любом значении x;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Введите число х, чтобы вычислить значение функции y=7x^2-3x+4:");
            string textAsNum = Console.ReadLine();
            x = int.Parse(textAsNum);
            y = 7 * x * x - 3 * x + 4;
            Console.Write("y=");
            Console.Write(y);
            Console.ReadKey();
        }
    }
}
