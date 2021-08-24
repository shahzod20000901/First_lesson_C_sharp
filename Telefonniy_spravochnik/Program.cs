using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Telefonniy_spravochnik
{
    class Program
    {
        static void Main()
        {
            var path = "test.txt";
            StreamWriter file = new StreamWriter(path, append: false);
            file.WriteLine("Hello:World!!!");
            file.WriteLine("Junior:Middle!!!");
            file.Close();

            var flag = false;
            var PhoneBook = new Dictionary<string, string>();
            var PhoneBook_1 = ExportFromFile();
            Show(PhoneBook_1);
            do
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Edit");
                Console.WriteLine("3. Find");
                Console.WriteLine("4. Show all");
                Console.WriteLine("5. delete");
                Console.WriteLine("6. Save");
                Console.WriteLine("0. exit");
                var select = Console.ReadLine();
                switch (select)
                {
                    case "1":
                        Add(PhoneBook);
                        break;
                    case "2":
                        edit(PhoneBook);
                        break;
                    case "3":
                        find(PhoneBook);
                        break;
                    case "4":
                        Show(PhoneBook);
                        break;
                    case "5":
                        delete(PhoneBook);
                        break;
                    case "6":
                        ImportToFile(PhoneBook);
                        Console.WriteLine("Saved!!!");
                        break;
                    case "0":
                        ImportToFile(PhoneBook);
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Something went wrong!!!!");
                        break;
                }
            } while (!flag);

            
        }

        static void Add(Dictionary<string, string>dictionary)
        {
            Console.Write("Enter the name: ");
            var name = Console.ReadLine();
            Console.Write("Enter the phone number: ");
            var number = Console.ReadLine();
            dictionary.Add(name, number);
        }

        

        static void edit(Dictionary<string, string> dictionary)
        {
            var flag = false;
            Console.Write("Enter the name: ");
            var name = Console.ReadLine();
            
            foreach(var element in dictionary)
            {
                if(element.Key==name)
                {                    
                    dictionary.Remove(element.Value);                    
                }
                flag = true;
                if (flag)
                {
                    Console.WriteLine("Enter the new phone number: ");
                    var phone_number = Console.ReadLine();
                    dictionary.Add(element.Key, phone_number);
                }
            }
            if(!flag)
            {
                Console.WriteLine("Nothing not found!!!");
            }
        }

        static void Show(Dictionary<string, string> dictionary)
        {
            foreach(var element in dictionary)
            {
                Console.WriteLine($"{element.Key}:\t{element.Value}");
            }
        }

        static void find(Dictionary<string, string> dictionary)
        {
            var flag = false;
            Console.Write("Enter the name: ");
            var name = Console.ReadLine();
            foreach(var element in dictionary)
            {
                if (element.Key == name)
                {
                    Console.WriteLine($"{element.Key}:\t{element.Value}");
                }
                flag = true;
            }
            if(!flag)
            {
                Console.WriteLine("Nothing not found!!!");
            }
        }

        static void delete(Dictionary<string, string> dictionary)
        {
            var flag = false;
            Console.Write("Enter the name: ");
            var name = Console.ReadLine();
            foreach (var element in dictionary)
            {
                if (element.Key == name)
                {
                    Console.WriteLine($"{element.Key}:\t{element.Value} been deleted!!!");
                    dictionary.Remove(element.Key);
                    dictionary.Remove(element.Value);
                }
                flag = true;
            }
            if (!flag)
            {
                Console.WriteLine("Nothing not found!!!");
            }

        }

        static void ImportToFile(Dictionary<string, string> dictionary)
        {
            var file = new StreamWriter("test.txt", true);
            foreach (var element in dictionary)
            {
                file.WriteLine($"{element.Key}|{element.Value}");
            }
            // file.Flush();
            file.Close();
        }

        static Dictionary<string, string> ExportFromFile()
        {
            var file = new StreamReader("test.txt");
            var dict = new Dictionary<string, string>();

            var str = string.Empty;
            while ((str = file.ReadLine()) != null)
            {
                var temp = SplitStr(str, ':');
                dict.Add(temp.key, temp.value);
            }
            file.Close();

            return dict;
        }

        static (string key, string value) SplitStr(string str, char delimiter)
        {
            var temp = str.Split(delimiter);
            var key = temp[0];
            var value = temp[1];

            return (key, value);
        }

    }
}

/*
 Задание.
Доработать программу "Телефонный справочник" следующим образом:
добавить сохранение данных в файл перед закрытием
добавить импорт данных из файла при старте программы
реализовать ручной выбор сохранения данных в файл с вводом имени файла

*/