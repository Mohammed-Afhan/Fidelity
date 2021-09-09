using System;
using Day1Assignments.Day02;

namespace Day1Assignments.Day03
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public int EmpDOB { get; set; }


        public static void CreateNewEmployee()
        {
            var EmpId = MyConsole.GetNumber("Enter the ID");
            Console.WriteLine(EmpId);

            var EmpName = MyConsole.GetString("Enter Employee Name");
            Console.WriteLine(EmpName);

            var EmpAddress = MyConsole.GetString("Enter Employee Address");
            Console.WriteLine(EmpAddress);

            Console.WriteLine("Enter the Employee DOB");
            var EmpDOB = Console.ReadLine();
            Console.WriteLine(EmpDOB);
        }

        static void Main()
        {
           var empObj = CreateNewEmployee();            
            Console.WriteLine($"The name of the Employee entered is {empObj.EmpName} from {empObj.EmpAddress} whose date of birth is {empObj.EmpDOB.ToLongDateString()} and has his Employee ID as {empObj.EmpID}");

            Employee[] employees = new Employee[2];
            for (int i = 0; i < 2; i++)
            {
                employees[i] = createEmployee();
            }
            
            foreach(var emp in employees)
               Console.WriteLine(emp.EmpName);
           

        }

    }

  
   


}


