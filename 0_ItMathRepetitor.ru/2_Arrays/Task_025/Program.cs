// Найдите сумму нечетных чисел массива, которые не превосходят 11.

int[] arr = new int[30];
Random rnd = new Random();
int sum = 0;


for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 20);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
    if (arr[i] % 2 != 0 && arr[i] <= 12)
        sum += arr[i];
}
Console.WriteLine();
Console.WriteLine($"Sum = {sum}");