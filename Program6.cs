using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignments
{
    class Program6
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter numbers");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());
            SortThreeNumbers(n1, n2, n3);

        }
        public static void SortThreeNumbers(int a, int b, int c)
        {
            int x = 0, y = 0, z = 0;
            if (a > b)
            {
                y = a;
                z = b;

            }
            else
            {
                y = b;
                z = a;

            }
            if (y > c)
            {
                x = y;
                if (z > c)
                {
                    y = z;
                    z = c;

                }
                else
                {
                    y = c;

                }

            }
            else
            {
                x = c;

            }
            Console.WriteLine(" " + x + " " + y + " " + z);
            Console.Read();


        }

    }
}
