using System;
//Total_working_hours
namespace EmployeeWages
{
    class program
    {
        public static void GetEmpWage()
        {
            Console.WriteLine($"Employee Wage Calculator");
            int workingHr = 0;
            int perHrSalary = 20;
            int totalSalary = 0;
            int totalHrs = 0;

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


                int salary = perHrSalary * workingHr;
                totalSalary = (totalSalary + salary);

                if (totalHrs >= 100)
                {
                    break;
                }
            }

            Console.WriteLine($"Total Salary: {totalSalary}");
            Console.WriteLine($"Total working hours: {totalHrs}");
        }
        public static void Main(String[] args)

        {
            Console.WriteLine($"Employee Wage Calculator");
            GetEmpWage();

    }

    }
}