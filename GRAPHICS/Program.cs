using System;

namespace GRAPHICS
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 2)
            {
                int ReturnCursorLeft = Console.CursorLeft;
                int ReturnCursorTop = Console.CursorTop;
                ConsoleColor None = new ConsoleColor();
                None.Equals(16);
                if (args[0].StartsWith("0"))
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else if (args[0].StartsWith("1"))
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                else if (args[0].StartsWith("2"))
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }
                else if (args[0].StartsWith("3"))
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                }
                else if (args[0].StartsWith("4"))
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }
                else if (args[0].StartsWith("5"))
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                }
                else if (args[0].StartsWith("6"))
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                }
                else if (args[0].StartsWith("7"))
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                }
                else if (args[0].StartsWith("8"))
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                else if (args[0].StartsWith("9"))
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else if (args[0].StartsWith("a"))
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                else if (args[0].StartsWith("b"))
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }
                else if (args[0].StartsWith("c"))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else if (args[0].StartsWith("d"))
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                }
                else if (args[0].StartsWith("e"))
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }
                else if (args[0].StartsWith("f"))
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = None;
                }
                if (args[0].EndsWith("0"))
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else if (args[0].EndsWith("1"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                else if (args[0].EndsWith("2"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                else if (args[0].EndsWith("3"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
                else if (args[0].EndsWith("4"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else if (args[0].EndsWith("5"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
                else if (args[0].EndsWith("6"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else if (args[0].EndsWith("7"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                else if (args[0].EndsWith("8"))
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (args[0].EndsWith("9"))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (args[0].EndsWith("a"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (args[0].EndsWith("b"))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (args[0].EndsWith("c"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (args[0].EndsWith("d"))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (args[0].EndsWith("e"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (args[0].EndsWith("f"))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = None;
                }
                Console.CursorLeft = int.Parse(args[1]);
                Console.CursorTop = int.Parse(args[2]);
                if (args.Length > 3)
                {
                    Console.Write(args[3].Substring(0, 1));
                }
                else
                {
                    Console.Write(" ");
                }
                Console.ResetColor();
                Console.CursorLeft = ReturnCursorLeft;
                Console.CursorTop = ReturnCursorTop;
            }
            else
            {
                Console.WriteLine("Drawing utility for command prompt\n\ngraphics 0f x y char");
            }
        }
    }
}
