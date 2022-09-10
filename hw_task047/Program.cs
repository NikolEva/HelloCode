// задайте двумерный массив размером m*n, заполненный случайными вещественными числами
// например: m = 3, n = 4
//          0,5 7 -2 -0,2
//          1 -3,3 8 -9,9
//          7 7,8 -7,1 9

double[,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble();
        }
    }
    return result;
}

void PrintArray(double[,] array)
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

Console.WriteLine("введите количество строк ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());

double[,] result = GetArray(rows, columns, 0, 9);
PrintArray(result);
