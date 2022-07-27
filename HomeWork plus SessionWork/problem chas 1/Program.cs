using System;

namespace problem_chas_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double roses = 5;
            double dahlias = 3.50;
            double tulips = 2.80;
            double narcissus = 3;
            double gladiola = 2.50;
            double lastPrice = 0;
            string flowers = Console.ReadLine();
            double numOfFlowers = int.Parse(Console.ReadLine());
            double budget = int.Parse(Console.ReadLine());
            switch (flowers)
            {
                case "Roses":
                    if (numOfFlowers >= 80)
                    {
                        lastPrice = (numOfFlowers * roses) * 0.9;
                    }
                    else 
                    
                    {
                        lastPrice = numOfFlowers * roses;
                    }

                    break;
                case "Dahlias":
                    if (numOfFlowers >= 90)
                    {
                        lastPrice = (numOfFlowers * dahlias) * 0.85;
                    }
                    else

                    {
                        lastPrice = numOfFlowers * dahlias;
                    }
                    break;
                case "Tulips":
                    if (numOfFlowers >= 80)
                    {
                        lastPrice = (numOfFlowers * tulips) * 0.85;
                    }
                    else

                    {
                        lastPrice = numOfFlowers * tulips;
                    }
                    break;
                case "Narcissus":
                    if (numOfFlowers <= 120)
                    {
                        lastPrice = (numOfFlowers * narcissus) * 1.15;
                    }
                    else

                    {
                        lastPrice = numOfFlowers * narcissus;
                    }
                    break;
                case "Gladiolus":
                    if (numOfFlowers <= 80)
                    {
                        lastPrice = (numOfFlowers * gladiola) * 1.1;
                    }
                    else

                    {
                        lastPrice = numOfFlowers * gladiola;
                    }
                    break;

                default:
                    break;
            }
            if (budget >= lastPrice)
            {
                Console.WriteLine($"Hey you have a great garden with {numOfFlowers} {flowers} and {(budget - lastPrice):f2} leva left.");
            }
            else 
            {
                Console.WriteLine($"Not enough money left, you need {(lastPrice - budget):f2} leva more.");
            }
        }
    }
}
