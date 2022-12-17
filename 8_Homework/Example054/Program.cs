// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// Sorting

int temp;
int maxIndex;
int counter;

for (int i = 0; i < arr.GetLength(0); i++)
{    
    counter = 0;
    
    for (int j = 0; j < arr.GetLength(1); j++)
    {   
        maxIndex = counter;
        for (int k = counter; k < arr.GetLength(1); k++)
        {
            if (arr[i, k] >= arr[i, maxIndex])
            {
                maxIndex = k;
            }
        }

        temp = arr[i, j];
        arr[i, j] = arr[i, maxIndex];
        arr[i, maxIndex] = temp;

        counter++;
    }
}

System.Console.WriteLine("Sorted array: ");
PrintArray(arr);
