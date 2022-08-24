// программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// например: 645 -> 5    78 -> третьей цифры нет  32679 -> 6

Console.WriteLine("введите число: ");
int a = int.Parse(Console.ReadLine());

if (a > 99 || a < -99)
{
    int res = (a / 100)%10;
    Console.WriteLine(a + " -> " + res);
}
else
{
    Console.WriteLine(a + " -> третьей цифры нет");
}