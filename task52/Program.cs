int[,] randomArray = GetFillArray(3, 4);
PrintArray(randomArray);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца:");
FindAverage(randomArray);

int[,] GetFillArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random randomElement = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomElement.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindAverage(int[,] array)
{
    double average = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i, j];
        }
        average = Math.Round(average / array.GetLength(0), 1, MidpointRounding.ToZero);
        Console.Write($"{average}; ");
        average = 0;
    }
}