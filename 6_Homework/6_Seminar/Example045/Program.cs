// Задача 45: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

int capacity = 20;
int[] arr = new int[capacity];
int[] newArr = new int[arr.Length];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 10);
}

for (int i = 0; i < newArr.Length; i++)
{
    newArr[i] = arr[i];
}

System.Console.WriteLine("Original array: ");
foreach (int n in arr)
{
    System.Console.Write(n + " ");
}
System.Console.WriteLine();

System.Console.WriteLine("Copied array: ");
foreach (int n in newArr)
{
    System.Console.Write(n + " ");
}
System.Console.WriteLine();