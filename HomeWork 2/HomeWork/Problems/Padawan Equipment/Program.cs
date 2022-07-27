using System;
using System.Linq;

namespace Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double amountOfMoney = int.Parse(Console.ReadLine());
            double countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = int.Parse(Console.ReadLine());
            double priceOfRobes = int.Parse(Console.ReadLine());
            double priceOfBelts = int.Parse(Console.ReadLine());
            double numOfSabers = Math.Ceiling(countOfStudents * 1.1);
            double totalPriceOfSabers = numOfSabers * priceOfLightsabers;
            double freeBelts = Math.Floor(countOfStudents / 6);
            double totalPriceOfBelts = (countOfStudents - freeBelts) * priceOfBelts;
            double numOfRobes = countOfStudents;
            double totalPriceOfRobes = countOfStudents * priceOfRobes;
            double fullPrice = totalPriceOfBelts + totalPriceOfRobes + totalPriceOfSabers;

            if (amountOfMoney > fullPrice)
            {
                Console.WriteLine($"The money is enough - it whould cost {fullPrice:f2}");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(fullPrice - amountOfMoney):f2}");
            }
        }
    }

}
