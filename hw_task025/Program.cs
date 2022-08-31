// цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
// например: 3, 5 -> 243   2, 4 -> 16

Console.Clear();

Console.Write("input number A: ");
int a = int.Parse(Console.ReadLine());

Console.Write("input number B: ");
int b = int.Parse(Console.ReadLine());
int res = 1;
for (int i = 1; i <= b; i++)
{   
    res = res * a;
    
}
Console.WriteLine(a + ", " + b + " -> " + res);