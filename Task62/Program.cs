// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4
int[,] NewArray(int rows, int columns, int start)
{
    int[,] a = new int[rows, columns];
    int end = rows * columns;
    int r = 0;
    int c = 0;
    int m = 0;
    int i = 0;
    while (i < end)
    {
        while (c <= columns - 1)
        {
            if (i == end)
                break;
            a[r, c] = start;
            start++;
            i++;
            c++;
        }
        c--;
        r++;

        while (r <= rows - 1)
        {
            if (i == end)
                break;
            a[r, c] = start;
            start++;
            i++;
            r++;
        }
        c--;
        r--;
        rows--;
        columns--;

        while (c >= 0)
        {
            if (i == end)
                break;
            a[r, c] = start;
            start++;
            i++;
            c--;
        }
        c++;
        r--;
        m++;

        while (r >= m)
        {
            if (i == end)
                break;
            a[r, c] = start;
            start++;
            i++;
            r--;
        }
        r++;
        c++;
    }

    return a;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Исходный массив");
PrintArray(NewArray(4, 4, 5));