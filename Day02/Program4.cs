using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignments.Day02
{
    class Teams
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            Console.WriteLine("Enter the Names");

            for (int i = 0; i < names.Length; i++)
            {

                names[i] = Console.ReadLine();

            }
            Console.WriteLine("*******Teams********");
            foreach (string name in names)
            {

                Console.Write(name + "\n");
            }


            Console.Read();
        }
    }
}
