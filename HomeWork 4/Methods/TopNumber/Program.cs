int num = int.Parse(Console.ReadLine());

TopNumber(num);
static void TopNumber(int num)
{

    for (int i = 0; i <= num; i++)
    {
        int sumOfDigits = 0;
        int tempNum = i;
        bool oneOdd = false;
        while (tempNum > 0)
        {
            int lastDigit = tempNum % 10;
            sumOfDigits += lastDigit;
            tempNum /= 10;
            if (lastDigit % 2 != 0)
            {
                oneOdd = true;
            }
        }

        if (sumOfDigits % 8 == 0 && oneOdd)
        {
            Console.WriteLine(i);
        }

    }
}
