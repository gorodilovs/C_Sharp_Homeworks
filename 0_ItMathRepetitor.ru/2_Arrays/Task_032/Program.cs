// Найти наибольший?? е?? элемент (номер элемента и значение) массива.

int n = 10;
int[] x = new int[n];
int[] y = new int[n];
Random rnd = new Random();

for (int i = 0; i < x.Length; i++)
{
    x[i] = rnd.Next(1, 10);
}

int max = 0;
for (int i = 0; i < x.Length; i++)
{
    if (x[i] > max)
    {
        max = x[i];
    }
}

for (int i = 0; i < x.Length; i++)
{
    Console.Write(x[i] + " ");
    if (x[i] == max)
        //Console.Write("- Max ");
        y[i] = 1;
}

Console.WriteLine();

for (int i = 0; i < y.Length; i++)
{
    if (y[i] == 1)
        Console.WriteLine($"Index of max items: {i}");
}

Console.WriteLine($"Max = {max}");