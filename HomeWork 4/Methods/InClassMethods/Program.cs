
PrintTrianle(108000);



static void PrintTrianle(int num)
{
    for (int i = 1; i <= num; i++)
    {
        PrintLine(1, i);

    }
    for (int i = num; i > 0; i--)
    {
        PrintLine(1, i);
    }
}
static void PrintLine(int start, int end)
{
    for (int  j = start; j < end; j++)
    {

        Console.WriteLine($"{j + 1}");
    }
    Console.WriteLine();
}


#pragma warning disable CS8321 // The local function 'PrintSignOfNumber' is declared but never used
static void PrintSignOfNumber (int signOfNumber)
#pragma warning restore CS8321 // The local function 'PrintSignOfNumber' is declared but never used
{
    if (signOfNumber > 0)
    {
        Console.WriteLine($"The number {signOfNumber} is positive!");
    }
    else if (signOfNumber < 0)
    {
        Console.WriteLine($"The number {signOfNumber} is negative!");
    }
    else
    {
        Console.WriteLine($"The number {signOfNumber} is zero!");
    }
    Console.WriteLine();
}
