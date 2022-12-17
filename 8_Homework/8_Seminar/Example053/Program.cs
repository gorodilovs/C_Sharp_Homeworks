// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

int[,] arr = new int[5, 6];
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

// Initializing

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rnd.Next(1, 100);
    }
}

System.Console.WriteLine("Original array: ");
PrintArray(arr);

// Swapping

int temp;
for (int i = 0; i < arr.GetLength(1); i++)
{
    temp = arr[0, i];
    arr[0, i] = arr[arr.GetLength(0) - 1, i];
    arr[arr.GetLength(0) - 1, i] = temp;
}

System.Console.WriteLine("Swapped array: ");
PrintArray(arr);