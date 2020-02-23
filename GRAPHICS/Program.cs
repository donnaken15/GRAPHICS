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
                if (args[0].Length > 0)
                    Console.BackgroundColor = (ConsoleColor)Convert.ToByte(args[0][0].ToString(), 16);
                if (args[0].Length > 1)
                    Console.ForegroundColor = (ConsoleColor)Convert.ToByte(args[0][0].ToString(), 16);
                else
                    Console.ForegroundColor = None;
                Console.CursorLeft = int.Parse(args[1]);
                Console.CursorTop = int.Parse(args[2]);
                if (args.Length > 3)
                    Console.Write(args[3].Substring(0, 1));
                else
                    Console.Write(" ");
                Console.ResetColor();
                Console.CursorLeft = ReturnCursorLeft;
                Console.CursorTop = ReturnCursorTop;
            }
            else
                Console.WriteLine("Drawing utility for command prompt\n\ngraphics 0f x y char");
        }
    }
}
