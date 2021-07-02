using System;

           
namespace Own_practic
{
    class Program
    {
        static void Main(string[] args)
        {
            //var c = 20;
            //var name = "Shahzod";
            //var a = 12.5;
            //Console.WriteLine($"{c}");
            ////Console.WriteLine(c.GetType().ToString());
            //Console.WriteLine(name.GetType().ToString());
            //Console.WriteLine(a.GetType().ToString());
            //object c = 12;
            //object name =" kudratov";
            //object q = 12.23;
            //object ar = 'c';
            //Console.WriteLine($"{c}\t{name}\t{q}\t{ar}");
            while(true)
            {
                  Console.Write("Enter the letter: ");
                  string selection = Console.ReadLine();
            switch(selection)
            {
                case "Y" :  Console.WriteLine("You entered Y !!!!!!!");
                    break;
                case "H": Console.WriteLine("You entered H !!!!!!!!!!!!!!!");
                   break;
                case "S": Console.WriteLine("You entered S !!!!!!!!!!!!!!!!!");
                    break;
                case "X": Console.WriteLine("You entered X !!!!!!!!!");
                    break;
                default:
                    Console.WriteLine("Your letter is not correct !!!!!!!!!!");
                    break;
            }
            }
            
        }
    }
}
