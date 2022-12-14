// задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

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

Console.Write("введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine();

for (int k = 0; k < rows; k++)    //пузырьковая сортировка для двумерного массива
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 1; j < columns; j++)
        {
            if(array[k, j] > array[k, j - 1])
            {
                int temp = array[k, j];
                array[k, j] = array[k, j - 1];
                array[k, j - 1] = temp;
            }
        }
    }
}
PrintArray(array);