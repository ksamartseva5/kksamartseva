using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            var number = int.Parse(Console.ReadLine());

            int sumEven = 0, sumOdd = 0;

            while (number != 0)
            {
                if (number % 2 == 0)
                {
                    sumEven += (number % 10);
                    number /= 10;
                }

                else
                {
                    sumOdd += (number % 10);
                    number /= 10;
                }
            }

            Console.WriteLine($"Сумма четных цифр равна {sumEven} , сумма нечетных - {sumOdd}");

            Console.ReadKey();
        
        }
    }
}
