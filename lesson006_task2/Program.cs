//Программа, которая принимает на вход три числа и выдает максимальное из этих чисел

Console.WriteLine("input number: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("input number: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("input number: ");
int c = int.Parse(Console.ReadLine());

if(a>b && b>c)
{ 
    Console.Write("max = " + a);
}

else if (b>c)
{
    Console.Write("max = " + b);
} 

else 
{
    Console.Write("max = " + c);
}