// задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("введите количество строк у первой матрицы: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("введите количество столбцов у первой матрицы (и строк второй): ");
int columns = int.Parse(Console.ReadLine());

Console.Write("введите количество столбцов у второй матрицы: ");
int columns1 = int.Parse(Console.ReadLine());



int[,] array1 = GetArray(rows, columns, 0, 10);
PrintArray(array1);

Console.WriteLine();

int[,] array2 = GetArray(rows, columns1, 0, 10);
PrintArray(array2);

int[,] result = new int[rows, columns1];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns1; j++)
    {
        int x = 0;
        for (int k = 0; k < columns; k++)
        {
            x = x + array1[i, k] * array2[k, j];
        }
        result[i, j] = x;
    }
}
Console.WriteLine();
PrintArray(result);