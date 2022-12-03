//Заполнить массив последовательными нечетными числами, начиная с единицы

int[] array = new int[10];
int j = 1;

for (int i = 0; i < array.Length; i++)
{
    array[i] = j;
    j += 2;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
