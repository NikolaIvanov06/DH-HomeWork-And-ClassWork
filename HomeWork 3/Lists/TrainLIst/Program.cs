List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
int maxCapacity = int.Parse(Console.ReadLine());
int numOfWagons = wagons.Count;
string input = Console.ReadLine();

while (input != "end")
{

string[] inputArr = input.Split(' ');

    if (inputArr[0] == "Add")
    {
        wagons.Add(int.Parse(inputArr[1]));
    }

    else
    {
        int numOfPassengers = int.Parse(inputArr[0]);

        for (int i = 0; i <= numOfWagons; i++)
        {
            if (wagons[i] + numOfPassengers <= maxCapacity)
            {
                wagons[i] += numOfPassengers;
                break;
            }   
        }
    }

    input = Console.ReadLine();
}

Console.WriteLine(String.Join(" ", wagons));

