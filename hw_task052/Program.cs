// задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// например, задан массив:  1 4 7 2
//                          5 9 2 3
//                          8 4 2 4
// среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

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
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("введите количество строк ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());

int[,] result = GetArray(rows, columns, 0, 10);
Console.WriteLine();
PrintArray(result);

for (int j = 0; j < result.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        sum = sum + result[i, j];
    }
    sum = Math.Round(sum/rows, 2);
    Console.WriteLine($"столбец {j+1}  {sum}");
}
