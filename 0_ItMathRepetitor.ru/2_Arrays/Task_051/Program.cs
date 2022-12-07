// В данном массиве найдите два наименьших элемента.

int[] arr = new int[20];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-10, 10);
}

int min1 = arr[0];
int min2 = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < min1)
    {
        min2 = min1;
        min1 = arr[i];
    }
}
 
foreach (int n in arr)
{
    Console.Write(n + " ");
}
Console.WriteLine();
Console.WriteLine($"First minimal: {min1}. Second minimal: {min2}");