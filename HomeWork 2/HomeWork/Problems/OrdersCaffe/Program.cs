int num = 0;
int orders = int.Parse(Console.ReadLine());
double[] tExp = new double[orders];

while (num < orders)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    int capsules = int.Parse(Console.ReadLine());
    tExp[num] = ((num2 * capsules) * pricePerCapsule);
    string printValue = tExp[num].ToString("#.##");
    num++;
    Console.WriteLine("The price for the coffee is ${0}", printValue);
}
Console.WriteLine($"Total: ${tExp.Sum().ToString("#.##")}");