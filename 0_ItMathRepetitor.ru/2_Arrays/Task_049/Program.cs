// В одномерном массиве, состоящем из n вещественных элементов, вычислите номер минимального элемента массива и
// сумму элементов массива, расположенных между первым и вторым отрицательными элементами.

int[] arr = new int[20];
Random rnd = new Random();


for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-10, 10);
}


int indexMinimal = 0;
int indexMinFirst = -1;
int indexMinSecond = -1;
int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < arr[indexMinimal])
    {
        indexMinimal = i;        
    }

    if (indexMinFirst >= 0 && indexMinSecond <= 0 && arr[i] < 0)
        indexMinSecond = i;
    if (indexMinFirst <= 0 && arr[i] < 0)
        indexMinFirst = i;

    Console.Write(arr[i] + " ");  
}
Console.WriteLine();

if (indexMinFirst >= 0 && indexMinSecond >=0)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            for (int j = indexMinFirst + 1; j < arr.Length; j++)
            {
                if (arr[j] < 0)
                {
                    indexMinSecond = j;
                    j = arr.Length;
                }
                else
                    sum += arr[j];
            }
            i = arr.Length;
        }
    }
}
else if (indexMinFirst < 0)
    Console.WriteLine("Both numbers with '-' are missing!");
else
    Console.WriteLine("Second number with '-' is missing!");

Console.WriteLine();
Console.WriteLine($"Minial element index is {indexMinimal}. Sum between to first minimals is : {sum}.");
Console.WriteLine($"First negative number index is {indexMinFirst}. Second: {indexMinSecond}");

