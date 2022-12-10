// Преобразовать массив таким образом, чтобы сначала располагались
// все элементы, модуль которых не превышает единицу, а потом – все остальные.
// (Без использования дополнительного масcива) 

int capacity = 20;
int[] arr = new int[capacity];
Random rnd = new Random();
int counter1 = 0;
int temp1 = 0;
int temp2 = 0;
int temp3 = 0;

void PrintArray(int[] a)
{
foreach (int n in a)
{
    System.Console.Write(n + " ");
}
System.Console.WriteLine();
}

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-5, 5);
}

PrintArray(arr);

for (int i = 0; i < arr.Length; i++)
{

    if (Math.Abs(arr[i]) == 1)
    {       
        temp1 = arr[i];
        for (int j = counter1; j <= i; j++)
        {
            temp2 = arr[j];        
            arr[j] = temp3;
            temp3 = temp2;
        }
        arr[counter1] = temp1;
        counter1++;
    }

}
System.Console.WriteLine("Matches: " + counter1);  
PrintArray(arr);