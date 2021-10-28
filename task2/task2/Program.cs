using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Введите длину меньшего основания трапеции");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину большего основания трапеции");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите угол при основании");
            var angle = double.Parse(Console.ReadLine());
            angle = angle* Math.PI / 180;
            var S = ((b * b - a * a) / 2) * (Math.Pow(Math.Sin(angle), 2) / Math.Sin(2 * angle));
            var P = a + b + Math.Cos(angle) * (b - a);
            Console.WriteLine($"Площадь трапеции = "+S);
            Console.WriteLine($"Периметр трапеции = " + P);
            Console.ReadKey();
        }
    }
}
