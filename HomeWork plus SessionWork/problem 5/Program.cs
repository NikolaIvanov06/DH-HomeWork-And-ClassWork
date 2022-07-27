using System;

namespace problem_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;
            for (int i = 1; i <= 9; i++)
            {
                if (n % i == 0)
                {
                    n1 = i;
                    for (int j = 0; j <= 9; j++)
                    {
                        if (n % j == 0)
                        {
                            n2 = j;
                            for (int k = 0; k <= 9; k++)
                            {
                                if (n % k == 0)
                                {
                                    n3 = k;
                                    for (int l = 0; l <= 9; l++)
                                    {
                                        if (n % l == 0)
                                        {
                                            n4 = l;
                                            Console.WriteLine($"{n1}{n2}{n3}{n4}");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
