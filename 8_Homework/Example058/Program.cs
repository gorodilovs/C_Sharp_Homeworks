// Задайте две матрицы. Напишите программу, которая
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Предположим что вводимые матрицы имеют размерность доступную к умножению,
// т.е. arr1[m, n] и arr2[n, k]

int[,] arr1 = new int[5, 3];
int[,] arr2 = new int[3, 5];
int[,] arr3 = new int[arr1.GetLength(0), arr2.GetLength(1)];
Random rnd = new Random();

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 4);
        }
    }
}

System.Console.WriteLine("First array: ");
FillArray(arr1);
PrintArray(arr1);

System.Console.WriteLine("Second array: ");
FillArray(arr2);
PrintArray(arr2);

for (int i = 0; i < arr3.GetLength(0); i++)
{
    for (int j = 0; j < arr3.GetLength(1); j++)
    {
        for (int k = 0; k < arr1.GetLength(1); k++)
        {
            arr3[i, j] += arr1[i, k] * arr2[k, j];
        }
    }
}
PrintArray(arr3);