// программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
// например: 6 -> да   7 -> да   1 - > нет

Console.WriteLine("введите номер дня недели: ");
int a = int.Parse(Console.ReadLine());

while(a > 7 || a < 1) 
{
    Console.WriteLine("введите номер дня недели (1-7): ");
    a = int.Parse(Console.ReadLine());
}    

if (a == 6 || a == 7)
{
    Console.WriteLine(a + " -> выходной ");
}
else 
{
    Console.WriteLine(a + " -> нет ");
}