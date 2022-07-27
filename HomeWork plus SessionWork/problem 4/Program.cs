using System;

namespace problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i < secondNum; i++)
            {
                int oddSum = 0;
                int evenSum = 0;
                string CurrentNum = i.ToString();
                for (int j = 0; j < CurrentNum.Length; j++)
                {
                    int currentDigit = int.Parse(CurrentNum[j].ToString());
                    if (j%2 == 0)
                    {
                        oddSum += currentDigit;
                    }
                    else 
                    { 
                        evenSum += currentDigit;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
