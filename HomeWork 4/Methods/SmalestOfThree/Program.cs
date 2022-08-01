ValueCheker();


static void ValueCheker()
{
    int value = int.Parse(Console.ReadLine());
    int smallestNum = value;

    for (int i = 0; i < 2; i++)
    {

        if (value < smallestNum)
        {
            smallestNum = value;
        }

        value = int.Parse(Console.ReadLine());

        if (value < smallestNum)
        {
            smallestNum = value;
        }
    }

    Console.WriteLine(smallestNum);
    
}
