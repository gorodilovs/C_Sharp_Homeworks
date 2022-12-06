// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.

int[] arr = new int[10];
Random rnd = new Random();
int reference = 5;
bool isTrue = false;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-10, 10);
    if (arr[i] == reference)
        isTrue = true;
}

foreach (int n in arr)
{
    Console.Write(n + " ");
}
Console.WriteLine();

if (isTrue)
    Console.WriteLine($"Reference number {reference} is in the array.");
else
    Console.WriteLine($"Reference number {reference} is not in the array.");