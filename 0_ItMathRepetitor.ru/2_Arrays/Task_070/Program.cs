// Дан массив. Осуществите циклический сдвиг массив на k единиц
// вправо, если первый наименьший элемент массива расположен
// раньше последнего наибольшего элемента массива, и влево,
// если иначе.

int capacity = 20;
Random rnd = new Random();
int[] arr = new int[capacity];


void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write(item + " ");
    }
    System.Console.WriteLine();
}

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 10);
}

int firstMin = arr[0];
int firstMinIndex = 0;
int lastMax = arr[0];
int lastMaxIndex = 0;

for (int i = arr.Length - 1; i > 0; i--)
{
    if (arr[i] <= firstMin)
    {
        firstMin = arr[i];
        firstMinIndex = i;
    }
}

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] >= lastMax)
    {
        lastMax = arr[i];
        lastMaxIndex = i;
    }
}

System.Console.WriteLine("Original array: ");
PrintArray(arr);

int k = 5; // Array shift
int temp1 = 0;

if (firstMin == lastMax)
    System.Console.WriteLine("All elements the same.");

else if (firstMinIndex < lastMaxIndex)
{
    Console.WriteLine($"Array will be shifted to right {k} times.");
    for (int i = 0; i < k; i++)
    {
        temp1 = arr[arr.Length - 1];
        for (int j = arr.Length - 2; j >= 0; j--)
        {
            arr[j + 1] = arr[j];
        }
        arr[0] = temp1;
    }
}

else if (firstMinIndex > lastMaxIndex)
{
    Console.WriteLine($"Array will be shifted to left {k} times.");
    for (int i = 0; i < k; i++)
    {
        temp1 = arr[0];
        for (int j = 0; j <= arr.Length - 2 ; j++)
        {            
            arr[j] = arr[j + 1];           
        }
        arr[arr.Length - 1] = temp1;
    }
}


System.Console.WriteLine("Shifted array: ");
PrintArray(arr);