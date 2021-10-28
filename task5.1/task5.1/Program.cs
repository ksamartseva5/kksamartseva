using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово на русском языке");
            var text = Console.ReadLine();
            text = text.ToUpperInvariant();
            Console.WriteLine($"Транслитерация слова:" + Translireratciya(text));
            Console.ReadKey();
        }
        static string Translireratciya(string text)
        {
            text = text.Replace("А", "A");
            text = text.Replace("Б", "B");
            text = text.Replace("В", "V");
            text = text.Replace("Г", "G");
            text = text.Replace("Д", "D");
            text = text.Replace("Е", "E");
            text = text.Replace("Ё", "E");
            text = text.Replace("Ж", "ZH");
            text = text.Replace("З", "Z");
            text = text.Replace("И", "I");
            text = text.Replace("Й", "I");
            text = text.Replace("К", "K");
            text = text.Replace("Л", "L");
            text = text.Replace("М", "M");
            text = text.Replace("Н", "N");
            text = text.Replace("О", "O");
            text = text.Replace("П", "P");
            text = text.Replace("Р", "R");
            text = text.Replace("С", "S");
            text = text.Replace("Т", "T");
            text = text.Replace("У", "U");
            text = text.Replace("Ф", "F");
            text = text.Replace("Х", "KH");
            text = text.Replace("Ц", "TS");
            text = text.Replace("Ч", "CH");
            text = text.Replace("Ш", "SH");
            text = text.Replace("Щ", "SHCH");
            text = text.Replace("Ъ", "IE");
            text = text.Replace("Ы", "Y");
            text = text.Replace("Ь", "");
            text = text.Replace("Э", "E");
            text = text.Replace("Ю", "IU");
            text = text.Replace("Я", "IA");
            return text;
        }
    }
}
