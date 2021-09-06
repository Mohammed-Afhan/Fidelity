using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignments
{
    class Program5
    {
        static bool isPrimeNumber(int num)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;

                }
            }
            if (count == 2)
            {
                return true;
            }
            else
                return false;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the Count ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter the Number");
                int num = Convert.ToInt32(Console.ReadLine());
                if (isPrimeNumber(num))
                {
                    Console.WriteLine("Prime Number");
                }
                else if ((isPrimeNumber(num)) == false)
                {
                    Console.WriteLine("Not a Prime Number");
                }

            }
            Console.ReadLine();
        }
    }
}
