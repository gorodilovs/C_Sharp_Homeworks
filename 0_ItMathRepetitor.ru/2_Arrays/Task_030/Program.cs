// Дан массив x из n элементов. Найдите (x_1 * x_n) + (x_2 * x_{n-1}) + ... + (x_n * x_1).

int n = 4;
int[] x = new int[n];
Random rnd = new Random();
int sum = 0;


for (int i = 0; i < x.Length; i++)
{
    x[i] = rnd.Next(1, 4);
}

for (int i = 0; i < x.Length; i++)
{
    Console.Write(x[i] + " ");

    sum += x[i] * x[x.Length - 1 - i];

}
Console.WriteLine();
Console.WriteLine($"Sum = {sum}");