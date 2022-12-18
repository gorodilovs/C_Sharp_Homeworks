// Осуществить поиск данного числа в упорядоченном по
// возрастанию массиве методом бинарного поиска.

int target = 5;
int[] arr = new int[] {1, 1, 1, 1, 2, 2, 3, 4, 5, 6, 7, 8 ,9, 10, 11};

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}

PrintArray(arr);


// Binary search

int top = arr.Length - 1;
int bot = 0;
int mid;
int targetIndex = 0;

while(bot <= top)
{ 
    mid = (top + bot)/2;

    System.Console.WriteLine(mid);
    if (target == arr[mid])
    {
        targetIndex = mid;
        break;
    }
    if (target > arr[mid])
        bot = mid + 1;
    if (target < arr[mid])
        top = mid - 1;

}
System.Console.WriteLine($"Number {target} found on index {targetIndex}");