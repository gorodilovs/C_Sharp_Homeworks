// Дан массив. Найдите три последовательных элемента в массиве, сумма которых максимальна.

int n = 20;
int[] arr = new int[n];
Random rnd = new Random();
int maxSum = 0;
int indexOfMax = 0;

for(int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 20);
}


for(int i = 0; i < arr.Length - 2; i++)
{
    if(arr[i] + arr[i + 1] + arr[i + 2] > maxSum)
    {
        maxSum = arr[i] + arr[i + 1] + arr[i + 2];
        indexOfMax = i;
    }
}

for(int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

Console.WriteLine($"Max sum: {maxSum} Index of max starts from {indexOfMax}");