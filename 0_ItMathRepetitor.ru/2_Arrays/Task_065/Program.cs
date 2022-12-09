// Переставить элементы массива в обратном порядке.

int capacity = 11;
int[] arr = new int[capacity];
Random rnd = new Random();
int temp;

void PrintArray(int[] a)
{
foreach (int n in a)
{
    System.Console.Write(n + " ");
}
System.Console.WriteLine();
}

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 10);
}

System.Console.WriteLine("Original array: ");
PrintArray(arr);

for (int i = 0; i < arr.Length/2; i++)
{
    temp = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = temp;
}

System.Console.WriteLine("Inverted array: ");
PrintArray(arr);