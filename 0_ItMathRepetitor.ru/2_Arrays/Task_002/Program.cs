//Заполнить массив нулями и единицами, при этом данные значения чередуются, начиная с нуля.

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 0)
        array[i] = 0;
    else
        array[i] = 1;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}