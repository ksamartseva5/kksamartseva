using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольное число x");
            var x = double.Parse(Console.ReadLine());
           var angle = x * Math.PI / 180;
            Console.WriteLine($"y="+ GetResult(angle, x));
            Console.ReadKey();
        }
        static double GetResult (double x, double angle)
        {
            return Math.Sqrt((1 + Math.Cos(angle))/(1+x*x));
        }
    }
}
