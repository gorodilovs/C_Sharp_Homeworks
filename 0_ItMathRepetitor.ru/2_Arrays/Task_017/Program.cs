// Заполните массив случайным образом нулями, единицами и двойками так, 
// чтобы первая двойка в массиве встречалась раньше первой единицы, 
// количество единиц было в точности равно суммарному количеству нулей и двоек.

int[] arr = new int[20];
Random rnd = new Random();
int count0 = 0;
int count1 = 1;
int count2 = 2;
 
while(!(count1 == count0 + count2))
{
    count0 = 0; count1 = 0; count2 = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 3);

        if (arr[i] == 0)
            count0++;
        if (arr[i] == 1)
            count1++;
        if (arr[i] == 2)
            count2++;
    }

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == 1)
        {
            arr[i] = 2;
            count1--;
            count2++;
            i = arr.Length;
        }
    }
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine($"!!! {count0} {count1} {count2} ");
}