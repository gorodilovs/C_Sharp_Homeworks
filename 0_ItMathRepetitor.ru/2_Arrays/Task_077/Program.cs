// Дан массив из n элементов. Переставьте его элементы
// случайным образом.

int[] arr = new int[10];
Random rnd = new Random();

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 10);
    }
}

FillArray(arr);

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}

System.Console.WriteLine("Original array: ");
PrintArray(arr);

// Fisher-Yates

int temp;
int randomIndex;
for (int i = 0; i < arr.Length - 1; i++)
{
    randomIndex = rnd.Next(i + 1, arr.Length - 1);
    temp = arr[i];
    arr[i] = arr[randomIndex];
    arr[randomIndex] = temp;
}

System.Console.WriteLine("Shuffled array: ");
PrintArray(arr);