using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMMLab5
{
    class Methods
    {
        public static double SourceFirst(double x)
        {
            return (x * x * Math.Tan(x / 2));
        }
        public static double SourceSecond(double x)
        {
            return (Math.Exp(-x * x));
        }
        public static double LeftTriangleMethod(double a, double b, int iterationsNumber, Func<double, double> Calculate)
        {
            double functionResult = 0;
            double h = (b - a) / iterationsNumber;
            double x = a;

            Message.LeftTriangleMessage();

            for (int i = 0; i < iterationsNumber; i++)
            {
                functionResult += Calculate(x);
                x += h;
            }
            return functionResult * h;
        }
        public static double RightTriangleMethod(double a, double b, int iterationsNumber, Func<double, double> Calculate)
        {
            double functionResult = 0;
            double h = (b - a) / iterationsNumber;
            double x = a + h;

            Message.RightTriangleMessage();

            for (int i = 0; i <= iterationsNumber; i++)
            {
                functionResult += Calculate(x);
                x += h;
            }
            return functionResult * h;
        }
        public static double MiddleTriangleMethod(double a, double b, int iterationsNumber, Func<double, double> Calculate)
        {
            double functionResult = 0;
            double h = (b - a) / iterationsNumber;
            double x = a;

            Message.MiddleTriangleMessage();

            for (int i = 0; i < iterationsNumber; i++)
            {
                functionResult += Calculate(x + h / 2);
                x += h;
            }
            return functionResult * h;
        }
        public static double SimpsonMethod(double a, double b, int iterationsNumber, Func<double, double> Calculate)
        {
            double firstResult = 0, secondResult = 0, thirdResult = 0;
            double h = (b - a) / (2 * iterationsNumber);
            firstResult = (Calculate(a) + Calculate(a + h * iterationsNumber));
            double x = a + 2 * h;

            Message.SimpsonleMessage();

            iterationsNumber *= 2;
            for (int i = 2; i <= iterationsNumber - 2; i += 2)
            {
                secondResult += Calculate(x);
                x += 2 * h;
            }

            secondResult *= 2;
            x = a + h;
            for (int i = 1; i <= iterationsNumber - 1; i += 2)
            {
                thirdResult += Calculate(x);
                x += 2 * h;
            }
            thirdResult *= 4;
            return (firstResult + secondResult + thirdResult) * h / 3;
        }
        public static double TrapezeMethod(double a, double b, int iterationsNumber, Func<double, double> Calculate)
        {
            double functionResult = 0;
            double h = (b - a) / iterationsNumber;
            double x = a + h;

            Message.TrapezeMessage();

            functionResult = (Calculate(a) + Calculate(a + h * iterationsNumber)) / 2;
            for (int i = 0; i < iterationsNumber - 1; i++)
            {
                functionResult += Calculate(x + h / 2);
                x += h;
            }
            return functionResult * h;
        }
    }
}
