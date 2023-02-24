// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] NewArray ()
{
    int[,] array = new int[new Random().Next(2, 6), new Random().Next(2, 6)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(0, 11);
    }
    return array;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]} \t");
        Console.WriteLine();
    }
}

void SumElementsOfArrayRows(int[,] array)
{
    int sum = 0, min = 0;
    int[] sumsOfRows = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        Console.WriteLine($"Сумма элементов {i + 1} строки: {sum}");
        if (i == 0)
            min = sum;
        if (sum < min)
            min = sum;
        sumsOfRows[i] = sum;
        sum = 0;
    }

    Console.Write($"Строка(и) с наименьшей суммой элементов:");
    string elements = string.Empty;
    for (int i = 0; i < sumsOfRows.Length; i++)
        if (sumsOfRows[i] == min)
            elements = elements + string.Format(", {0}", i + 1);
    elements = elements.Remove(0, 1);
    Console.Write(elements);
}

Console.Clear();
Console.WriteLine("Исходный массив");
int[,] array = NewArray();
PrintArray(array);
SumElementsOfArrayRows(array);