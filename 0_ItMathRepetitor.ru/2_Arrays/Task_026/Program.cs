// Найдите сумму чисел массива, которые расположены до первого четного числа массива. 
// Если четных чисел в массиве нет, то найти сумму всех чисел за исключением крайних.

int[] arr = new int[30];
Random rnd = new Random();
int sum = 0;
int start = -1;


for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 10);

    if (arr[i] % 2 == 0 && arr[i] != 0)
        start = i;
}

if (start == - 1)
    Console.WriteLine("Even missing!");

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");


    if (start != -1 && i <= start)
        sum += arr[i];


    if (start == -1 && i != 0 && i != arr.Length - 1)
        sum += arr[i];  
}

Console.WriteLine();
Console.WriteLine($"Sum = {sum}");