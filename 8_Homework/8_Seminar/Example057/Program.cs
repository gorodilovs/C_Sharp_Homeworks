// Задача 57: Составить частотный словарь элементов двумерного
// массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза


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
        arr[i, j] = rnd.Next(1, 10);
    }
}

System.Console.WriteLine("Original array: ");
PrintArray(arr);

int[] dictionaryValue = new int[0];
int[] dictionaryCount = new int[0];
int min = arr[0, 0];
int max = arr[0, 0];
int counterOfOneNum = 0;
int counterOfTotal = 0;
bool foundNum = false;

foreach (int item in arr)
{
    if (item < min)
        min = item;
    if (item > max)
        max = item;
}


for (int k = min; k <= max; k++)
{
    counterOfOneNum = 0;
    foundNum = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (k == arr[i, j])
            {
                counterOfOneNum++;
                foundNum = true;
            }
        }
    }
    if (foundNum)
    {
        counterOfTotal++;
        Array.Resize(ref dictionaryValue, counterOfTotal);
        dictionaryValue[counterOfTotal - 1] = k;
        Array.Resize(ref dictionaryCount, counterOfTotal);
        dictionaryCount[counterOfTotal - 1] = counterOfOneNum;
    }
}

for (int i = 0; i < dictionaryValue.Length; i++)
{
    System.Console.WriteLine($"Number {dictionaryValue[i]} appears {dictionaryCount[i]} times.");
}
