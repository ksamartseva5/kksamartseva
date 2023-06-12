using System;
using System.Collections.Generic;
using ClassLibrary1;

static Dictionary<string, int> CounterOfWordsInText(string[] text)
{
    return text.SelectMany(line => line.Split(new char[] { ' ', ',', '.', '-', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries)) 
               .Select(word => word.ToLower()) 
               .GroupBy(word => word) 
               .ToDictionary(g => g.Key, g => g.Count()) 
               .OrderBy(kv => kv.Key) 
               .ToDictionary(kv => kv.Key, kv => kv.Value); 
}
string[] text = { "Федор, Федор: Максим, Игорь, Саша - Денис. Инна" };
Console.WriteLine(string.Join("\n", CounterOfWordsInText(text).Select(pair => $"{pair.Key}: {pair.Value}")));

static void CounterTotalVisitTimeInYear(List<Record> records)
{
    var results = records.GroupBy(r => r.Year) 
                         .Select(g => new { Year = g.Key, TotalDuration = g.Sum(r => r.Duration) }) 
                         .OrderBy(r => r.Year);

    foreach (var result in results)
    {
        Console.WriteLine($"Общая продолжительность занятий для {result.Year} года: {result.TotalDuration}.");
    }
}

Record test1 = new Record(1, 2020, 1, 60);
Record test2 = new Record(1, 2020, 1, 60);
Record test3 = new Record(1, 2019, 1, 130);
Record test4 = new Record(1, 2022, 1, 60);
Record test5 = new Record(1, 2022, 1, 60);

var listTest = new List<Record>() { test1, test2, test3, test4, test5 };

CounterTotalVisitTimeInYear(listTest);