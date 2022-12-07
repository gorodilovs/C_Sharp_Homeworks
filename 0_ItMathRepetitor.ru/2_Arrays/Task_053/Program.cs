// В данном массиве найдите наибольшую серию подряд идущих 
// элементов, расположенных по возрастанию.

int capasity = 20;
int[] arr = new int[capasity]; // {0, 1, 2, 3, 4, 0, 1, 2, 3, 4, 0, 1, 2, 3, 4, 0, 1, 2, 3, 4};
int[] result = new int[capasity];
Random rnd = new Random();
int indexTemp = 0;
int indexResult = 0;
int counterTemp = 1;
int counterResult = 0;
int answers = 0;


for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 10);
}


for (int i = 0; i < arr.Length - 1; i++)
{
    if (arr[i] < arr[i + 1])
    {
        indexTemp = i + 1;
        counterTemp++;
    }
    else if (arr[i] >= arr[i + 1])
    {
        if (counterTemp > counterResult)
        {
            indexResult = indexTemp;
            counterResult = counterTemp;
        }
        counterTemp = 1;
    }
}


counterTemp = 1;
for (int i = 0; i < arr.Length - 1; i++)
{
    if (arr[i] < arr[i + 1])
    {
        counterTemp++;
    }

    if (arr[i] >= arr[i + 1])
    {
        counterTemp = 1;
    }

    if (counterResult == counterTemp && counterTemp != 1)
    {
        result[answers] = i + 1;
        answers++;
    }
}
Console.WriteLine($"Counter of max rasing {counterResult}");


foreach (int n in arr)
{
    Console.Write(n + " ");
}
Console.WriteLine();


foreach (int n in result)
{
    Console.Write(n + " ");
}
Console.WriteLine();
Console.WriteLine();


if (answers == 0)
{
    Console.WriteLine("There is not any raising sequence.");
}
else
{
    for (int i = 0; i < answers; i++)
    {
        Console.WriteLine($"Last index of raising sequence: {result[i]}");
        Console.WriteLine($"Raising sequence: "); 
        for(int j = 0; j < counterResult; j++)
        {
            Console.Write($"{arr[result[i] - counterResult + 1 + j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();