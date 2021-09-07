using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignments.Day02
{
    class Pattern
    {

     
        static void printn(int num)
        {
          
            if (num == 0)
                return;
            Console.Write("* ");

            printn(num - 1);
        }

        
        static void pattern(int num, int i)
        {
          
            if (num == 0)
                return;
            printn(i);
            Console.WriteLine();

         
            pattern(num - 1, i + 1);
        }

      
        static public void Main()
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            pattern(num, 1);
        }
    }

}
