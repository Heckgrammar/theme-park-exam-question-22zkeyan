namespace ThemeParkCalculationTask
{
    internal class Program
    {
        static int CalculateCost(int people)
        {
            const int cost_per_person = 15;
            int total = cost_per_person * people;
            if (people >= 6)
            {
                total -= 5;
            }
            return total;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number of people: ");
            int people = Convert.ToInt32(Console.ReadLine()!);
            int total = CalculateCost(people);
            Console.WriteLine($"The total is £{total}");
        }
    }
}
