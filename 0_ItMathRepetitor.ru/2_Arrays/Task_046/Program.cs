// Определите количество перемен знаков элементов массива.

int[] arr = new int[20];
Random rnd = new Random();
int counter = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-1, 2);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
    if (i < arr.Length -1 && arr[i] >= 0 && arr[i + 1] < 0)
    {
        counter++;
        Console.Write("!!! ");
    }
        
    if (i < arr.Length -1 && arr[i] < 0 && arr[i + 1] >= 0)
    {
        counter++;
        Console.Write("!!! ");
    }
}

Console.WriteLine();
Console.Write($"Number of changes: {counter}");