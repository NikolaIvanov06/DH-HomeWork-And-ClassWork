VowelCheker();

static void VowelCheker()
{
    string sentence = Console.ReadLine().ToLower();
    char[] charArr = sentence.ToCharArray();
    int counterOfVowels = 0;
    foreach (char ch in charArr)
    {
        if (ch is 'a' || ch is 'i' || ch is 'o' || ch is 'e' || ch is 'u')
        {
            counterOfVowels++;
        }
    }
    Console.WriteLine(counterOfVowels);


}