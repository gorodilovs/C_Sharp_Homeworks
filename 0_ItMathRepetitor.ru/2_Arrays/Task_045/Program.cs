// Найдите количество различных элементов данного массива.

int[] arr = new int[20];
Random rnd = new Random();
int unique = 0;
bool same = false;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 10);
    Console.Write(arr[i] + " ");
}

Console.WriteLine();

for (int i = 0; i < arr.Length; i++)
{

    same = false;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[i] == arr[j] && i != j)
        {
            j = arr.Length;
            same = true;
        }            
    }
    if (!same)
    {
        unique++;
        Console.WriteLine($"Number {arr[i]} with index {i} is unique!");
    }
}