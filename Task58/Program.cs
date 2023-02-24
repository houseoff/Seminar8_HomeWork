// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
int[,] NewMatrix(int a, int b)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 6);
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
}

int[,] ProdMatrix(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0))
        throw new Exception("Кол-во столбцов первой матрицы не соответствует кол-ву строк второй матрицы. Умножение невозможно", null);
    int[,] c = new int[a.GetLength(0), b.GetLength(1)];
    int sumOfProd = 0;
    for (int i = 0; i < c.GetLength(0); i++)
        for (int j = 0; j < c.GetLength(1); j++)
        {
            for (int k = 0; k < a.GetLength(1); k++)
                sumOfProd += a[i, k] * b[k, j];
            c[i, j] = sumOfProd;
            sumOfProd = 0;
        }
    return c;
}

Console.Clear();
Console.WriteLine($"Матрица а");
int[,] a = NewMatrix(2, 3);
PrintMatrix(a);
Console.WriteLine($"Матрица b");
int[,] b = NewMatrix(3, 4);
PrintMatrix(b);
try
{
    int[,] c = ProdMatrix(a, b);
    Console.WriteLine($"Матрица с");
    PrintMatrix(c);
}
catch (Exception e)
{
    Console.WriteLine($"Обнаружена ошибка: {e.Message}");
}