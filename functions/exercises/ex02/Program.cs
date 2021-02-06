using System;
using static System.Console;

namespace ex02
{
    class Program
    {
        private static class Config
        {
            public static readonly int TriangleLines = 8;
            public static readonly int TriangleStep = 3;
            public static readonly int TriangleTab = 2;
            public static readonly int RombLines = 15;
            public static readonly int RombStep = 2;
            public static readonly int RombTab = 1;
            public static readonly int PythagorWidth = 10;
            public static readonly int PythagorHeight = 8;
        };
        static void Main(string[] args)
        {
            WriteLine();
            DrawTriangle();
            WriteLine();
            DrawRomb();
            WriteLine();
            DrawPythagoras();
        }

        private static void DrawTriangle()
        {
            for (var i = 0; i < Config.TriangleLines; i++)
            {
                WriteStarLine(Config.TriangleTab, i * Config.TriangleStep + 1);
            }
        }

        private static void DrawRomb()
        {
            int middlePoint = Config.RombLines / 2 + 1;
            for (var i = 0; i < middlePoint; i++)
            {
                WriteStarLine((middlePoint - i) * Config.RombStep + Config.RombTab, i * Config.RombStep * 2 + 1);
            }
            for (var i = middlePoint; i >= 0; i--)
            {
                WriteStarLine((middlePoint - i) * Config.RombStep + Config.RombTab, i * Config.RombStep * 2 + 1);
            }
        }

        private static void DrawPythagoras() {
            var maxNumberLength = NumberLength(Config.PythagorHeight * Config.PythagorWidth);
            var maxHeightNumberLength = NumberLength(Config.PythagorHeight);
            WriteLineForNumber(0, maxHeightNumberLength, maxNumberLength);
            WriteDashedLine(maxHeightNumberLength, maxNumberLength);
            for(var i = 1; i <= Config.PythagorHeight; i++)
            {
                WriteLineForNumber(i, maxHeightNumberLength, maxNumberLength);
            }
        }

        private static void WriteLineForNumber(int number, int headerLength, int columnLength)
        {
            if (number > 0)
                WriteWithSpaces(number, headerLength);
            if (number == 0)
                Write(new String(' ', headerLength));
            Write(" |");
            for (var i = 1; i <= Config.PythagorWidth; i++)
            {
                var num = i;
                if (number > 0)
                    num = i * number;
                Write(" ");
                WriteWithSpaces(num, columnLength);
            }
            WriteLine();
        }

        private static void WriteDashedLine(int headerLength, int columnLength)
        {
            Write(new string('-', headerLength));
            Write("-+");
            Write(new string('-', Config.PythagorWidth * (1 + columnLength)));
            WriteLine();
        }

        private static void WriteWithSpaces(int number, int length) {
            var numberLength = NumberLength(number);
            var spaces = 0;
            if (length > numberLength)
                spaces = length - numberLength;
            Write(new string(' ', spaces) + number.ToString());
        }

        private static int NumberLength(int value)
        {
            int length = 0;
            while (value > 0)
            {
                length++;
                value = value / 10;
            }
            return length;
        }

        private static void WriteStarLine(int startIndex, int Length)
        {
            WriteLine(new String(' ', startIndex) + new string('*', Length));
        }
    }
}
