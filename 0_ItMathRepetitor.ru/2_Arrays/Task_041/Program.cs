// Найдите количество чисел, каждое из которых равно сумме квадратов своих соседей и при этом не является наибольшим в массиве.

int n = 100;
int[] arr = new int[n];
Random rnd = new Random();
int counter = 0;
int max = 0;

for(int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 20);
    if (arr[i] > max)
        max = arr[i];
}


for(int i = 1; i < arr.Length - 1; i++)
{
    if(arr[i] == (int)Math.Pow(arr[i - 1], 2) + (int)Math.Pow(arr[i + 1], 2) && arr[i] != max)
    {
        counter++;
        Console.WriteLine($"Index of matched item {arr[i]}: {i}");
    }
}

for(int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

Console.WriteLine($"Answer is: {counter}");