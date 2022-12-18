// Даны два упорядоченных по возрастанию массива. Образовать из
// этих двух массивов единый упорядоченный по возрастанию массив.

int[] arr1 = new int[] {1, 2, 3, 4, 5, 6, 7, 8 ,9, 10, 11};
int[] arr2 = new int[] {1, 2, 2, 3, 6, 7, 8, 9, 10};
int[] arr3 = new int[arr1.Length + arr2.Length];

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}

PrintArray(arr1);
PrintArray(arr2);

for (int i = 0; i < arr3.Length; i++)
{
    if (i < arr1.Length)
        arr3[i] = arr1[i];
    else
        arr3[i] = arr2[i - arr1.Length];
}

PrintArray(arr3);

int min;
int minIndex = 0;
int temp;
for (int i = 0; i < arr3.Length; i++)
{
    min = arr3[i];
    minIndex = i;
    for (int j = i; j < arr3.Length; j++)
    {
        if (arr3[j] < min)
        {
            min = arr3[j];
            minIndex = j;
        }
    }   

    temp = arr3[minIndex];
    arr3[minIndex] = arr3[i];
    arr3[i] = temp;
}

PrintArray(arr3);