// Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.

void FillAndPrintArray(int[,] arr)
{
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 100);
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] arr = new int[10, 10];
double arithMean = 0;

FillAndPrintArray(arr);

for (int i = 0; i < arr.GetLength(1); i++)
{
    arithMean = 0;
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        arithMean += arr[j, i];
    }
    arithMean = arithMean / arr.GetLength(1);
    arithMean = Math.Round(arithMean, 1);
    System.Console.WriteLine($"Arithmetic mean of {i} column is: {arithMean}");
}