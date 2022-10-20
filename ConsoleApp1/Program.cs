namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Employee Wage Computation Program.");
            Console.WriteLine();
            int totalWage = 0, dayCount=0, totalHours=0;

            do
            {
                dayCount++;
                Console.WriteLine("Day "+dayCount);

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
                totalHours=totalHours+ empWorkHours;

                totalWage=totalWage+empWage;

                Console.WriteLine("Todays Employee Wage: " + empWage);
                Console.WriteLine($"Total Wage till day {dayCount} : "+totalWage);
                Console.WriteLine();
                //Already use Switch Statement so no changes
            }while(dayCount<20 && totalHours<100);

            Console.WriteLine($"Total hours {totalHours} and Total days {dayCount}");
        }
    }
}