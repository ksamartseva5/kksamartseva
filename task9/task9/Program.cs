using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите количество элементов массива");
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];
            for (int i = 0; i < number; i++)
                array[i] = int.Parse(Console.ReadLine());
            PrintIntArray(array);
            Multiply(array);
            Average(array);
            Console.ReadKey();
        }

        static void PrintIntArray(int[] array)
        {
            foreach (var elem in array)
                Console.Write($"{elem} ");
            Console.WriteLine();
        }
        static void Multiply(int[] array)
        {
            Console.WriteLine("Введите значение k");
            var k = int.Parse(Console.ReadLine());
            for (var i = 0; i < array.Length; i++)
                array[i] *= k;
            PrintIntArray(array);
        }
        static void Average(int [] array)
        {
            int sum = 0;
            double srednee=0;
            for (var i = 0; i < array.Length; i++)
                sum+= array[i];
            srednee = sum / array.Length;
            Console.WriteLine($"Среднее значение массива равно {srednee, 0:F3}");
        }
    }
}
