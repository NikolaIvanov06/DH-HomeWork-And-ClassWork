PalidromeCheker();

static void PalidromeCheker()
{
    int n, r, sum = 0, temp;
    string command = Console.ReadLine();
    List<bool> list = new List<bool>();
    while (command != "END")
    {
        n = int.Parse(command);
        temp = n;
        while (n > 0)
        {
            r = n % 10;
            sum = (sum * 10) + r;
            n = n / 10;
        }
        if (temp == sum)
        {
            list.Add(true);
        }
        else
        {
            list.Add(false);
        }
        command = Console.ReadLine();
        sum = 0;
    }
    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine(list[i].ToString().ToLower());
    }
}
