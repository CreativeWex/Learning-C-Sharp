﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMMLab5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.5, b = 2.5;
            int n = 5000;

            Message.First();
            Console.WriteLine($"          {Methods.LeftTriangleMethod(a, b, n, Methods.SourceFirst):0.000000};");
            Console.WriteLine($"         {Methods.RightTriangleMethod(a, b, n, Methods.SourceFirst):0.000000};");
            Console.WriteLine($"        {Methods.MiddleTriangleMethod(a, b, n, Methods.SourceFirst):0.000000};");
            Console.WriteLine($"            {Methods.SimpsonMethod(a, b, n, Methods.SourceFirst):0.000000};");
            Console.WriteLine($"                {Methods.TrapezeMethod(a, b, n, Methods.SourceFirst):0.000000};");

            Message.Second();
            Console.WriteLine($"          {Methods.LeftTriangleMethod(a, b, n, Methods.SourceSecond):0.000000};");
            Console.WriteLine($"         {Methods.RightTriangleMethod(a, b, n, Methods.SourceSecond):0.000000};");
            Console.WriteLine($"        {Methods.MiddleTriangleMethod(a, b, n, Methods.SourceSecond):0.000000};");
            Console.WriteLine($"            {Methods.SimpsonMethod(a, b, n, Methods.SourceSecond):0.000000};");
            Console.WriteLine($"                {Methods.TrapezeMethod(a, b, n, Methods.SourceSecond):0.000000};");

            Console.ReadKey();
        }
    }
}
