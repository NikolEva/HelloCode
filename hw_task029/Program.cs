// программа, которая задает массив из 8 элементов и выводит их на экран

int[] a = new int[8];
Random b = new Random();
Console.Write("[");
for (int i = 0; i < 8; i++)
{
    a[i] = b.Next(0,1000);
    Console.Write(a[i] + ", ");
}
Console.Write("]");