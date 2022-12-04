// Найдите сумму и произведение элементов массива.

int[] arr = new int[10];
Random rnd = new Random();
int sum = 0;
int product = 1;


for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 10);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
    sum += arr[i];
    product *= arr[i];
}
Console.WriteLine();
Console.WriteLine($" Sum = {sum}, Product = {product}");
