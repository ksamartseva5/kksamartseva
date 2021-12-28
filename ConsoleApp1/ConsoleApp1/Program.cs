using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое целое положительное число");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе целое число, большее или равное первому");
            var b = int.Parse(Console.ReadLine());

            int multiply = 1;

            for (var i = a; i <= b; i++)
                multiply *= i;

            Console.WriteLine($"Результат:{multiply}");
            Console.ReadKey();
        }
    }
}
