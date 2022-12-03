//Создать массив из n первых чисел Фибоначчи.

int[] array = new int[30];
array[0] = 0;
array[1] = 1;


for (int i = 2; i < array.Length; i++)
{
    array[i] = array[i - 1] + array[i - 2];

}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
