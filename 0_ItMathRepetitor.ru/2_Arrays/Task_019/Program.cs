// Определить, содержит ли массив данное число x

int[] arr = new int[20];
Random rnd = new Random();
int x = 8;
bool cont = false;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 10);
    if (arr[i] == x)
        cont = true;
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

if (cont)
    Console.WriteLine("Yes!");
else
    Console.WriteLine("No!");