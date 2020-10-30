using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 548.65;

            double num2 = 548.65;

            double num3 = 4.5;

            double num4 = 3.4;


            Console.WriteLine($"Floor value of {num1} is {Math.Floor(num1)}");
            Console.WriteLine($"ceilvalue of {num1} is {Math.Ceiling(num1)}");
            Console.WriteLine($"Round {num1} is {Math.Round(num1)}");
            Console.WriteLine($"BEFORE Truncate {num1} after Truncate {Math.Truncate(num1)}");
            Console.WriteLine($"minimun number of {num3} and {num4} is {Math.Min(num3,num4)}");
            Console.WriteLine($"PI{Math.PI}");

        }
    }
}
