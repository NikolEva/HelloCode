// программа, которая принаимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// например: 14212 -> нет    23432 -> да      12821 -> да

Console.Write("введите пятизначное число ");
int a = int.Parse(Console.ReadLine());

int b = a/10000;
int c = a%10;
int d = (a/1000)%10;
int e = (a/10)%10;

if(b == c && d == e)
{
    Console.WriteLine(a + " -> да");
}
else
{
    Console.WriteLine(a + " -> нет");
}