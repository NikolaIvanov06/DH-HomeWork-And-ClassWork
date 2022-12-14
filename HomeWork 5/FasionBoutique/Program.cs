int[] quantityOfClothes = Console.ReadLine().Split().Select(int.Parse).ToArray();

int capacityOfRack = int.Parse(Console.ReadLine());

Stack<int> clothesStack = new Stack<int>(quantityOfClothes);

int countRack = 1;
int sumClothes = 0;


while (clothesStack.Count > 0)
{
    var currElement = clothesStack.Pop();
    if (sumClothes + currElement <= capacityOfRack)
    {
        sumClothes += currElement; 
    }
    else
    {
        sumClothes = currElement; 
        countRack++;
    }
}

Console.WriteLine(countRack);
