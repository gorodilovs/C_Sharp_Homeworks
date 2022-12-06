// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент массива, второй и
// предпоследний и т.д. Результат запишите в новом массиве.

int capacity = 20;
int[] originalArray = new int[capacity];
int[] newArray = new int[capacity / 2];
Random rnd = new Random();

for (int i = 0; i < originalArray.Length; i++)
{
    originalArray[i] = rnd.Next(1, 10);
}

for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = originalArray[i] * originalArray[originalArray.Length - 1 - i];
}

Console.WriteLine("Original array is: ");
foreach (int n in originalArray)
{
    Console.Write(n + " ");
}
Console.WriteLine();

Console.WriteLine("New array is: ");
foreach (int n in newArray)
{
    Console.Write(n + " ");
}
Console.WriteLine();
