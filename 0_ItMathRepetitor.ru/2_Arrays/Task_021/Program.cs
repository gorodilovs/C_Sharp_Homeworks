// Найти количество чисел в массиве, которые делятся на 3, но не делятся на 7.

int[] arr = new int[100];
Random rnd = new Random();
int count = 0;


for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 100);
    if (arr[i] % 3 == 0 && arr[i] % 7 != 0)
        count++;
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
Console.WriteLine(count);