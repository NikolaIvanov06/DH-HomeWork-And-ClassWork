
List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
string command = Console.ReadLine();
int num = 0;
int num2 = 0;
int possNum2 = 0;

while (command != "end")
{
    string[] arr = command.Split(' ');

    if (arr[0] == "Delete")
    {
        num = int.Parse(arr[1]);
        list.RemoveAll(x => x == num);
    }

    else if (arr[0] == "Insert")
    {
        num2 = int.Parse(arr[1]);
        possNum2 = int.Parse(arr[2]);
        list.Insert(possNum2, num2);
    }

    command = Console.ReadLine();
}

Console.WriteLine(String.Join(" ", list));
