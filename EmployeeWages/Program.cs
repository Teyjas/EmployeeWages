using System;
//Daily wage in array format
namespace EmployeeWages;

    class program
    {
        public static int GetEmpWage()
        {
            const int ABSENT = 0;
            const int PRESENT = 1;
            const int PART_TIME = 2;
            int workingHr = 0;

            Random rnd = new Random();
            int present = (rnd.Next(3));

            switch (present)
            {
                case 0:
                    workingHr = ABSENT;
                    break;

                case PRESENT:
                    workingHr = 8;
                    break;

                case 2:
                    workingHr = PART_TIME;
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }


            return workingHr;
        }

    public static void Main(String[] args)

    {
        Console.WriteLine($"Employee Wage Calculator");
        const int PER_HR_SALARY = 20;
        int totalSalary = 0;
        int totalHr = 0;
        int[] dailyWageArray = new int[20];

        for (int day = 1; day <= 20; day++)
        {

            int workingHr = GetEmpWage();






            int salary = PER_HR_SALARY * workingHr;
            totalSalary = totalSalary + salary;
            totalHr = totalHr + workingHr;


            if (totalHr >= 100)
            {
                break;
            }

            salary = PER_HR_SALARY * workingHr;
            totalSalary = totalSalary + salary;
            totalHr = totalHr + workingHr;

            dailyWageArray[day] = salary;
        }

        Console.WriteLine($"Total Salary: {totalSalary}");
        Console.WriteLine($"Total working hours: {totalHr}");
        Console.WriteLine(String.Join(" ", dailyWageArray));
    }
        }
