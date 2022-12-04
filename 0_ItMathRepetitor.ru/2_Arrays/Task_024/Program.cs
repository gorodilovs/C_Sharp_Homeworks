// Найдите сумму четных чисел массива.

int[] arr = new int[30];
Random rnd = new Random();
int sum = 0;


for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 10);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
    if (arr[i] % 2 == 0)
        sum += arr[i];
}
Console.WriteLine();
Console.WriteLine($"Sum = {sum}");