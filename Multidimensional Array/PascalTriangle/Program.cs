int rows =int.Parse(Console.ReadLine());
int[][] triangle = new int[rows][];
int firstLastValue = 1;
for (int i = 0; i < triangle.Length; i++)
{
    triangle[i] = new int[i + 1];
    triangle[i][0] = firstLastValue;
    triangle[i][triangle[i].Length - 1] = firstLastValue;


    if (triangle[i].Length > 2)
    {
        for (int j = 1; j < triangle[i].Length - 1; j++)
        {
            triangle[i][j] = triangle[i - 1][j] + triangle[i - 1][j - 1];
        }
    }
}
foreach (var row in triangle)
{
    Console.WriteLine(String.Join(" ", row));
}
