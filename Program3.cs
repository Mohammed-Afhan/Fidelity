using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignments
{
    class Program3
    {
        static void Main(string[] args)
        {
            int i, num, sumNeg = 0, sumPos = 0, countPos = 0, countNeg = 0;
            double avgPos = 0, avgNeg = 0;
            Console.WriteLine("Enter the 10 real Numbrrs");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("Number - {0}:", i);
                num = Convert.ToInt32(Console.ReadLine());

                if (num > 0)
                {
                    sumPos += num;
                    countPos = countPos + 1;
                }
                else
                {
                    sumNeg += num;
                    countNeg = countNeg + 1;
                }


            }
           
            avgPos = sumPos / countPos;
            Console.Write("The Avg of the Positive Number is:{0}\n", avgPos);

            avgNeg = sumNeg / countNeg;
            Console.Write("The Avg of the Negative Number is:{0}\n", avgNeg);
            Console.Read();
        }
    }
}
