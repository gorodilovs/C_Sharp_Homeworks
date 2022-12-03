//Сформировать массив из элементов арифметической прогрессии с заданным первым элементом x и разностью d.

int x = 1;
int d = 3;

int[] array = new int[10];


for (int i = 0; i < array.Length; i++)
{
    array[i] = x + i * d;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}