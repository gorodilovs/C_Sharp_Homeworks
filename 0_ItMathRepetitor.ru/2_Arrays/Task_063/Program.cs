// Найти в массиве все серии подряд идущих одинаковых элементов
// и удалить из них все элементы кроме одного.

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

System.Console.WriteLine("Original array: ");
PrintArray(arr);

for (int i = 0; i < arr.Length - 1 - counter; i++)
{
    if (arr[i] == arr[i + 1])
    {
        for(int j = i; j < arr.Length - 1 - counter; j++)
        {
            arr[j] = arr[j + 1];
        }
        counter++;
        i--;
    }
}

System.Console.WriteLine("Modifyed array: ");
Array.Resize(ref arr, arr.Length - counter);
PrintArray(arr);