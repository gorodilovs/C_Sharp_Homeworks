// В данном массиве найти все нулевые элементы и
// заменить их вместе с соседними элементами на 3.

int capacity = 20;
int[] arr = new int[capacity];
int[] replace = new int[arr.Length];
Random rnd = new Random();

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
    arr[i] = rnd.Next(0, 10);
}

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == 0)
        replace[i] = 1;
    else
        replace[i] = 0;
}

System.Console.WriteLine("Original array: ");
PrintArray(arr);

for (int i = 0; i < replace.Length; i++)
{
    if (replace[i] == 1)
    {
        if (i == 0)
        {
            arr[i] = 3;
            arr[i + 1] = 3;
        }
        else if (i == replace.Length - 1)
        {
            arr[i] = 3;
            arr[i - 1] = 3;
        }
        else 
        {
            arr[i - 1] = 3;
            arr[i] = 3;
            arr[i + 1] = 3;
        }
    }
}

System.Console.WriteLine("Replaced array: ");
PrintArray(arr);