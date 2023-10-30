using System.Text.RegularExpressions;

string dimesionsString = Console.ReadLine() ?? throw new ArgumentNullException(nameof(dimesionsString));
int rows;
int columns;
if (Regex.Match(dimesionsString, @"\d+ \d+").Value == dimesionsString)
{
    int[] dimesionsVec = dimesionsString.Split(' ').Select(int.Parse).ToArray();
    rows = dimesionsVec[0];
    columns = dimesionsVec[1];
}
else
{
    throw new FormatException(nameof(dimesionsString));
}
int[,] matrix = new int[rows, columns];
for (int m = 0; m < rows; m++)
{
    string rowString = Console.ReadLine() ?? throw new ArgumentNullException(nameof(dimesionsString));
    if (Regex.Match(rowString, @"(\d+ ){c}\d+".Replace("c", (columns - 1).ToString())).Value == rowString)
    {
        int[] rowVec = rowString.Split(' ').Select(int.Parse).ToArray();
        for (int n = 0; n < columns; n++)
        {
            matrix[m, n] = rowVec[n];
        }
    }
    else
    {
        throw new FormatException(nameof(rowString));
    }
}
int numberToCheckOccurences = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException(nameof(numberToCheckOccurences)));
for (int m = 0; m < rows; m++)
{
    for (int n = 0; n < columns; n++)
    {
        if (matrix[m, n] == numberToCheckOccurences)
        {
            Console.WriteLine("Position {0}, {1}:", m, n);
            if (n != 0)
            {
                Console.WriteLine("Left: {0}", matrix[m, n - 1]);
            }
            if (n != columns - 1)
            {
                Console.WriteLine("Right: {0}", matrix[m, n + 1]);
            }
            if (m != 0)
            {
                Console.WriteLine("Up: {0}", matrix[m - 1, n]);
            }
            if (m != rows - 1)
            {
                Console.WriteLine("Down: {0}", matrix[m + 1, n]);
            }
        }
    }
}