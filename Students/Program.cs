using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab13Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildList ob = new BuildList();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("         Source array");
            Console.ResetColor();
            ob.Print();

            Console.WriteLine();
            ob.Sort();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("         Sorted array");
            Console.ResetColor();
            ob.Print();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n       Students with Avg mark higher than 4");
            Console.ResetColor();
            ob.ShowAverage();

            Console.ReadKey();

        }
    }
}
