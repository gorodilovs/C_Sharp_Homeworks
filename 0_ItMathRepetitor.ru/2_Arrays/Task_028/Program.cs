// Найдите сумму чисел массива, которые стоят на нечетных местах и при этом превосходят сумму крайних элементов массива.

int[] arr = new int[10];
Random rnd = new Random();
int sum = 0;


for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 20);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
    if (i % 2 != 0 && arr[i] > arr[0] + arr[arr.Length - 1] && i != 0)
        sum += arr[i];
}
Console.WriteLine();
Console.WriteLine($"Sum = {sum}");