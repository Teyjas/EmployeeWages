using System;
//Employee wage for 20 days
namespace EmployeeWages
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Employee Wage Calculator");
            int workingHr = 0;
            int perHrSalary = 20;
            int totalSalary = 0;

            for (int day = 0; day <= 20; day++)
            {

                Random rnd = new Random();
                int present = (rnd.Next(3));

                switch (present)
                {
                    case 0:
                        Console.WriteLine("employee  is Absent");
                        workingHr = 0;
                        break;

                    case 1:
                        Console.WriteLine("employee  is Present");
                        workingHr = 8;
                        break;

                    case 2:
                        Console.WriteLine("Employee is part time present");
                        workingHr = 4;
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            int salary = perHrSalary * workingHr;
            totalSalary = return (totalSalary + salary);
        }
        Console.WriteLine($ "Total Salary {total salary}");

        
    }
}