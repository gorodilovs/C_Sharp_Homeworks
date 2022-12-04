// Найти количество четных чисел в массиве.

int[] arr = new int[10];
Random rnd = new Random();
int count = 0;


for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 10);
    if (arr[i] % 2 == 0 && arr[i] != 0)
        count++;
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
Console.WriteLine(count);