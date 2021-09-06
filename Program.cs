using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            double kelvin, fahrenheit;

            Console.WriteLine("Enter Celsius");
            double celsius = Convert.ToDouble(Console.ReadLine());
            kelvin = celsius + 273;

            Console.WriteLine($"{celsius} celsius = {kelvin} Kelvin");
            fahrenheit = (celsius * 18) / 10 + 32;

            Console.WriteLine($"{celsius} celsius = {fahrenheit} Fahrenheit");
        }
    }
}
