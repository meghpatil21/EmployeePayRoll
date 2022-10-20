namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.");

            int empWorkHours = 0, empWage = 0;
            Random random = new Random();
            int empCheck= random.Next(0,3);

            switch(empCheck)
            {
                case 0: 
                    Console.WriteLine("Employee is Present Full time");
                    empWorkHours = empWorkHours + 8;
                    empWage = empWorkHours * 20;
                    break;
                case 1:
                    Console.WriteLine("Employee is Present Part time");
                    empWorkHours= empWorkHours + 4;
                    empWage= empWorkHours * 20;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    break ;
            }

            Console.WriteLine("Todays Employee Wage: "+ empWage);
        }
    }
}