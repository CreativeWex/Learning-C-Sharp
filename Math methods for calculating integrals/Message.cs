using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMMLab5
{
    class Message
    {
        public static void LeftTriangleMessage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Left Triangle method: ");
            Console.ResetColor();
        }

        public static void RightTriangleMessage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Right Triangle method: ");
            Console.ResetColor();
        }
        public static void MiddleTriangleMessage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Middle Triangle method: ");
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
        public static void First()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nFirst integral: ");
            Console.ResetColor();
            Console.WriteLine("y = x^2 tan( x / 2 );");
            Console.WriteLine("\n-----------------Results-----------------\n");
        }
        public static void Second()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nSecond integral: ");
            Console.ResetColor();
            Console.WriteLine("y = exp( -x^2 );");
            Console.WriteLine("\n-----------------Results-----------------\n");
        }
    }
}
