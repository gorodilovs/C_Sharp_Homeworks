// Найдите наименьший четный элемент массива.

int n = 30;
int[] arr = new int[n];
Random rnd = new Random();
int min = 0;
int index = -1;
bool minFound = false;


for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 100);
}


for (int i = 0; i < arr.Length; i++)
{
    if (minFound == false)
    {
        if (arr[i] % 2 == 0)
        {
            min = arr[i];
            minFound = true;
        }
    }
    if (minFound == true)
    {
        if (min > arr[i] && arr[i] % 2 == 0)
        {
            min = arr[i];
            index = i;
        }
    }
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}

Console.WriteLine();

if (minFound)
    Console.WriteLine($"Minimal element is: {min} Index: {index}");
else
    Console.WriteLine($"Minimal element is missing!");