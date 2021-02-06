using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 10;

            for (int w = 0; w <= length; w++)
            {
                Console.Write("{0,7}", w);
            }
            Console.WriteLine();

            for (int x = 1; x <= length; x++)
            {
                Console.Write("{0,7}", x);
                for (int y = 1; y <= length; y++)
                {
                    //Console.Write("{0,7} ",Math.Round(Math.Sqrt(x*x + y*y), 2, MidpointRounding.AwayFromZero));
                    Console.Write("{0,7} ", x*y);
                }
                Console.WriteLine();
            }
        }
    }
}
