// В данном массиве найдите количество чисел, соседи у которых отличаются более чем в 2 раза

int n = 20;
int[] arr = new int[n];
Random rnd = new Random();
int counter = 0;

for(int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 10);
}


for(int i = 1; i < arr.Length - 1; i++)
{
    if(arr[i - 1] > arr[i + 1] * 2 || arr[i - 1] * 2 < arr[i + 1])
    {
        counter++;
        Console.WriteLine($"Index of matched item: {i}");
    }
}

for(int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

Console.WriteLine($"Answer is: {counter}");