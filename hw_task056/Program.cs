// задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
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

Console.Write("введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("введите количество столбиков: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
int sum = 0;
for (int i = 0; i < 1; i++)
{
    for (int j = 0; j < columns; j++)
    {
        sum = sum + array[i, j];
    }
}

int minSum = sum;
int iMin = 0;
for (int i = 1; i < rows; i++)
{
    sum = 0;
    for (int j = 0; j < columns; j++)
    {
        sum = sum + array[i, j];
    }
    if(sum < minSum)
    {
        iMin = i;
        minSum = sum;
    }
}

Console.WriteLine(iMin + " строка с наименьшей суммой элементов");

