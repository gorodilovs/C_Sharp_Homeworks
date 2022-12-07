// Поменять местами наибольший(ие?) и наименьший(ие?) 
// элементы массива.

int capacity = 30;
int[] arr = new int[capacity];
Random rnd = new Random();
// int temp;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 20);
}


Console.WriteLine("Original array: ");
foreach (int n in arr)
{
    Console.Write(n + " ");
}
Console.WriteLine();


int max = arr[0];
int min = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < min)
        min = arr[i];
    if (arr[i] > max)
        max = arr[i];
}

Console.WriteLine($"Max is {max}");
Console.WriteLine($"Min is {min}");

bool replaced = false;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == max)
    {
        arr[i] = min;
        replaced = true;
    }
    if (arr[i] == min && !replaced)
        arr[i] = max;
replaced = false;
}

Console.WriteLine("Replaced array: ");
foreach (int n in arr)
{
    Console.Write(n + " ");
}
Console.WriteLine();
