using System;
using static System.Console;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            char key = 'c';
            string num1Str;
            string num2Str;
            float num1;
            float num2;

            while (key == 'c')
            {
                Write("Please enter Operation: ");
                char op = ReadKey().KeyChar;
                WriteLine();
                Write("Please enter num1 value: ");
                num1Str = ReadLine();
                Write("Please enter num2 value: ");
                num2Str = ReadLine();
                if (Single.TryParse(num1Str, out num1) && Single.TryParse(num2Str, out num2))
                {
                    try
                    {
                        checked
                        {
                            var res = Calculate(num1, num2, op);
                            if (!res.HasValue)
                            {
                                WriteLine("Calculation failed. Unknown oprator: {0}.", arg0: op);
                            }
                            else
                            {
                                WriteLine("The result is: {0}.", arg0: res.ToString());
                            }
                        }
                    }
                    catch (StackOverflowException)
                    {
                        WriteLine("Calculation failed. The numbers are too big.");
                    }
                    catch (DivideByZeroException)
                    {
                        WriteLine("Calculation faild. Unable to divide by zero.");
                    }
                }
                else
                {
                    WriteLine("Unable to calculate non numeric values.");
                }

                Write("To continue press 'c' or any other key to exit: ");
                key = ReadKey().KeyChar;
                WriteLine();
            }
        }

        private static float? Calculate(float a, float b, char _operator)
        {
            switch (_operator)
            {
                case '+':
                    return Sum(a, b);
                case '-':
                    return Sub(a, b);
                case '*':
                    return Mult(a, b);
                case '/':
                    return Div(a, b);
                default:
                    return null;
            }
        }

        private static float Sum(float a, float b)
        {
            return a + b;
        }

        private static float Sub(float a, float b)
        {
            return a - b;
        }

        private static float Mult(float a, float b)
        {
            return a * b;
        }

        private static float Div(float a, float b)
        {
            return a / b;
        }
    }
}
