// Даны два массива. Определите, существуют ли в первом массиве
// такие два элемента, что их сумма равна сумме каких-либо трех
// элементов второго массива.

int capacity = 5;
Random rnd = new Random();
int[] arr1 = new int[capacity];
int[] arr2 = new int[capacity];

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write(item + " ");
    }
    System.Console.WriteLine();
}

for (int i = 0; i < arr1.Length; i++)
{
    arr1[i] = rnd.Next(1, 10);
}

for (int i = 0; i < arr2.Length; i++)
{
    arr2[i] = rnd.Next(1, 10);
}

PrintArray(arr1);
PrintArray(arr2);

int sumOfThreeNumbers = 0;
int sumOfTwoNumbers = 0;

for (int i1 = 0; i1 < arr1.Length; i1++)
{
    for (int j1 = 0; j1 < arr1.Length; j1++)
    {
        if (i1 != j1)
        {
            for (int k1 = 0; k1 < arr1.Length; k1++)
            {
                if (j1 != k1 && i1 != k1)
                {
                    sumOfThreeNumbers = arr1[i1] + arr1[j1] + arr1[k1];

                    for (int i2 = 0; i2 < arr2.Length; i2++)
                    {
                        for (int j2 = 0; j2 < arr2.Length; j2++)
                        {
                            if (i2 != j2)
                            {
                                sumOfTwoNumbers = arr2[i2] + arr2[j2];

                                if (sumOfThreeNumbers == sumOfTwoNumbers)
                                {
                                    System.Console.WriteLine($"Sum {sumOfThreeNumbers} in arr1 index: {i1}, {j1}, {k1} equial arr2 index: {i2}, {j2} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
