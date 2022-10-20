namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.");

            Random random = new Random();
            int empCheck= random.Next(0,2);

            switch(empCheck)
            {
                case 0: 
                    Console.WriteLine("Employee is Present");
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    break ;
            }


        }
    }
}