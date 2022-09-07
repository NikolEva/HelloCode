// Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь
// 0, 7, 8, -2, -2 -> 2      -1, -7, 567, 89, 223 -> 3

Console.WriteLine("введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int count = 0;

int[] arr = new int[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine("введите элемент массива ");
    arr[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < size; i++)
{
    if(arr[i] > 0)
    {
        count++;
    }
}

Console.WriteLine("массив " + string.Join(",", arr) + " -> " + count + " чисел больше 0");