// Задача 38: Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

int[] arr = new int[10];
Random rnd = new Random();
int diff;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 100);
}

int max = arr[0];
int min = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
        max = arr[i];
    if (arr[i] < min)
        min = arr[i];
}

foreach (int n in arr)
{
    Console.Write(n + " ");
}

diff = max - min;

Console.WriteLine();
Console.WriteLine($"Difference between max - {max} and min - {min}: {diff}.");