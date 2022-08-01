AddFirstTwoElementsAndSubstractTheThirdOne();



static void AddFirstTwoElementsAndSubstractTheThirdOne()
{
    int firstNum = int.Parse(Console.ReadLine());
    int secondNum = int.Parse(Console.ReadLine());
    int firstAndSecondSum = firstNum + secondNum;
    int fullSum = firstAndSecondSum - SubractNumber();
    Console.WriteLine(fullSum);

}

static int SubractNumber()
{
    int thirdNumber = int.Parse(Console.ReadLine());
    return thirdNumber;
}
