namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Employee Wage Computation Program.");
            Console.WriteLine();
            int totalWage = 0;

            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine("Day "+i);

                int empWorkHours = 0, empWage = 0; 
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case 0:
                        Console.WriteLine("Employee is Present Full time");
                        empWorkHours = empWorkHours + 8;
                        empWage = empWorkHours * 20;
                        break;
                    case 1:
                        Console.WriteLine("Employee is Present Part time");
                        empWorkHours = empWorkHours + 4;
                        empWage = empWorkHours * 20;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        break;
                }
                
                totalWage=totalWage+empWage;

                Console.WriteLine("Todays Employee Wage: " + empWage);
                Console.WriteLine($"Total Wage till day {i} : "+totalWage);
                Console.WriteLine();
                //Already use Switch Statement so no changes
            }

        }
    }
}