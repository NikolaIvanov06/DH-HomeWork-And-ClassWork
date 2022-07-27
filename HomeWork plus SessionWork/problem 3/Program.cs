using System;

namespace problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stepsSum = 0;
            string command = Console.ReadLine();
            while (command != "Going Home!")
            {
                int steps = int.Parse(command);
                stepsSum += steps;
                if (stepsSum >= 10000)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{stepsSum-10000} steps over the goal!");
                }

                command = Console.ReadLine();
            }
            int finalSteps = int.Parse(Console.ReadLine());
            stepsSum += finalSteps;
            if (stepsSum >= 10000)
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{stepsSum - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{Math.Abs((stepsSum + finalSteps) - 10000)} more steps to reach the goal.");
            }
        }
    }
}
