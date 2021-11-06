using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlab12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("First constructor");

            Console.Write("\nEnter n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Class ob1 = new Class(n);

            ob1.ft_display_arr();
            Console.WriteLine();
            ob1.ft_multiply();
            Console.WriteLine($"Number of even elements is {ob1.Even}");

            Console.WriteLine("-----------------------------------------------------------");


            Console.WriteLine("\nSecond constructor");
            Console.WriteLine();

            Class ob2 = new Class("input.txt");
            ob2.ft_display_arr();
            ob2.ft_multiply();
            Console.WriteLine($"Number of even elements is {ob2.Even}");
            Console.ReadKey();
        }
    }
}
