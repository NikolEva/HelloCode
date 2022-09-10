// напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
// например, задан массив: 1 4 7 2 
//                         5 9 2 3
//                         8 4 2 4
//                    17 -> такого числа в массиве нет

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

Console.WriteLine("введите число, которое нужно найти ");
int x = int.Parse(Console.ReadLine());

int[,] result = GetArray(rows, columns, 0, 20);
PrintArray(result);

int num = 0;
for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        if(result[i, j] == x)
        {
            num = 1;
        }  
    }
}

if(num == 1)
{
    Console.WriteLine(x + " -> такое число в массиве есть");
}
else
{
    Console.WriteLine(x + " -> такого числа в массиве нет");
}
