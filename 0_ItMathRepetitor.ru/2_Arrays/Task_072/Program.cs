// Дана упорядоченная последовательность an чисел от 1 до N.
// Из копии данной последовательности bn удалили одно число,
// а оставшиеся перемешали. Найти удаленное число.
// Без сортировки массива Bn.

int capacity = 10;
int[] arrOriginal = new int[capacity];
Random rnd = new Random();

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write(item + " ");
    }
    System.Console.WriteLine();
}

for (int i = 0; i < arrOriginal.Length; i++)
{
    arrOriginal[i] = rnd.Next(0, 30);
}

System.Console.WriteLine("Original array: ");
PrintArray(arrOriginal);

Array.Sort(arrOriginal);

System.Console.WriteLine("Sorted original array: ");
PrintArray(arrOriginal);


int temp = rnd.Next(0, arrOriginal.Length);
int[] arrModified = new int[arrOriginal.Length - 1];

for (int i = 0; i < arrModified.Length; i++)
{
    if (i >= temp)
        arrModified[i] = arrOriginal[i + 1];
    else
        arrModified[i] = arrOriginal[i];
}

System.Console.WriteLine("Modified array: ");
PrintArray(arrModified);

// Fisher–Yates shuffle!
for (int i = arrModified.Length - 1; i >= 1; i--)
{
    int j = rnd.Next(i + 1);

    int tmp = arrModified[j];
    arrModified[j] = arrModified[i];
    arrModified[i] = tmp;
}

System.Console.WriteLine("Modified shuffled array:");
PrintArray(arrModified);

int[] unique = new int[arrOriginal.Length];
unique = arrOriginal;

for (int i = 0; i < arrModified.Length; i++)
{
    for (int j = 0; j < unique.Length; j++)
    {
        if (arrModified[i] == unique[j])
        {
            for (int k = j; k < unique.Length - 1; k++)
            {
                unique[k] = unique[k + 1];
            }
            Array.Resize(ref unique, unique.Length - 1);
            j = unique.Length;
        }
    }
}

System.Console.WriteLine("Deleted numbers are: ");
PrintArray(unique);