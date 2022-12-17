// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] arr = new int[5, 5];
int[,] arrNew = new int[4, 4];
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


// Finding last minimal element

int min = arr[0, 0];
int index1ToDelete = 0;
int index2ToDelete = 0;

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (arr[i, j] < min)
        {
            min = arr[i, j];
            index1ToDelete = i;
            index2ToDelete = j;
        }
    }
}

System.Console.WriteLine($"Minimal is {min}");
// Deleting row and column of last minimal value

for (int i = 0; i < arrNew.GetLength(0); i++)
{
    for (int j = 0; j < arrNew.GetLength(1); j++)
    {
        if (i >= index1ToDelete && j >= index2ToDelete)
        {
            arrNew[i, j] = arr[i + 1, j + 1];
        }
        else if (i >= index1ToDelete && j < index2ToDelete)
            arrNew[i, j] = arr[i + 1, j];
        else if (j >= index2ToDelete && i < index1ToDelete)
            arrNew[i, j] = arr[i, j + 1];
        else
            arrNew[i, j] = arr[i, j];       
    }
}

System.Console.WriteLine("Modified array: ");
PrintArray(arrNew);