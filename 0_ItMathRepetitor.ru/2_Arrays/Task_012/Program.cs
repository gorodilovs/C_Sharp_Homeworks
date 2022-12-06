// Создать массив, который одинаково читается как слева направо,
// так и справа налево.

int[] array = new int[39];

for (int i = 0; i <= array.Length / 2; i++)
{
    array[i] = i;
    array[array.Length - i - 1] = i;

}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}