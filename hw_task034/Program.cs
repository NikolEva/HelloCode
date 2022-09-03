//задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве.
// например: [345,897,568,234] -> 2     

int size = 5;
int minValue = 100;
int maxValue = 1000;
int count = 0;

int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(minValue, maxValue);
}

for (int i = 0; i < size; i++)
{
    if(array[i]%2 == 0)
    {
        count++;
    }
}

Console.WriteLine(string.Join(",", array) + " -> " + count);