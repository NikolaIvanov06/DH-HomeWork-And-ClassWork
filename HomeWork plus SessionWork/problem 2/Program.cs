using System;

namespace problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            int badGradesCounter = 0;
            double gradeSumer = 0;
            double counter = 0;
            string lastCommand = "";


            while (badGradesCounter != badGrades)
            {
                string command = Console.ReadLine();
                if (command == "Enough")
                {
                    Console.WriteLine($"Average score: {gradeSumer / counter}");
                    Console.WriteLine($"Number of problems: {counter}");
                    Console.WriteLine($"Last problem: {lastCommand}");
                    return;
                }
                int grade = int.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    badGradesCounter++;
                }
                gradeSumer += grade;
                counter++;
                lastCommand = command;
            }
            
            Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
        }
    }
}
