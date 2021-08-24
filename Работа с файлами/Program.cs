using System;
using System.IO;

namespace Работа_с_файлами
{
    class Program
    {
        static void Main()
        {
            var path = "test.txt";
            StreamWriter file = new StreamWriter(path, append: true);
            file.WriteLine("Привет мир!");
            file.Close();

            StreamReader read_file = new StreamReader(path);
            var temp = read_file.ReadToEnd();
            read_file.Close();

            Console.WriteLine(temp);

            StreamReader reader = new StreamReader(path);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(line);
            }
            reader.Close();


        }
    }
}

