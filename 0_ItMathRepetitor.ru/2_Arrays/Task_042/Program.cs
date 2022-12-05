// Проверьте, содержит ли данный массив из n чисел, все числа от 1 до n.

int n = 10;
int[] arr = new int[n];
Random rnd = new Random();
bool yes;


for(int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 11);
}


for(int i = 0; i < arr.Length; i++)
{
    yes = false;
    for(int j = 0; j < arr.Length; j++)
    {
        if(arr[j] == i + 1)
        {
            yes = true;
            j = arr.Length;
        }                   
    }
    if(!yes)
    {
        Console.WriteLine($"Element {i + 1} is missing");
        yes = false;
    }
}

for(int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}

Console.WriteLine();
Console.WriteLine($"");