// задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях (индексах).
// например: [3, 7, 23, 12] -> 19    [-4, -6, 89, 6] -> 0

int size = 4;
int minValue = -10;
int maxValue = 10;
int NumSum = 0;

int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(minValue, maxValue);
    if(i%2 == 1)
    {
        NumSum=array[i] + NumSum;
    }
}

Console.WriteLine(string.Join(",", array) + " -> " + NumSum);
