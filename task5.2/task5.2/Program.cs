using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "икосаэдр";
            string result = text.Substring(1, 1)
                + text.Substring(4, 1)
                + text.Substring(6, 2);
            string secondword = text.Substring(1, 1)
                + text.Substring(4, 1)
                + text.Substring(7, 1)
                + text.Substring(4, 1)
                + text.Substring(3, 1)
                + text.Substring(0, 2);
            Console.WriteLine(result);
            Console.WriteLine(secondword);
            Console.ReadKey();


        }
    }
}
