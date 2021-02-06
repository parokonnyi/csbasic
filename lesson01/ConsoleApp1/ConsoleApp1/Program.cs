using System;

namespace Library.Shared
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int some;
              some = 7;
              //    Write(some);
              //    some = 5;
              //    WriteLine(some);
              //WriteLine(7 % 2);
            */
            //Console.Write("What is your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Welcome " + name);           

            Console.Write("Number 1: ");
            var num1 = Console.ReadLine();
            var number1 = int.Parse(num1);
            Console.Write("Number 2: ");
            var num2 = Console.ReadLine();
            var number2 = int.Parse(num2);
            Console.WriteLine("{0} + {1} = {2}", number1, number2,  number1 + number2);
        }
    }
}
