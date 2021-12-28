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
            int sumPositive = 0, sumN = 0, numberP = 1, numberN = -1;


            Console.WriteLine("Введите целое число");
            var number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                while (numberP != 0)
                {
                    Console.WriteLine("Введите целое число");
                    numberP = int.Parse(Console.ReadLine());
                    if (numberP > 0)
                        sumPositive += numberP;
                }
                Console.WriteLine(sumPositive + number);
            }

            else if (number < 0)
            {
                while (numberN != 0)
                {
                    Console.WriteLine("Введите целое число");
                    numberN = int.Parse(Console.ReadLine());
                    if (numberN < 0)
                        sumN += numberN;
                }
                Console.WriteLine(sumN + number);
            }


            Console.ReadKey();


        }
    }
}
