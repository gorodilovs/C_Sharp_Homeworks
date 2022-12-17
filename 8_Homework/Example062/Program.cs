// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] arr = new int[8, 8];

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j].ToString("D2") + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void FillArray(int[,] arr)
{
    int value = 1;
    int minusRow = 0;
    int minusColumn = 0;

    while(minusRow <= (arr.GetLength(0)-1)/2 && minusColumn <= (arr.GetLength(1)-1)/2)
    {
        for (int i = minusRow; i <= arr.GetLength(1) - 1 - minusColumn; i++)
        {
            arr[minusRow, i] = value;
            value++;
        }

        for (int i = minusRow + 1; i <= arr.GetLength(0) - 1 - minusColumn; i++)
        {
            arr[i, arr.GetLength(1) - 1 - minusColumn] = value;
            value++;
        }

        for (int i = arr.GetLength(1) - 1 - minusColumn - 1; i >= 0 + minusColumn; i--)
        {
            arr[arr.GetLength(0) - 1 - minusRow, i] = value;
            value++;
        }
        minusRow++;

        for (int i = arr.GetLength(0) - 1 - minusRow; i >= 0 + minusRow; i--)
        {
            arr[i, minusColumn] = value;
            value++;
        }
        minusColumn++;
    }
    
}

FillArray(arr);
PrintArray(arr);