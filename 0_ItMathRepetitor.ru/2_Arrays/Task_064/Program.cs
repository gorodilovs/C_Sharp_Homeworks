// Удалить в массиве все наибольшие элементы.

int capacity = 20;
int[] arr = new int[] {1, 3, 3};
int[] delete =  new int[arr.Length];
Random rnd = new Random();
int counter = 0;
int counterToEnd = 0;

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
//     arr[i] = rnd.Next(1, 10);
// }

int max = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
        max = arr[i];
}

System.Console.WriteLine("Original array: ");
PrintArray(arr);

System.Console.WriteLine(max);

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] == max)
//     {
        
//         for (int j = i; j < arr.Length - 1; j++)
//         {
//             arr[j] = arr[j + 1];
//             counterToEnd++;
//             if (counterToEnd == arr.Length - 1)
//                 j = arr.Length;
//         }

//         if (counterToEnd < arr.Length + 1)
//         {
//             for (int j = i; j < arr.Length - 1; j++)
//             {
//                 arr[j] = arr[j + 1];            
//             }
//             counter++;
//             i--;
//             counterToEnd = i;
//         }
//         else
//         {
//             for (int j = i; j < arr.Length - 1; j++)
//             {
//                 arr[j] = 0;
//                 counter++;            
//             }
//             i = arr.Length;
//         }
//     }
// }

System.Console.WriteLine("Modifyed array: ");
Array.Resize(ref arr, arr.Length - counter);
PrintArray(arr);