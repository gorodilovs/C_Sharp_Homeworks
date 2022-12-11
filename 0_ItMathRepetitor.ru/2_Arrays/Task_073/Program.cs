// Дан массив, в котором количество отрицательных элементов
// равно количеству положительных. Поменяйте местами первый
// отрицательный и первый положительный, второй отрицательный
// и второй положительный и так далее.

int capacity = 10;
int[] arr = new int[capacity];
Random rnd = new Random();

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

System.Console.WriteLine("Original array:");
PrintArray(arr);


int counter = 0;
int index = 0;

while (counter <= (arr.Length - 1)/2)
{
    index = rnd.Next(0, arr.Length);
    if (arr[index] > 0)
    {
        arr[index] = -arr[index];
        counter++;
    }
}

System.Console.WriteLine("Original array with half negative numbers:");
PrintArray(arr);

counter = 0;
int temp;
int[] arrSwaped = new int[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0)
    {
        for (int j = counter; j < arr.Length; j++)
        {
            if(arr[j] >= 0)
            {
                arrSwaped[i] = arr[j];
                arrSwaped[j] = arr[i];
                j = arr.Length;
            }
            counter++;
        }
    }
}

System.Console.WriteLine("Swapped array:");
PrintArray(arrSwaped);