Console.Write("Введите № строки: ");
bool inputFirst = int.TryParse(Console.ReadLine(), out int numberRows);

Console.Write("Введите № столбца: ");
bool inputSecond = int.TryParse(Console.ReadLine(), out int NumberColumns);

if (inputFirst && inputSecond)
{
    int[,] randomArray = GetFillArray(3, 4);
    PrintArray(randomArray);
    Console.WriteLine();
    FindElementPosition(randomArray, numberRows, NumberColumns);
}
else Console.WriteLine($"Некоректный ввод!");

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
        for (int j = 0; j < array.GetLength(1); j++ )
        {
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}
//СТРОКИ И СТОЛБЦЫ НАЧИНАЮТСЯ С 1
//чтобы использовать индексы (от 0), раскмментируйте строки 49,50
void FindElementPosition(int[,] array, int positionRows, int positionColumns)
{
    if (positionRows < array.GetLength(0) && positionColumns < array.GetLength(1))
    {
        Console.WriteLine($"На позиции строка № {positionRows}, столбец № {positionColumns}" +  
                            $"находится элемент со значением : {array[positionRows - 1, positionColumns -1]}");
      // Console.WriteLine($"На позиции строка № {positionRows}, столбец № {positionColumns}" +  
      //                      $"находится элемент со значением : {array[positionRows, positionColumns]}");                     
    }
    else Console.WriteLine($"строка № {positionRows}, столбец № {positionColumns} - такой позиции в массиве нет.");
}