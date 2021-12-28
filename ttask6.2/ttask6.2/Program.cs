using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttask6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var x = InputCoordinate("абсциссу");
                var y = InputCoordinate("ординату");

                Console.WriteLine($"Точка внутри области " + IsInsideArea(x, y));

                Console.ReadKey();
            }

             bool IsInsideArea(double x, double y)
            {
                return y>=-0.5 && y<=2 && x>=-1 && x<=1.5;
            }

          double InputCoordinate(string name)
            {
                Console.WriteLine($"Введите {name} точки");
                return double.Parse(Console.ReadLine());
            }

        }
    }
}
