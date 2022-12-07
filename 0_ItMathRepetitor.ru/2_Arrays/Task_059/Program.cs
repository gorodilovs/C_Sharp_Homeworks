// Найти наибольший четный элемент массива и поменять его 
// местами с наименьшим нечетным элементом. (??Если одного из
// таких элементов нет??), Если четный меньше нечетного, то всем элементам массива присвоить
// значение, равное нулю?? 

int capacity = 30;
int[] arr = new int[capacity];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 10);
}


Console.WriteLine("Original array: ");
foreach (int n in arr)
{
    Console.Write(n + " ");
}
Console.WriteLine();

int max = arr[0];
int min = arr[0];
int indexMax = 0;
int indexMin = 0;
int temp = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < min && arr[i] % 2 != 0)
    {
        min = arr[i];
        indexMin = i;
    }

    if (arr[i] > max && arr[i] % 2 == 0)
    {
        max = arr[i];
        indexMax = i;
    }
}

Console.WriteLine($"Max is {max} with index {indexMax}.");
Console.WriteLine($"Min is {min} with index {indexMin}.");

if (max > min)
{
    temp = arr[indexMin];
    arr[indexMin] = arr[indexMax];
    arr[indexMax] = temp;
}
else
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = 0;
    }
}

Console.WriteLine("Replaced array: ");
foreach (int n in arr)
{
    Console.Write(n + " ");
}
Console.WriteLine();
