// Создать массив, состоящий из троек подряд идущих
// одинаковых элементов.

int[] array = new int[20];

for (int i = 0; i < array.Length; i++)
{
    if (i == 0 || i % 3 == 0)
        array[i] = 1;
    else if (i == 1 || (i - 1) % 3 == 0)
        array[i] = 2;
    else
        array[i] = 3;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
