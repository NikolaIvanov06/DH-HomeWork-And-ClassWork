using System;

namespace problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupBudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int groupMembers = int.Parse(Console.ReadLine());
            double rent = 0;
            switch (season)
            {
                case "Spring":
                    rent = 3000;
                    break;
                case "Summer":
                    rent = 4200;
                    break;
                case "Autumn":
                    rent = 4200;
                    break;
                case "Winter":
                    rent = 2600;
                    break;

                default:
                    break;
            }
            if (groupMembers >= 12)
            {
                rent *= 0.75;
            }
            else if (groupMembers >= 7)
            {
                rent *= 0.85;
            }
            else
            {
                rent *= 0.9;
            }

            if (groupMembers % 2 == 0 && season != "Autumn")
            {
                rent *= 0.95;
            }

            if (groupBudget - rent < 0)
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(groupBudget - rent):f2} leva.");
            }
            else
            {
                Console.WriteLine($"Yes! You have {(groupBudget - rent):f2} money left.");
            }
        }
    }
}
