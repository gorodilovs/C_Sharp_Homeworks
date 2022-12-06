// Найти наиболее часто встречающийся элемент в массиве целых чисел.

int[] arr = new int[20];
Random rnd = new Random();
int counter = 0;
int matchedNum = 0;
int matches = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 10);
}

for (int i = 0; i < arr.Length; i++)
{
    counter = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[i] == arr[j] && i != j)
            counter++;
    }
    if (counter > matches)
    {
        matches = counter;
        matchedNum = arr[i];
    }
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}

Console.WriteLine();

Console.WriteLine($"Maximum of same elements is {matches}. Number is {matchedNum}. ");