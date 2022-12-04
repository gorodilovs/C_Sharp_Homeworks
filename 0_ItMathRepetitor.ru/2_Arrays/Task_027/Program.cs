// Найдите сумму чисел массива, которые стоят на четных местах.

int[] arr = new int[10];
Random rnd = new Random();
int sum = 0;


for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 10);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
    if (i % 2 == 0 && i != 0)
        sum += arr[i];
}
Console.WriteLine();
Console.WriteLine($"Sum = {sum}");