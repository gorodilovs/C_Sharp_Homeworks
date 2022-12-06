// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых
// лежат в отрезке [10, 99].

int[] arr = new int[123];
Random rnd = new Random();
int counter = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 1000);
    if (arr[i] >= 10 && arr[i] <= 99)
        counter++;
}

foreach (int n in arr)
{
    Console.Write(n + " ");
}
Console.WriteLine();

Console.WriteLine($"Quantity of numbers in range from 10 to 99 in the array is {counter}.");