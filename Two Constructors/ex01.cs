using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOPlab12
{
    class Class
    {
        int n;
        int[] a;
        int even;

        public Class(int n) //First constructor that creates an array and fills it with a sequence of natural numbers up to n with a random sign
        {
            int rand;
            this.n = n;
            a = new int[n];
            Random r = new Random();

            for (int i = 0; i < n; i++)
                rand = r.Next(0, 2) == 1 ? a[i] = i : a[i] = -1 * i;
        }

        public void ft_display_arr() 
        {
            Console.WriteLine("Array: ");
            for (int i = 0; i < a.Length; i++)
                Console.Write($"{a[i]} ");
        }

        public Class(string pathIn) //Second constructor that creates an array and fills it with the values ​​read from the file
        {
            StreamReader input = new StreamReader(pathIn);
            string str = input.ReadToEnd();
            input.Close();

            str = str.Replace("\r\n", " ");
            string[] arr = str.Split(' ');

            n = arr.Length;
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = Convert.ToInt32(arr[i]);
        }

        public int Even //Read-only property for getting even elements of an array
        {
            get
            {
                for (int i = 0; i < n; i++)
                    if (a[i] % 2 == 0)
                        even++;
                return even;
            }
        }

        public void ft_multiply() //Product of elements located after the first multiple of 3 elements
        {
            int i = 1;
            int multiply = 1;
            while (a[i] % 3 != 0)
                i++;
            i++;
            while (i < n)
            {
                multiply *= a[i];
                i++;
            }
            Console.WriteLine($"\nMultiply result is {multiply}");        }
    }
}
