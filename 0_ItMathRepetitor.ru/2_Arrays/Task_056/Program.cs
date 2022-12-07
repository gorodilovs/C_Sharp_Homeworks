// В массиве заменить все числа, большие данного числа,
// на среднее арифметическое всех чисел массива.

int replace = 5;
int capacity = 30;
int[] arr = new int[capacity];
Random rnd = new Random();
int sum = 0;
int arith = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 20);
    sum += arr[i];
}

arith = sum/capacity;
Console.WriteLine($"Arithmetic mean is {arith}");

Console.WriteLine("Original array: ");
foreach (int n in arr)
{
    Console.Write(n + " ");
}
Console.WriteLine();

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > replace)
        arr[i] = arith;
}

Console.WriteLine("Replaced array: ");
foreach (int n in arr)
{
    Console.Write(n + " ");
}
Console.WriteLine();

