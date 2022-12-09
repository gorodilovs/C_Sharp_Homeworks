// Удалить в массиве все наибольшие элементы. (В массиве присутсвуют все числа диапазона)

int capacity = 20;
int[] arr = new int[capacity];
int[] delete =  new int[arr.Length];
Random rnd = new Random();
int counter = 0;

void PrintArray(int[] a)
{
foreach (int n in a)
{
    System.Console.Write(n + " ");
}
System.Console.WriteLine();
}

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 10);
}

int max = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
        max = arr[i];
}

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == max)
        delete[i] = 1;
    else
        delete[i] = 0;
}

System.Console.WriteLine("Original array: ");
PrintArray(arr);

System.Console.WriteLine("Array to delete: ");
PrintArray(delete);

System.Console.WriteLine("Max number is: " + max);

for (int i = 0; i < arr.Length; i++)
{
    if (delete[i] == 1)
    {
        for (int j = i; j < arr.Length - 1; j++)
        {
            arr[j] = arr[j + 1];
            delete[j] = delete[j + 1];                    
        }
        arr[arr.Length - 1 - counter] = 0;
        delete[delete.Length - 1 - counter] = 0;
        counter++; 
        i--;
    }
}

System.Console.WriteLine("Counter: " + counter);

System.Console.WriteLine("Modified array: ");
Array.Resize(ref arr, arr.Length - counter);
PrintArray(arr);
