// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int[,,] NewMatrix(int a, int b, int c, int start, int end)
{
    List<int> unique = new List<int>();
    for (int i = start; i < end; i++)
        unique.Add(i);

    int index = 0;
    int[,,] array = new int[a, b, c];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                index = new Random().Next(0, unique.Count);
                array[i, j, k] = unique[index];
                unique.RemoveAt(index);
            }
    return array;
}

void PrintMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) \t");
            Console.WriteLine();
        }
}

Console.Clear();
int[,,] array = NewMatrix(2, 2, 2, 10, 100);
PrintMatrix(array);