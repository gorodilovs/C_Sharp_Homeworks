//Создать массив, на четных местах в котором стоят единицы, а на нечетных местах - числа, равные остатку от деления своего номера на 5.

int[] array = new int[20];

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 0)
        array[i] = 1;
    else
        array[i] = i % 5;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}