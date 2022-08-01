int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
double result = FirstNum(a) / SecondNum(b);
Console.WriteLine($"{result:f2}");

static double FirstNum(int num)
{
    int factorial1 = num;
    for (int i = 1; i <= num-1; i++)
    {
        factorial1 = factorial1 * i;
    }
    return factorial1;
}
static double SecondNum(int num)
{
    int factorial2 = num;
    for (int i = 1; i <= num-1; i++)
    {
        factorial2 = factorial2 * i;
    }
    return factorial2;
}