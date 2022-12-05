// Дан массив x из n элементов. Найдите x_n * (x_n + x_n−1) * (x_n + x_n−1 + x_n−2) … (x_n + … + x_1).

int n = 5;
int temp = 0;
int result = 1;
int[] x = new int[n];
Random rnd = new Random();

for (int i = 0; i < x.Length; i++)
{
    x[i] = rnd.Next(1, 3);
}

for (int i = 0; i < x.Length; i++)
{
    temp += x[x.Length - 1 - i];
    result *= temp;
}

for (int i = 0; i < x.Length; i++)
{
    Console.Write(x[i] + " ");
}

Console.WriteLine();
Console.WriteLine($"Result = {result}");