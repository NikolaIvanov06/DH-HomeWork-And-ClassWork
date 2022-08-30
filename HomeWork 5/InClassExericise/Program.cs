int passeddCount = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
int carsPassed = 0;
Queue<string> queue = new Queue<string>();

while (input != "end")
{
    if (input == "green")
    {
        for (int i = 0; i < passeddCount; i++)
        {


            if (queue.Count == 0)
            {
                input = Console.ReadLine();
                continue;
            }
               string car = queue.Dequeue();
            Console.WriteLine($"{car} passed!");
            carsPassed++;

        }
    }
    else
    queue.Enqueue(input);

    input = Console.ReadLine();
}
