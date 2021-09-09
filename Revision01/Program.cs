using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    class Program
    {


        static void Main(string[] args)
        {

        
            

            //Assignment: Display your details in multiple lines on the Console.
            
            Console.WriteLine("Welcome to FNF .NET Training\n");
            Console.WriteLine("Hello Team\n");
            Console.WriteLine("Let's get started\n");

            //Assigment: Display the details by storing the data as variables and use string format to display them

            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your Employee ID");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your role");
            string role = Console.ReadLine();

            Console.WriteLine("Enter your E-mail Id");
            string email = Console.ReadLine();

            Console.WriteLine("Enter the Date of Joining as dd/MM/yyyy");
            DateTime dt = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Hi {0} your EmpId is {1} working as {2} from {3}, can be contacted {4}  \n", name, id, role, dt.ToString("dd/mm/yyyy"), email);

            //Write a Calc Program that will take inputs from the user and displays the data based on the operator selected by the User...

            Console.WriteLine("Enter the 1st Number");
                double num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the 2nd Number");
                double num2 = int.Parse(Console.ReadLine());
                
                TRYAGAIN:
                Console.WriteLine("1. Addition 2. Subtraction 3. Multiplication 4. Division ");
                Console.WriteLine("Enter Your Choice to Perform Operations");

            var value = int.Parse(Console.ReadLine());    

                switch(value)
                {
                case 1:
                    Console.WriteLine("Sum is " + (num1 + num2)); ;
                    break;
                case 2:
                    Console.WriteLine("Difference is " + (num1 - num2)); ;
                    break;
                case 3:
                    Console.WriteLine("Productis " + (num1 * num2)); ;
                    break;
                case 4: if(num2 == 0)
                        Console.WriteLine("Divide by Zero Error");                      
                        else                    
                        Console.WriteLine("Quotient is " + (num1 / num2)); 
                        break;           
                default:
                    Console.WriteLine("Select the valid Input");
                    goto TRYAGAIN;
            }
        }
    }
}


