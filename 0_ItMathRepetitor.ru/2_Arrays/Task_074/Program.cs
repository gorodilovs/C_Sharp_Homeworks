// Удалите в целочисленном массиве все положительные числа,
// которые являются палиндромами. (Без использования конвертации
// в строки!)
 
int capacity = 100;
int[] arr = new int[capacity]; // {12031, 232, 2345432, 10, 3333};
Random rnd = new Random();

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write(item+ " ");
    }
    System.Console.WriteLine();
}

 for (int i = 0; i < arr.Length; i++)
 {
    arr[i] = rnd.Next(-1000, 1000);
 }

PrintArray(arr);
System.Console.WriteLine();
int div = 1;
bool isTrue = false;

for (int i = 0; i < arr.Length; i++)
{
    div = 1;
    isTrue = false;
    while (arr[i] > div)
    {
        div *= 10;
    }
    div /= 10;
    //System.Console.WriteLine(div);

    for (int j = 1; div >= (int)Math.Pow(10, j); j++)
    {
        if ((arr[i] / div) % 10 == (arr[i] % (int)Math.Pow(10, j)) / (int)Math.Pow(10, j - 1) && div >= (int)Math.Pow(10, j))
        {
            div /=  10;
            isTrue = true;
            //System.Console.WriteLine(div);
            
        }
        else
        {
            isTrue = false;
            break;
        }
    }
    if (isTrue)
    {
        System.Console.WriteLine($"Poli {arr[i]}, index {i} deleted.");
        for (int k = i; k < arr.Length - 1; k++)
        {
            arr[k] = arr[k + 1];
        }
        Array.Resize(ref arr, arr.Length - 1);
        i = i - 1;
            
        System.Console.WriteLine("Resized array: ");
        PrintArray(arr);
        System.Console.WriteLine();
    }
}









// System.Console.WriteLine($"Itteration {i}");
// System.Console.WriteLine((test / div) % 10);
// System.Console.WriteLine((test % (int)Math.Pow(10, i)) / (int)Math.Pow(10, i - 1));