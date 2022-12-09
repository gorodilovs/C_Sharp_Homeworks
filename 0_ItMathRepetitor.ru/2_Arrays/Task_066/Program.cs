// Дан массив a из n элементов. Сформировать новый массив b такого
// же размера так, что элемент bk равен сумме элементов первых
// элементов массиваa до номера k включительно.

int n = 20;
int[] a = new int[n];
int[] b = new int[n];
Random rnd = new Random();
int k = n / 2;
int sum = 0;

void PrintArray(int[] a)
{
foreach (int n in a)
{
    System.Console.Write(n + " ");
}
System.Console.WriteLine();
}

for (int i = 0; i < a.Length; i++)
{
    a[i] = rnd.Next(1, 1);
}

System.Console.WriteLine("Original array: ");
PrintArray(a);

for (int i = 0; i < b.Length; i++)
{
    if (i + 1 < k)
    {
        b[i] = a[i];
        sum += a[i];
    }
    else if (i + 1 == k)
    {
        sum += a[i];
        b[i] = sum;
    }
    else
    {
        b[i] = a[i];
    }
}

System.Console.WriteLine("New array with sum: ");
PrintArray(b);