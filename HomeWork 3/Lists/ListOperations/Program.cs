List<int> numList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
string command = Console.ReadLine();
bool invalid = false;
while (command != "End")
{
    string[] arr = command.Split(' ');
    if (arr[0] == "Add")
    {
        numList.Add(int.Parse(arr[1]));
    }
    else if (arr[0] == "Insert")
    {
        if (int.Parse(arr[1]) > numList.Count - 1)
        {
            invalid = true;
        }
        else
        numList.Insert(int.Parse(arr[1]), int.Parse(arr[2]));

    }
    else if (arr[0] == "Remove")
    {
        if (int.Parse(arr[1]) > numList.Count - 1)
        {
            invalid = true;
        }
        else
        numList.RemoveAt(int.Parse(arr[1]));


    }
    else if (arr[0] == "Shift" && arr[1] == "left")
    {
        for (int j = 0; j < int.Parse(arr[2]); j++)
        {
            int firstIndex = numList[0];

            for (int i = 0; i < numList.Count - 1; i++)
            {
                numList[i] = numList[i + 1];
            }
            numList[numList.Count - 1] = firstIndex;
        }
    }
    else if (arr[0] == "Shift" && arr[1] == "right")
    {
        for (int j = 0; j < int.Parse(arr[2]); j++)
        {
            int lastIndex = numList[numList.Count - 1];

            for (int i = 0; i < numList.Count - 1; i++)
            {
                numList[numList.Count - 1 - i] = numList[numList.Count - 2 - i];
            }
            numList[0] = lastIndex;
        }

    }
    command = Console.ReadLine();
}
if (invalid)
{
    Console.WriteLine("Invalid index");
}
Console.WriteLine(String.Join(" ", numList));

