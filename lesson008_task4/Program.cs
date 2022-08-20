// программа, которая на вход принимает число(N), а на выходе показывает все четные числа от 1 до N

Console.WriteLine("input number ");
int a = int.Parse(Console.ReadLine());
while(a > 0)
{
    if(a%2 == 0)
    {
        Console.WriteLine(a);
        a = a-2;
    }
    else
    {
        a = a - 1;
        Console.WriteLine(a);
        a = a - 2;
    }
}
