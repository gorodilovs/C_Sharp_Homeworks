// Дан массив. Заменить все числа, меньшие последнего элемента
// массива, на первый элемент.


int capacity = 30;
int[] arr = new int[capacity];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 20);
}


Console.WriteLine("Original array: ");
foreach (int n in arr)
{
    Console.Write(n + " ");
}
Console.WriteLine();


for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > arr[arr.Length - 1])
        arr[i] = arr[0];
}


Console.WriteLine("Replaced array: ");
foreach (int n in arr)
{
    Console.Write(n + " ");
}
Console.WriteLine();
