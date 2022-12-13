// Даны два массива. Определите все серии подряд идущих
// элементов из первого массива (серия может состоять и из
// одного элемента), каждая из которых совпадает с какой-нибудь
// серией подряд идущих элементов второго массива.

//int capacity = 10;
int[] arr1 = new int[] {1, 2, 3, 4, 5, 5, 4, 3, 1};
int[] arr2 = new int[] {1, 2, 1, 2, 2, 3, 4, 5, 5};
Random rnd = new Random();

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write(item+ " ");
    }
    System.Console.WriteLine();
}

//  for (int i = 0; i < arr.Length; i++)
//  {
//     arr[i] = rnd.Next(1, 10);
//  }

int counter = 0;
for (int i = 0; i < arr1.Length; i++)
{
    for (int j = 0; j < arr2.Length; j++)
    {   
        if (arr1[i] == arr1[j])
        {
            counter = 0;
            while (arr1[i + counter] != arr2[j + counter] && i + counter != arr1.Length - 1 && j + counter != arr2.Length - 1)
            {
                counter++;
                System.Console.WriteLine($"While Itteration {counter}");
            }
            counter--;
            System.Console.WriteLine($"Series in arr1 starts from index {i}:");
            for (int k = i; k <= i + counter; k++)
            {
                System.Console.Write($"{arr1[k]} ");
            }
            System.Console.WriteLine();

            System.Console.WriteLine($"equial series in arr2 starts from index {j}:");
            for (int k = j; k <= j + counter; k++)
            {
                System.Console.Write($"{arr2[k]} ");
            }
            System.Console.WriteLine();
        }

    }
}

PrintArray(arr1);
PrintArray(arr2);