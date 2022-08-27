// программа, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.
// например: 3 -> 1, 8, 27      5 -> 1, 8 , 27, 64, 125

Console.Clear();
Console.Write("введите число: ");
int a = int.Parse(Console.ReadLine());

Console.Write(a + " -> ");
a = Math.Abs(a);

for(int i=1; i<=a; i++)
{
    Console.Write(Math.Pow(i, 3) + ", ");
}