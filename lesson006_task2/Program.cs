//Программа, которая принимает на вход три числа и выдает максимальное из этих чисел

Console.WriteLine("input number: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("input number: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("input number: ");
int c = int.Parse(Console.ReadLine());
int max;

if(a>b)
{
    if(a>c)
    {
        Console.Write("max = ");
        Console.WriteLine(a);
    }
}

else if (b>c)
{
    Console.Write("max = ");
    Console.WriteLine(b);
} 

else 
{
    Console.Write("max = ");
    Console.WriteLine(c);
}