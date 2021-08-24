using System;
using System.Runtime.InteropServices;
namespace home_work_1
{
    class Program
    {
        [DllImport("msvcrt.dll")]
        static extern char _getch();
        static void Main()
        {
            Console.WriteLine($"Task 1!\nEnter the text: ");
                int wdcount=0;
                int chcount = 0;
                char text='a';
            do
            {
                text = _getch();
                if (text == ' ')
                    wdcount++;
                else
                    chcount++;
                Console.WriteLine($"{(int)text}\t{text}");
            } while (text != '.');
           
            Console.WriteLine($"Number of spaces is: {wdcount}");
            Console.WriteLine($"number of letter is: {chcount-1}");                  

            string word;
            Console.Write("Task 2!\nEnter a string in lower case: "); word = Console.ReadLine();            
            Console.WriteLine($"{word.ToUpper()}");
            string word_1;
            Console.Write("Enter a string in upper case: "); word_1 = Console.ReadLine();
            Console.WriteLine($"{word_1.ToLower()}");

            int a, b;
            Console.Write("Task 3!\nEnter the number: "); a = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter the number greater than '{a}': "); b = Convert.ToInt32(Console.ReadLine());
            third_homework(a, b);
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Task 4!\n");
            int M = 5, N = 6;
            int[] array_1 = new int[M];
            int[] array_2 = new int[N];
            int[] array_3 = new int[M + N];
            RandomArray(array_1);
            RandomArray(array_2);
            PrintArray(array_1);
            Console.WriteLine();
            PrintArray(array_2);
            Console.WriteLine();
            FullArray(array_1, array_2, array_3);
            PrintArray(array_3);
            Console.WriteLine("-----------------------------------------------------------");
            
                int number;
                string again;
                Console.Write("Task 5!\n");
            do
            {
                Console.Write("Enter the number: "); number=Convert.ToInt32(Console.ReadLine());
                int reverse_number = 0;
                int buffer = number;
                while (buffer > 0)
                {
                    reverse_number *= 10;
                    reverse_number += buffer % 10;
                    buffer /= 10;
                }
                if (number == reverse_number)
                {
                    Console.WriteLine("The number is a palindrome!!!!");
                }
                else
                {
                    Console.WriteLine("The number is not a palindrome!!!!");
                }
                Console.WriteLine($"Again????(Please answer 'yes' or 'no'): ");
                again = Console.ReadLine();
                if (again == "yes") continue;
                else if (again == "no") continue;
                else
                    Console.WriteLine("Your answer is not correct!!!!");break;
            } while (again != "no");

            Console.WriteLine("Task 6!\nEnter the text: ");
            string[] TextMassiv;
            string text_1; text_1 = Console.ReadLine();
            TextMassiv = text_1.Split(' ');
            Console.WriteLine($"Number of words in the text: {TextMassiv.Length}");

        }
        static void third_homework(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
        static void RandomArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 30);
            }
        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        static void FullArray(int[] array_1, int[] array_2, int[] array_3)
        {
            for(int i=0; i<array_1.Length; i++)
            {
                array_3[i] = array_1[i];
            }
            for(int i=0; i<array_2.Length; i++)
            {
                array_3[array_1.Length + i] = array_2[i];
            }
        }        
    }
}

/*
 
ДЗ 1. Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. 
Программа должна сосчитать количество введенных пользователем пробелов.
DONE 2. Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32.
Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует все символы нижнего регистра 
в символы верхнего регистра и наоборот.
done 3. Даны целые положительные числа A и B (A < B).
Вывести все целые числа от A до B включительно; каждое число должно выводиться на новой строке; 
при этом каждое число должно выводиться количество раз, равное его значению. Например: если А = 3, а В = 7,
то программа должна сформировать в консоли следующий вывод:
3 3 3
4 4 4 4
5 5 5 5 5
6 6 6 6 6 6
7 7 7 7 7 7 7
2:23
done 4.Даны 2 массива размерности M и N соответственно. Необходимо переписать
в третий массив общие элементы первых двух массивов без повторений.
done 5. Пользователь вводит строку. Проверить, является ли эта строка палиндромом. 
Палиндромом называется строка, которая одинаково читается слева направо и справа налево.
ДЗ 6. Подсчитать количество слов во введенном предложении. 

 */