using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            var addressBook = new Dictionary<string, string>();
            addressBook.Add("рабочий", "ШАГ");
            addressBook.Add("домашний", "г. Воронеж");

            PrintDictionary(addressBook);
            Console.WriteLine();

            PrintSortDictionary(addressBook);
        }

        static void PrintDictionary(Dictionary<string, string> dictionary)
        {
            foreach (var element in dictionary)
            {
                Console.WriteLine($"{element.Key}: {element.Value}");
            }
        }
      
        static void PrintSortDictionary(Dictionary<string, string> dictionary)
        {
            var keys = dictionary.Keys.ToList();
            keys.Sort();

            foreach (var key in keys)
            {
                Console.WriteLine($"{key}: {dictionary[key]}");
            }
        }
    }
}