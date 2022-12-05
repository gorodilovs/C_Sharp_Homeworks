// Дан массив. Найдите два соседних элемента, сумма которых минимальна.

int n = 5;
int[] arr = new int[n];
Random rnd = new Random();
int indexOfMin = 0;
int max = 0;

for(int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 20);
    if(arr[i] > max)
        max = arr[i];
}

int minSum = 2 * max;
for(int i = 1; i < arr.Length; i++)
{
    if(arr[i] + arr[i - 1] < minSum)
    {
        minSum = arr[i] + arr[i - 1];
        indexOfMin = i;
    }
}

for(int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

Console.WriteLine($"Min sum: {minSum} Indexes of elements: {indexOfMin - 1} and {indexOfMin}");