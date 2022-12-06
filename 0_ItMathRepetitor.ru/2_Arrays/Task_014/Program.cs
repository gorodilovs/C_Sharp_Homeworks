// Заполните массив случайным образом нулями и единицами так, чтобы количество единиц было больше количества нулей.

int[] array = new int[20];
Random rnd = new Random();
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0, 2);
    if (array[i] == 1)
        count++;
    if (i > 1 && count < (2 + i/2))
    {
        array[i] = 1;
        count++; 
    }      
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.Write(count);
