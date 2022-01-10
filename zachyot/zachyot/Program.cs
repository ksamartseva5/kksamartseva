using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachyot
{
    class Program
    {
        static void Main(string[] args)
        {
          for (var number=10; number<=250000000;number++)
                for(var i=2; i<=number; i++)
                {
                    if (Math.Pow(Sum(number), i) > number)
                        break;
                    else if(Math.Pow(Sum(number),i)==number)
                        Console.WriteLine($"{number}={Sum(number)}^{i}");
                }

            Console.ReadKey();
        }
        static int Sum(int number)
        {
            int summma = 0;
            while (number > 0)
            {
                summma += number % 10;
                number /= 10;
            }
            return summma;
        }
    }

}
