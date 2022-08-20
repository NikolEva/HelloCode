//программа, которая на вход принимает число и выдаёт, является ли число четным (делится лионо на два без остатка)

Console.WriteLine("inpur number");
int a = int.Parse(Console.ReadLine());
if(a%2==0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("нечетное");
}