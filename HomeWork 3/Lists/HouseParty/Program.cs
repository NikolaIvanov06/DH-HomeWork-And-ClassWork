
List<string> guiestList = new List<string>();
List<string> notComingList = new List<string>();
string nameOfNotComingGuest = "";
string name = "";
int numOfComands = int.Parse(Console.ReadLine());
string command = Console.ReadLine();

for (int i = 0; i < numOfComands; i++)
{
    if (i > 0)
    {
        command = Console.ReadLine();
    }

    string[] array = command.Split(' ');
    name = array[0];

    if (array[2] == "not")
    {

        if (guiestList.Contains(name))
        {
            guiestList.Remove(name);
        }

        else
        {
            nameOfNotComingGuest = name;
            notComingList.Add(name);
        }
    }

    else
    {
        guiestList.Add(name);
    }
}

if (notComingList.Contains(nameOfNotComingGuest))
{
    Console.WriteLine($"{nameOfNotComingGuest} is not in the list!");

    for (int i = 0; i < guiestList.Count; i++)
    {
        Console.WriteLine(guiestList[i]);
    }
}

var duplicateNames = guiestList.GroupBy(x => x).Where(group => group.Count() > 1).Select(group => group.Key);
string dupName = duplicateNames.FirstOrDefault();

if (guiestList.Contains(dupName))
{
    var noDupesGuiestList = guiestList.Distinct().ToList();
    Console.WriteLine($"{dupName} is already in the list!");
    for (int i = 0; i < guiestList.Count - 1; i++)
    {
        Console.WriteLine(noDupesGuiestList[i]);

    }
}

