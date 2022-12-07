// В массиве найдите количество серий из четверок подряд идущих попарно различных элементов.

int capacity = 30;
int[] arr = new int[capacity]; // {0, 1, 2, 3, 3, 2, 1, 0, 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 2, 1};
int[] matched = new int[arr.Length]; // First index of matched sequences
Random rnd = new Random();
int counter1 = 0; //Counter of 4
int counter2 = 0; //Counter of matched sequences

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 10);
}

for (int i = 0; i < arr.Length - 4; i++)
{
    counter1 = 0;
    for (int j = i; j < i + 3; j++)
    {   
        counter1++;
        if (arr[j] == arr[j + 1])
        {
            j = i + 3;
            counter1 = 0;
        }
        if (j == i + 2)
        {
            matched[counter2] = i;
            counter2++;
        }
    }
}


Console.WriteLine("Original array: ");
foreach (int n in arr)
{
    Console.Write(n + " ");
}
Console.WriteLine();

Console.WriteLine("Matched sequence array for first indexes: ");
foreach (int n in matched)
{
    Console.Write(n + " ");
}
Console.WriteLine();

if (counter2 == 0)
    Console.WriteLine("There are none of matched sequences!");
else
{
    for (int i = 0; i < counter2; i++)
    {
        Console.WriteLine($"Matched sequence {i + 1} starts form index {matched[i]}: ");
        for (int j = matched[i]; j < matched[i] + 4; j++)
        {
            Console.Write($"{arr[j]} ");
        }
        Console.WriteLine();
    }
}
