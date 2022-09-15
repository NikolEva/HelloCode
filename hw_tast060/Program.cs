// сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

Console.Write("введите ширину куба ");
int x = int.Parse(Console.ReadLine());

Console.Write("введите высоту куба ");
int y = int.Parse(Console.ReadLine());

Console.Write("введите глубину куба ");
int z = int.Parse(Console.ReadLine());

int[,,] GetArray(int m, int n, int p, int minValue, int maxValue) // функция генерирует трехмерный массив неповторяющихся!!! чисел
{
    int[] temp = new int[m * n * p]; // сначала генерируем одномерный массив с неповторяющимися числами
    int num;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(minValue, maxValue + 1);
        num = temp[i];
        if(i > 0)
        {
            for (int j = 0; j < i; j++)
            {
                while(temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(minValue, maxValue + 1);
                    j = 0;
                    num = temp[i];
                }
                num = temp[i];
            }
        }
    }

    int count = 0; // а теперь из одномерного массива с неповторяющимися числами формируем трехмерный массив
    int[,,] result = new int[m, n, p];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {
                result[i, j, k] = temp[count];
                count++;
            }
        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {

                Console.Write(array[i, j, k] + "(" + i + j + k + ")" + " ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] array3D = GetArray(x, y, z, 10, 99);
PrintArray(array3D);

