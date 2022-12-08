// Удалить (заменить или удалить ячейки???) в массиве все числа,
// которые повторяются более двух раз.

int capacity = 20;
int[] arr = new int[capacity];
int[] delete =  new int[arr.Length];
Random rnd = new Random();
int counter1 = 0;
int counter2 = 0;


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


for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[i] == arr[j] && i != j)
            delete[i] = 1;
    }
}

foreach (int n in delete)
{
    if (n == 1)
        counter2++;
}

System.Console.WriteLine("Original array: ");
PrintArray(arr);
System.Console.WriteLine("Array to delete");
PrintArray(delete);

for (int i = 0; i < arr.Length - 1 - counter1; i++)
{
    if (delete[i] == 1)
    {
        for (int j = i; j < arr.Length - 1 - counter1; j++)
        {
            arr[j] = arr[j + 1];
            delete[j] = delete[j + 1];
        }
        i--;
        counter1++;
    }    
}

if (counter2 == arr.Length)
    System.Console.WriteLine("All numbers in the array repeat itself!");
else
{
    Array.Resize(ref arr, arr.Length -  counter2);
    Array.Resize(ref delete, delete.Length -  counter2);
    System.Console.WriteLine("Resized array with unique numbers: ");
    PrintArray(arr);
}

