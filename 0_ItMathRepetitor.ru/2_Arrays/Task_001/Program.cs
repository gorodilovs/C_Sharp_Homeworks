//Заполнить массив нулями, кроме первого и последнего элементов, которые должны быть равны единице.

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    if (i == 0 || i == array.Length -1)
        array[i] = 1;
    else 
        array[i] = 0;
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
