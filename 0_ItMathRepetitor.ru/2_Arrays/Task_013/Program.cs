// Сформировать массив из случайных чисел, в которых ровно
// две единицы, стоящие на случайных позициях.

int[] array = new int[20];
int count1 = 2;
Random rnd = new Random();

for (int i = 0; i < count1; i++)
{
    array[rnd.Next(0, array.Length-1)] = 1;
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] != 1)
        array[i] = rnd.Next(2, 10);
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
