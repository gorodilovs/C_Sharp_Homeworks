// Определите, можно ли вычеркнуть из данного массива одно число так, 
// чтобы оставшиеся числа оказались упорядоченными по возрастанию.

int[] arr = new int[] { 0, 1, 2, 3, 4, 0, 5, 6, 7, 8, 9};
int[] newArr = new int[arr.Length - 1];
int counter = 0;
int index = 0;

for (int i = 0; i < arr.Length - 1; i++)
{
    if (arr[i] >= arr[i + 1] && i == 0)
    {
        counter++;
        index = i;
    }

    if (arr[i] >= arr[i + 1] && i != 0)
    {
        counter++;
        index = i + 1;
    }
}



Console.WriteLine("Original array: ");
foreach (int n in arr)
{
    Console.Write(n + " ");
}
Console.WriteLine();


if (counter == 1)
{
    Console.WriteLine($"Yes, if we delete number {arr[index]} with index {index} the array will be strictly raising.");
    for (int i = 0; i < newArr.Length; i++)
    {
        if (i >= index)
        {
            newArr[i] = arr[i + 1];
        }
        else
            newArr[i] = arr[i]; 
    }

    Console.WriteLine("New array: ");
    foreach (int n in newArr)
    {
        Console.Write(n + " ");
    }
    Console.WriteLine();
}
else
    Console.WriteLine("No, there are no such numbers to delete to make raising array.");


