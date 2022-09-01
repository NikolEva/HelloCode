// программа, которая принимает на вход число и выдает сумму цифр в числе.   452 -> 11   82 -> 10    9012 -> 12

Console.Clear();

Console.Write("input number: ");
int a = int.Parse(Console.ReadLine());

a = Math.Abs(a);

if ( a > 9)
{   
    int sum = 0;
    for (int i = a; i > 0; i=i/10)
    {
        int b = i%10;
        sum = sum + b;
    }

    Console.WriteLine(a + " -> " + sum);
}
else
{
    Console.WriteLine(a + " -> " + a);
}