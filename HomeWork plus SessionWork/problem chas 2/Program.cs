using System;

namespace problem_chas_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int bookCounter = 0;
            string CorrectImput = Console.ReadLine();
            string imput = Console.ReadLine();
            while (imput != "No More Books!")
            {
                if (imput == CorrectImput)
                {
                    Console.WriteLine($"You checked {bookCounter} books and found it.");
                    return;
                }
                bookCounter++;
                imput = Console.ReadLine();
            }
            Console.WriteLine($"The book you search is not here! You checked {bookCounter} books. ");
        }
    }
}
