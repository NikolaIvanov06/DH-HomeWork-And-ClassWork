FullPassValidation(Console.ReadLine());

static void FullPassValidation(string password)
{
    int falseCounter = 0;
    bool validCheker = false;
    if (PassRange(password, validCheker) == false)
    {
        falseCounter++;
    }
    if (PassContains(password, validCheker) == false)
    {
        falseCounter++;
    }
    if (DigitNumCheker(password, validCheker) == false)
    {
        falseCounter++;
    }
    if (falseCounter == 0)
    {
        Console.WriteLine("Password valid!");
    }
}

static bool PassRange(string password, bool validCheker)
{

    char[] charArr = password.ToCharArray();

    if (charArr.Length > 10 || charArr.Length < 6)
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
        return false;
    }

    return true;

}


static bool PassContains(string password, bool validCheker)
{
    char[] charArr = password.ToCharArray();

    foreach (char ch in charArr)
    {
        if (Char.IsLetterOrDigit(ch) == false)
        {
            Console.WriteLine("Password must consist only of letters and digits");
            return false;
        }
    }
    return true;
}

static bool DigitNumCheker(string password, bool validCheker)
{
    int counterForDigits = 0;
    char[] charArr = password.ToCharArray();

    foreach (char ch in charArr)
    {

        if (Char.IsDigit(ch))
        {
            counterForDigits++;

        }

    }

    if (counterForDigits < 2)
    {
        Console.WriteLine("Password must have at least 2 digits");
        return false;
    }
    return true;
}

