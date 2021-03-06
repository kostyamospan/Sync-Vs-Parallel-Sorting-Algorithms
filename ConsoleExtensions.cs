using System;

namespace SortTest
{
    public static class ConsoleExtensions
    {
        public static void WriteLine(this ConsoleColor color, string text)
        {
            Write(color, text + "\n");
        }
        
        public static void Write(this ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.Write(text);  
            Console.ResetColor();
        }
    }
}