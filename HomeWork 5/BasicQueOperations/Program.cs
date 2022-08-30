int[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

Stack<int> stackOfNumbers = new Stack<int>();

for (int i = 0; i < commands[0]; i++)
{
    stackOfNumbers.Push(numbers[i]);
}

for (int i = 0; i < commands[1]; i++)
{
    stackOfNumbers.Pop();
}

int smallestNumberInStack = int.MaxValue;
bool printSmallestNumber = false;

while (stackOfNumbers.Count != 0 && !printSmallestNumber)
{
    int currentNumber = stackOfNumbers.Pop();

    if (currentNumber == commands[2])
    {
        printSmallestNumber = true;
    }

    if (currentNumber < smallestNumberInStack)
    {
        smallestNumberInStack = currentNumber;
    }
}

if (printSmallestNumber)
{
    Console.WriteLine("true");
}
else
{
    smallestNumberInStack = smallestNumberInStack == int.MaxValue ? 0 : smallestNumberInStack;

    Console.WriteLine(smallestNumberInStack);
}
