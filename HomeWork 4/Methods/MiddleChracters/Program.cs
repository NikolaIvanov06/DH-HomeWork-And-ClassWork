MiddleCharacters();


static void MiddleCharacters()
{
    string theText = Console.ReadLine();
    Char[] charArr = theText.ToCharArray();
    if (theText.Length % 2 == 0)
    {
        int[] arrForChIndex = { (((theText.Length - 1) / 2)), (((theText.Length - 1) / 2) + 1) };
        Console.Write(charArr[arrForChIndex[0]]);
        Console.Write(charArr[arrForChIndex[1]]);
    }
    else
    {
        Console.WriteLine(charArr[(theText.Length-1) / 2]);
    }
}
