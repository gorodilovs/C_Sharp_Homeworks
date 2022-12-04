// Определите, каких чисел в массиве больше: которые делятся на первый элемент массива или которые делятся на последний элемент массива.

int[] arr = new int[100];
Random rnd = new Random();
int count1 = 0;
int count2 = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 10);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
        if (arr[i] % arr[0] == 0 && i != 0 && arr[i] != 0)
        {
            count1++;
            Console.Write("- C1 ");
        }
            
        else if (arr[i] % arr[arr.Length - 1] == 0 && i != arr.Length - 1 && arr[i] != 0)
        {
            count2++;
            Console.Write("- C2 ");
        }            
}
Console.WriteLine();
if (count1 > count2)
    Console.WriteLine("Чисел, делящихся на первый элемент больше");
else if(count1 == count2)
    Console.WriteLine("Чисел, делящихся на первый и последний элемент поровну");
else
    Console.WriteLine("Чисел, делящихся на последний элемент больше");