// Преобразовать массив таким образом, чтобы сначала располагались
// все элементы, модуль которых не превышает единицу, а потом – все остальные. (Без использования дополнительного масиива)

int capacity = 20;
int[] arr = new int[] {2, 5, 3, 0, 0, 0, 0, 1};
Random rnd = new Random();
int counter1 = 0;
int counter2 = 0;
int temp1;
int temp2 = 0;

void PrintArray(int[] a)
{
foreach (int n in a)
{
    System.Console.Write(n + " ");
}
System.Console.WriteLine();
}

// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = rnd.Next(0, 10);
// }

PrintArray(arr);

for (int i = 0; i < arr.Length; i++)
{

    if (Math.Abs(arr[i]) == 1)
    {
        temp1 = arr[i];
        counter1++;
        for (int j = counter1; j < i; j++)
        {
            temp2 = arr[j];
            arr[j] = arr[j - 1];
            arr[j + 1] = temp2;
        }
        arr[counter1 - 1] = temp1;

    }

}
PrintArray(arr);