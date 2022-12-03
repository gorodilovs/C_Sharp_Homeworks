//Сформировать убывающий массив из чисел, которые делятся на 3.

int[] array = new int[10];
int j = 27;

for (int i = 0; i < array.Length; i++)
{
    array[i] = j;
    j -= 3;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
