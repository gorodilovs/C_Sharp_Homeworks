// Дан массив x из n элементов. Найдите x_1 - x_2 + x_3- ... - x_{n-1} + x_n.

int n = 10;
int[] x = new int[n];
Random rnd = new Random();
int sum = 0;


for (int i = 0; i < x.Length; i++)
{
    x[i] = rnd.Next(1, 10);
}

for (int i = 0; i < x.Length; i++)
{
    Console.Write(x[i] + " ");

    if (i % 2 == 0 || i == 0)
        sum += x[i];
    else if (i % 2 != 0)
        sum -= x[i];
}
Console.WriteLine();
Console.WriteLine($"Sum = {sum}");