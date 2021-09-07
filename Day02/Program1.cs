using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignments.Day02

{
    

    class Prime
    {

        static bool checkPrime(int numberToCheck)
        {
            if (numberToCheck == 1)
            {
                return false;
            }
            for (int i = 2;
                     i * i <= numberToCheck; i++)
            {
                if (numberToCheck % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static int primeSum(int from, int to)
        {
            int sum = 0;
            for (int i = to; i >= from; i--)
            {

                // Check for prime
                bool isPrime = checkPrime(i);
                if (isPrime)
                {

                    // Sum the prime number
                    sum = sum + i;
                }
            }
            return sum;
        }



        class Program1
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter From value");
                int from = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter To value");
                int to = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(primeSum(from,to));
                Console.ReadLine();
            }
        }
    }
}