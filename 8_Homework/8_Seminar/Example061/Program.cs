// Задача 61: Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника.

int n = 8;
int[,] arr = new int[n + 1, n * 2 + 1];

void PrintArray(int[,] arr, int symmetry)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] != 0)
                System.Console.Write($"{arr[i, j].ToString($"D{1}"), 5}");
            if (arr[i, j] == 0)
                System.Console.Write($"{" ", 5}");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int max = 0;
arr[0, n] = 1;
for (int i = 1; i < arr.GetLength(0); i++)
{
    arr[i, n - i] = 1;
    arr[i, arr.GetLength(1) - 1 - n + i] = 1;
    for (int j = n - i + 1; j < arr.GetLength(1) - 1 - n + i; j++)
    {

            arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j + 1];
            if (arr[i, j] > max)
                max = arr[i, j];
    }
}

// int toSymmetry = 0;
int toSymmetry = max.ToString().Length;
System.Console.WriteLine(toSymmetry);

PrintArray(arr, toSymmetry);