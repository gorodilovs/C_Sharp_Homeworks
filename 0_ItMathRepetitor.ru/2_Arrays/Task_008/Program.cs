//Заполнить массив заданной длины различными простыми числами. Натуральное число, большее единицы, называется простым, если оно делится только на себя и на единицу.

int[] array = new int[200];
int n = 1;
int j;
array[0] = n;

for (int i = 1; i < array.Length; i++)
{
    n++;
    for (j = 2; j <= n; j++)
    {
        if (n % j == 0 &&  n == j)
        {
            array[i] = n;
        }

        else if (n % j == 0 &&  n != j)
        {
            n++;
            j = 1;
        }
    }
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
