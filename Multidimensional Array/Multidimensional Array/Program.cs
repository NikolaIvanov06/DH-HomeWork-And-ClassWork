
int rows = int.Parse(Console.ReadLine());
int[][] jaggedArray = new int[rows][];
for (int i = 0; i < jaggedArray.Length; i++)
{
    jaggedArray[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
}
string input = Console.ReadLine();
while (input != "END")
{
    var arguments = input.Split().ToArray();
    int row = int.Parse(arguments[1]);
    int col = int.Parse(arguments[2]);
    int value = int.Parse(arguments[3]);

    
    if (jaggedArray.Length <= row || jaggedArray[row].Length <= col)
    {
        Console.WriteLine("Invalid COORDINATES");
        input = Console.ReadLine();
        continue;
    }

    switch (arguments[0])
    {
        case "Add":
            {
                jaggedArray[row][col] += value;
                break;
            }
        case "Subtract":
            {
                jaggedArray[row][col] -= value;
                break;
            }
        default:
            break;
    }



    input = Console.ReadLine();
}

    foreach (int[] row in jaggedArray)
    {
        Console.WriteLine(String.Join(" ", row));
    }