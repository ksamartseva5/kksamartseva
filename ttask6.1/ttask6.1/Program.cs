using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttask6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = Input("m");
            var n = Input("n");
            var k = Input("k");

            Console.WriteLine(EvenAndInequality(m,n,k));
            Console.ReadKey();
        }
        static int Input(string name)
        {
            Console.WriteLine($"Введите целое число {name}");
            return int.Parse(Console.ReadLine());
        }
        static bool IsEven(int m, int n, int k)
        {
            return (k % 2 == 0) && (m % 2 == 0) && (n % 2 == 0);
        }
        static bool Inequality (int m, int n, int k)
        {
            return (k <= m) && (m <= n) && (k <= n);
        }
        static bool EvenAndInequality(int m, int n, int k)
        {
            var a = IsEven(m, n, k);
            var b = Inequality(m, n, k);
            return a && b;
        }

    }


}
