// Сформировать массив из случайных целых чисел от 0 до 9 , в котором единиц от 3 до 5 и двоек больше троек.


int[] array = new int[20];
Random rnd = new Random();
int count1 = 0;
int count2 = 0;
int count3 = 0;

while (!(count1 >= 3 && count1 <= 5 && count2 > count3))
{
    count1 = 0;
    count2 = 0;
    count3 = 0;

    for (int i = 0; i < array.Length; i++)
    {
    array[i] = rnd.Next(0, 10);
    if (array[i] == 1)
        count1++;
    if (array[i] == 2)
        count2++;
    if (array[i] == 3)
        count3++;
    }

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

Console.WriteLine($" !!! {count1}, {count2}, {count3}");

}


