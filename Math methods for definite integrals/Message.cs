using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMMLab5
{
    class Message
    {
        public static void LeftRectangleMessage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Left Rectangle method: ");
            Console.ResetColor();
        }

        public static void RightRectangleMessage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Right Rectangle method: ");
            Console.ResetColor();
        }
        public static void MiddleRectangleMessage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Middle Rectangle method: ");
            Console.ResetColor();
        }
        public static void SimpsonleMessage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("the Simpson method: ");
            Console.ResetColor();
        }
        public static void TrapezeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Trapeze method: ");
            Console.ResetColor();
        }
        public static void First(double a, double b)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nFirst integral: ");
            Console.ResetColor();
            Console.WriteLine($"y = x^2 tan( x / 2 );   [{a}; {b}]");
            Console.WriteLine("\n-----------------Results-----------------\n");
        }
        public static void Second(double a, double b)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nSecond integral: ");
            Console.ResetColor();
            Console.WriteLine($"y = exp( -x^2 );   [{a}; {b}]");
            Console.WriteLine("\n-----------------Results-----------------\n");
        }
    }
}
