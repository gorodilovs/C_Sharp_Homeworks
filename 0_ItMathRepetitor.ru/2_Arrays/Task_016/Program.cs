// Создайте массив, в котором количество отрицательных чисел равно количеству положительных и
// положительные числа расположены на случайных местах в массиве.

int[] arr = new int[20];
Random rnd = new Random();
int temp;
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 10);
}

while(count != arr.Length/2)
{
    temp = rnd.Next(0, arr.Length);
    if (arr[temp] > 0)
    {
        arr[temp] = -arr[temp];
        count++;
    }
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}

Console.Write("!!!" + count);