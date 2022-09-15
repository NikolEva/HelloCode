// заполните спирально массив 4 на 4

int m = 4;
int[,] spiralMatrix = new int[m, m];

int temp = 1;
int i = 0;
int j = 0;

while(temp <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
{
    spiralMatrix[i, j] = temp;
    temp++;
    if(i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
    {
        j++;
    }
    else if(i < j && i + j >= spiralMatrix.GetLength(0) - 1)
    {
        i++;
    }
    else if(i >= j && i + j > spiralMatrix.GetLength(1) - 1)
    {
        j--;
    }
    else
    {
        i--;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < 10)
            {
                Console.Write("0" + array[i, j] + " ");
            }
            else
            {
                Console.Write(array[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}

PrintArray(spiralMatrix);