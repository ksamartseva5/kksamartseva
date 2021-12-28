using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            var number = int.Parse(Console.ReadLine());

            var divider = 1;

            for (var i = 2; i < number; i++)
                if (number % i == 0)
                {
                    divider = i;
                    break;
                }
            var maxdivider = number / divider;

            if (maxdivider == number)
                Console.WriteLine("так как это простое число, макс. делителя нет.");
            else
            Console.WriteLine($"Максимальный делитель {maxdivider}");
            Console.ReadKey();
                   

                
               
        }
    }
}
