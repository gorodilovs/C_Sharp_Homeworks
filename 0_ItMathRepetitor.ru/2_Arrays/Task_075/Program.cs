// Дан массив. Сформировать новый массив, в котором идут сначала
// отрицательные элементы, затем нули, затем положительные.
// (без сортировки по возрастанию!)

int capacity = 100;
int[] arr = new int[capacity];
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
    arr[i] = rnd.Next(-3, 4);
 }

PrintArray(arr);

int[] arrNew = new int[0];
int counter = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0)
    {
        Array.Resize(ref arrNew, arrNew.Length + 1);
        arrNew[counter] = arr[i];
        counter++;
    }
}
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == 0)
    {
        Array.Resize(ref arrNew, arrNew.Length + 1);
        arrNew[counter] = arr[i];
        counter++;
    }
}
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        Array.Resize(ref arrNew, arrNew.Length + 1);
        arrNew[counter] = arr[i];
        counter++;
    }
}


PrintArray(arrNew);