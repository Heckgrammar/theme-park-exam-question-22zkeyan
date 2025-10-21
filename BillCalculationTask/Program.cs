namespace ThemeParkCalculationTask
{
    internal class Program
    {
        static int CalculateCost(int people)
        {
            const int cost_per_person = 15;
            int total = cost_per_person * people; //Mark C - multiplying people by 15
            if (people >= 6) //Mark B - selection //Mark D - correct boolean expression
            {
                total -= 5; //Mark E - reduce total by 5
            }
            return total;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number of people: ");
            int people = Convert.ToInt32(Console.ReadLine()!); //Mark A - inputting no. of people
            int total = CalculateCost(people);
            Console.WriteLine($"The total is £{total}"); //Mark F - outputting final cost
        }
    }
}
