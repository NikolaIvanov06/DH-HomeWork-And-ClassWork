int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
string[] srt = new string[arr.Length];

int number = int.Parse(Console.ReadLine());
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    for (int n = 0; n < i; n++)
    {
        if (arr[i] + arr[n] == number)
        {
            srt[count] = arr[i] + " " + arr[n];
            count++;
        }
    }
}
int c = 0;
while (c < count)
{
    Console.WriteLine(srt[c]);
    c++;
}
