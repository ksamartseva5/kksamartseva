using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите целое число");
            var a = int.Parse(Console.ReadLine());

            int sum = a;
            int multiply = a;

            if (a > 0)
            {
                while (a != 0)
                {
                    Console.WriteLine("Введите целое число");
                    a = int.Parse(Console.ReadLine());
                    sum += a;
                }
                Console.WriteLine(sum);
            }
            else
            {
                while (a != 0)
                {
                    Console.WriteLine("Введите целое число");
                    a = int.Parse(Console.ReadLine());
                    multiply *= a;

                }
                Console.WriteLine(multiply);
            }

            Console.ReadKey();

            
        }
    }
}
