// Задача 39: Напишите программу, которая перевернет одномерный
// массив (последний элемент будет на первом месте, а первый -
// на последнем и т.д.)

int capacity = 20;
int[] arr = new int[capacity];
Random rnd = new Random();
int temp;

void PrintArray(int[] arrPrint)
{
    foreach (int n in arrPrint)
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

for (int i = 0; i < arr.Length / 2; i++)
{
    temp = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = temp;
}

System.Console.WriteLine("Inverted array: ");
PrintArray(arr);