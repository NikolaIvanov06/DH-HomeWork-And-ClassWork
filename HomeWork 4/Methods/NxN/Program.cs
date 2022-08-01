int num = int.Parse(Console.ReadLine());
ColomnXFullStructure(num);
static void ColomnXFullStructure(int num)
{
    for (int i = 0; i < num; i++)
    {
        Row(num);
        Console.WriteLine();
    }
}

static void Row(int num)
{
    for (int i = 0; i < num; i++)
    {
        Console.Write(num + " ");
    }

}
