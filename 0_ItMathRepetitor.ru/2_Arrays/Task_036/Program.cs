// Среди элементов с нечетными номерами найдите наибольший элемент массива, который делится на 3.

int n = 20;
int[] arr = new int[n];
Random rnd = new Random();
int max = 0;
bool maxFound = false;

for(int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 30);
    if (i % 2 != 0 && arr[i] % 3 == 0)
    {
        max = arr[i];
        maxFound = true;
    }
        
}

for(int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}

Console.WriteLine();
if (maxFound)
    Console.WriteLine($"Max is: {max}");
else
    Console.WriteLine("Max is missing");