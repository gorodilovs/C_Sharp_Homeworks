// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] arr = new int[10];
Random rnd = new Random();
int counter = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100, 1000);
    if (arr[i] % 2 == 0)   
        counter++;   
}

foreach (int n in arr)
{
    Console.Write(n + " ");
}

Console.WriteLine();
Console.WriteLine($"Quantity of even numbers: {counter}");