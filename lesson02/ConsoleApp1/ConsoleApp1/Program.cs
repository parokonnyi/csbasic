using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int value = 2342342;
            //int length = 0;
            //while (value >= 1)
            //{
            //    length++;
            //    value = value / 10;
            //}
            //Console.WriteLine(length);
            //Console.ReadLine();

            int x = 5;
            int y = 10;
            int z = 22;
            int b = 15;
            int c = 26;
            int max = x;
            if (y > max)
                max = y;
            if (z > max)
                max = z;
            if (b > max)
                max = b;
            if (c > max)
                max = c;


            if (x > y)
            {
                Console.WriteLine("Max value {0}", x);
            }
            else if (z > y)
            {
                Console.WriteLine("Max value {0}", z);
            }
            else {
                Console.WriteLine("Max value {0}", y);
            }

            Console.WriteLine("Max value {0}", max);

        }
    }
}
