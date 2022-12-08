// Удалить в массиве первый и последний элементы.

int capacity = 20;
int[] arr = new int[capacity];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 10);
}

System.Console.WriteLine("Original array: ");
foreach (int n in arr)
{
    System.Console.Write(n + " ");
}
System.Console.WriteLine();

for (int i = 0; i < arr.Length - 1; i++)
{
    arr[i] = arr[i + 1];
}
Array.Resize(ref arr, arr.Length - 2);

System.Console.WriteLine("Resized array minus first and last elements: ");
foreach (int n in arr)
{
    System.Console.Write(n + " ");
}
System.Console.WriteLine();