// Найдите сумму наибольшего и наименьшего элементов массива.

int n = 10;
int[] arr = new int[n];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 10);

}

int max = arr[0];
int min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
    if (arr[i] < min)
        min = arr[i];
    if (arr[i] > max)
        max = arr[i];
}

Console.WriteLine();
Console.WriteLine($"Result is: {min + max}");