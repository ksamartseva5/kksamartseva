using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttask7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите значение x: ");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine($"Значение функции " + Function(x));

            Console.ReadKey();
        }

        static double Function(double x)
        {
            if (x < -1)
                return Math.Atan(x);
            if (x > 1)
                return Math.Asin(1 / x);
            else
                return Math.Acos(x);
        }
    }
}
