// Задача 32: Напишите программу замены элементов массива:
// положительные замените на соответсвующие отрицательные, и наоборот.

int[] arr = new int[10];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-10, 10);
}

Console.WriteLine("Original array: ");
foreach (int n in arr)
{
    Console.Write(n + " ");
}
Console.WriteLine();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = -arr[i];
}

Console.WriteLine("Inverted array: ");
foreach (int n in arr)
{
    Console.Write(n + " ");
}
