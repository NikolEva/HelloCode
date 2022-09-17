// Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N
// M = 1; N = 15. -> 120         M = 4; N = 8. -> 30

int Sum(int m, int n)
{
    if(m == n + 1) return 0;
    else return m + Sum(m + 1, n);
}

Console.Write("введите число m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("введите число n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(Sum(m, n));