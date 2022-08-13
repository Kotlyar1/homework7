double[,] randomArray = GetFillArray(3, 4);
PrintArray(randomArray);

double[,] GetFillArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random randomElement = new Random();
    int max = 5;
    int min = -5;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(randomElement.NextDouble()
                                        * (max - min) + min, 1);
        }
    }
    return array;
}



void PrintArray(double[,] array)
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