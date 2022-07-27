int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray(); ;

int left, right;
int index = 0;
int num = 0;

while (num < array.Length)
{
    left = 0;
    right = 0;

    for (int j = 0; j < array.Length; j++)
    {
        if (j < num)
        {
            left += array[j];
        }
        if (j > num)
        {
            right += array[j];
        }

    }
    if (left == right)
    {
        index = num;
    }
    num++;
}
if (index == 0)
{
    if (array.Length == 1)
    {
        Console.WriteLine("0");

    }

    else
    {
        Console.WriteLine("No");
    }
}


if (index != 0)
{
    Console.WriteLine(index);
}

