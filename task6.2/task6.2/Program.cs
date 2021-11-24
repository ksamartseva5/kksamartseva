using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = WriteCoordinate("абсциссу");
            var y = WriteCoordinate("орднату");

            Console.WriteLine($"Точка внутри области " + BelongsToArea(x,y));

            Console.ReadKey();
        }

        static double WriteCoordinate(string name)
        {
            Console.WriteLine($"Введите {name} точки");
            return double.Parse(Console.ReadLine());
        }

        static bool BelongsToArea(double x, double y)
        {
            return x >= -1 && x <= 1.5 && y >= -0.5 && y <= 2;
        }
    }
}
