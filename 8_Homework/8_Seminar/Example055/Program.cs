// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для пользователя.

int[,] arr = new int[5, 5];
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

int[,] arrNew = new int[arr.GetLength(0), arr.GetLength(1)];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arrNew[i, j] = arr[j, i];
    }
}

System.Console.WriteLine("Swapped array: ");
PrintArray(arrNew);