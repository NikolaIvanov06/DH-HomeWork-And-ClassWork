char firstSymbol = char.Parse(Console.ReadLine());
char secondSymbol = char.Parse(Console.ReadLine());
List<string> symbols = new List<string>();
if (secondSymbol < firstSymbol)
{
    char additionaTemp = firstSymbol;
    firstSymbol = secondSymbol;
    secondSymbol = additionaTemp;
}
while (firstSymbol != secondSymbol)
{
    firstSymbol++;
    if (firstSymbol == secondSymbol)
    {
        break;
    }
    symbols.Add(firstSymbol.ToString());
}
Console.WriteLine(String.Join(" ", symbols));
