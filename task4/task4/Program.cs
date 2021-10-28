using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double k = GetResult();
            Console.WriteLine("GetResult= {0:F3}", k);
            Console.ReadKey();

        }
        static double GetResult()
        {
            return Calculate(2, 2) + Calculate(5, 3) + Calculate(11, 5);
        }
        static double Calculate (double x, double y)
        {
            return Math.Sqrt((1 + Math.Sqrt(x)) / y);
        } 
    }
}
