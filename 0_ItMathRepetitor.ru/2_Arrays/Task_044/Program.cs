// Проверьте, является ли данный массив возрастающим или убывающим.

int[] arr = new int[10];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = i;
    //arr[i] = arr.Length - i;
}

bool increase = true;
bool decrease = true;

for (int i = 0; i < arr.Length - 1; i++)
{
    if (arr[i] >= arr[i + 1])
        increase = false;
    if (arr[i] <= arr[i + 1])
        decrease = false;
    Console.Write(arr[i] + " ");
}

Console.WriteLine();
if(increase)
    Console.WriteLine("Array is increasing.");
else
    Console.WriteLine("Array is not increasing.");

if(decrease)
    Console.WriteLine("Array is decreasing.");
else
    Console.WriteLine("Array is not decreasing.");