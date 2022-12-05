// Проверьте, образуют ли элементы массива в данном порядке арифметическую или геометрическую прогрессии.

int[] arr = new int[10];
Random rnd = new Random();
bool arif = false;
bool geom = false;
arr[0] = 1;

for (int i = 1; i < arr.Length; i++)
{
    //arr[i] = rnd.Next(1, 10);
    //arr[i] = arr[i - 1] + 2; // Arif
    arr[i] = arr[i - 1] * 2; //Geom

}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}


for (int i = 1; i < arr.Length - 1; i++)
{
    if(arr[i] - arr[i - 1] == arr[i + 1] - arr[i])
        arif = true;
    else
    {
        arif = false;
        i = arr.Length;
    }
}

for (int i = 1; i < arr.Length - 1; i++)
{
    if(arr[i] / arr[i - 1] == arr[i + 1] / arr[i])
        geom = true;
    else
    {
        geom = false;
        i = arr.Length;
    }
}

Console.WriteLine();
if(arif)
    Console.WriteLine("This is arif progression!");
else
    Console.WriteLine("This is not arif progression!");

if(geom)
    Console.WriteLine("This is geom progression!");
else
    Console.WriteLine("This is not geom progression!");  