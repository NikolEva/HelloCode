// задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// например: [3 7 22 2 78] -> 76

int iMax = 0;
int iMin = 0;
double result = 0;

double[] array = new double[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();
}
Console.Write(string.Join(" ; ", array));

for (int i = 0; i < array.Length; i++)
{   
    if (array[i]> array[iMax])
    {
        iMax = i;
    }
    if (array[i] < array[iMin])
    {
        iMin =i;
    }
    result = array[iMax] - array[iMin];
}

Console.Write(" -> " + result);
