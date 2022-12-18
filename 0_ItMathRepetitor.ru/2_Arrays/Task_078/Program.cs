// В данном массиве каждый элемент равен 0, 1  или 2.
// Переставить элементы массива так, чтобы сначала располагались
// все нули, затем все единицы и, наконец, все двойки.
// Дополнительный массив не использовать.


int[] arr = new int[20];
Random rnd = new Random();

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 3);
    }
}

FillArray(arr);

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("Original array: ");
PrintArray(arr);

int temp;
for (int i = 0; i < arr.Length - 1; i++)
{
    if (arr[i] != 0)
    {
        for (int j = i; j < arr.Length; j++)
        {
            if (arr[j] == 0)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    if (arr[i] != 1 && arr[i] != 0)
    {
        for (int j = i; j < arr.Length; j++)
        {
            if (arr[j] == 1)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}
System.Console.WriteLine("Sorted array: ");
PrintArray(arr);