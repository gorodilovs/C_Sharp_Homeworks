// Задача 36: Задайте одномерный массив, заполненный случайными
// числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = new int[10];
Random rnd = new Random();
int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 100);
    if (i % 2 != 0)
    {
        sum += arr[i];
    }
}

foreach (int n in arr)
{
    Console.Write(n + " ");
}

Console.WriteLine();
Console.WriteLine($"Sum of elements in the odd positions is: {sum}");