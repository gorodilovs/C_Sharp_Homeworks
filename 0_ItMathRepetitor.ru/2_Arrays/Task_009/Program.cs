//Создать массив, каждый элемент которого равен квадрату своего номера.
int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = (int)Math.Pow((double)i, 2);
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}