// Найдите количество элементов массива, которые отличны от наибольшего(ых) элемента не более чем на 10%.

int n = 30;
double[] arr = new double[n];
Random rnd = new Random();
int counter = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 100);
}

double max = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
    if (arr[i] > max)
        max = arr[i];
}

for (int i = 0; i < arr.Length; i++)
{
    
    if(arr[i] <= (max*110)/100 && arr[i] >= (max*90)/100 && arr[i] != max)
    {
        counter++;
        Console.Write("!!!");
    }

    Console.Write(arr[i] + " ");
}
Console.WriteLine();
Console.WriteLine($"Max is: {max}, Range is from {(max*90)/100} to {(max*110)/100}");
Console.WriteLine($"Result is: {counter}");