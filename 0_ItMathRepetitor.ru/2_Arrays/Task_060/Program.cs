// Заменить каждый элемент массива с четным номером на соседний
// слева элемент.

int capacity = 30;
int[] arr = new int[capacity];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 10);
}

Console.WriteLine("Original array: ");
foreach (int n in arr)
{
    Console.Write(n + " ");
}
Console.WriteLine();

for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 == 0 && i != 0)
        arr[i] = arr[i - 1];
}

Console.WriteLine("Replaced array: ");
foreach (int n in arr)
{
    Console.Write(n + " ");
}
Console.WriteLine();