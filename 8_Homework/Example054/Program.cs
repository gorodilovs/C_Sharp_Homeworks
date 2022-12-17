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
        arr[i, j] = rnd.Next(1, 10);
    }
}

System.Console.WriteLine("Original array: ");
PrintArray(arr);

// Sorting

int temp;
int max;
int counter;

for (int i = 0; i < arr.GetLength(0); i++)
{
    max = arr[i, 0];
    counter = 0;
    
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (arr[i, j] >= max)
        {
            arr[i, j] = max;
        }        
    }

}
