List<int> numList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int bombNum = arr[0];
int bombNumPower = arr[1];
int bombIndex = numList.IndexOf(bombNum);
int leftIndex = bombIndex - bombNumPower;
int rightIndex = bombIndex + bombNumPower;

while (numList.Contains(bombNum))
{
    if (leftIndex < 0)
    {
        leftIndex = 0;
    }

    if (rightIndex > numList.Count - 1)
    {
        rightIndex = numList.Count - 1;
    }

    numList.RemoveRange(leftIndex, rightIndex - leftIndex + 1);
}
Console.WriteLine(numList.Sum());
