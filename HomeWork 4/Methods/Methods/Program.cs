#pragma warning disable CS8604 // Possible null reference argument for parameter 's' in 'int int.Parse(string s)'.
int fieldSize = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument for parameter 's' in 'int int.Parse(string s)'.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
int[] ladybugsPossition = Console.ReadLine().Split().Select(int.Parse).ToArray();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
int[] field = new int[fieldSize];

for (int i = 0; i < fieldSize; i++)
{
    if (ladybugsPossition.Contains(i))
    {
        field[i] = 1;
    }
    else
    {
        field[i] = 0;
    }
}
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
string command = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
while (command != "end")
{
#pragma warning disable CS8602 // Dereference of a possibly null reference.
    string[] commandArk = command.Split();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    int ladybugPoss = int.Parse(commandArk[0]);
    string direction = commandArk[1];
    int flyLenght = int.Parse(commandArk[2]);

    if (ladybugPoss < 0 || ladybugPoss > field.Length - 1)
    {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        command = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        continue;
    }

    if (field[ladybugPoss] != 1)
    {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        command = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        continue;
    }

    field[ladybugPoss] = 0;

    switch (direction)
    {
        case "left":
            {
                if (ladybugPoss + flyLenght > field.Length-1)
                {
                    break;
                }
#pragma warning disable CS0162 // Unreachable code detected
                for (int i = ladybugPoss + flyLenght; i < field.Length; i += flyLenght )
#pragma warning restore CS0162 // Unreachable code detected
                {

                    if (field[i] == 0)
                    {
                        field[i] = 1;
                    }
                    break;
                }

                break;
            }
        case "right":
        default:
            break;
    }


    Console.WriteLine(String.Join(" ", field));


#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    command = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
}