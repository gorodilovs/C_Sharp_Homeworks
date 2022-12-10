// Даны два массива. Сформировать третий массив, состоящий из
// тех элементов, которые: а) присутствуют в обоих массивах;
// б) присутствуют только в одном из массивов.


//int capacity = 20;
int[] arr1 = new int[] { 1, 2, 3, 4, 51, 62, 73, 0, 10 };
int[] arr2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int counter = 0;
bool repeat = false;

int[] arrRepeat = new int[0];
int[] arrUnique1 = new int[0];
int[] arrUnique2 = new int[0];

void PrintArray(int[] array)
{
    foreach (int n in array)
    {
        System.Console.Write(n + " ");
    }
    System.Console.WriteLine();
}

// a)
for (int i = 0; i < arr1.Length; i++)
{
    for (int j = 0; j < arr2.Length; j++)
    {
        if (arr1[i] == arr2[j])
        {
            repeat = false;
            for (int k = 0; k < arrRepeat.Length; k++)
            {
                if (arr1[i] == arrRepeat[k])
                    repeat = true;
            }
            if (!repeat)
            {
                Array.Resize(ref arrRepeat, counter + 1);
                arrRepeat[counter] = arr1[i];
                counter++;
            }
        }
    }
}

System.Console.WriteLine("First array: ");
PrintArray(arr1);
System.Console.WriteLine("Secound array: ");
PrintArray(arr2);
System.Console.WriteLine("Array with repeated elements: ");
PrintArray(arrRepeat);



// b)
// Uniqie in arr1
counter = 0;
for (int i = 0; i < arr1.Length; i++)
{
    repeat = false;
    for (int j = 0; j < arr2.Length; j++)
    {
        if (arr1[i] == arr2[j])
        {
            repeat = true;
        }
    }

    if (!repeat)
    {
        for (int k = 0; k < arrUnique1.Length; k++)
        {
            repeat = false;
            for (int n = 0; n < arrUnique1.Length; n++)
            {
                if (arr1[i] == arrUnique1[n])
                    repeat = true;
            }
        }
    }

    if (!repeat)
    {
        Array.Resize(ref arrUnique1, counter + 1);
        arrUnique1[counter] = arr1[i];
        counter++;
    }
}

System.Console.WriteLine("Array with uniques in arr1: ");
PrintArray(arrUnique1);


// Unique in arr2

counter = 0;
for (int i = 0; i < arr2.Length; i++)
{
    repeat = false;
    for (int j = 0; j < arr1.Length; j++)
    {
        if (arr2[i] == arr1[j])
        {
            repeat = true;
        }
    }

    if (!repeat)
    {
        for (int k = 0; k < arrUnique2.Length; k++)
        {
            repeat = false;
            for (int n = 0; n < arrUnique2.Length; n++)
            {
                if (arr2[i] == arrUnique2[n])
                    repeat = true;
            }
        }
    }

    if (!repeat)
    {
        Array.Resize(ref arrUnique2, counter + 1);
        arrUnique2[counter] = arr2[i];
        counter++;
    }
}

System.Console.WriteLine("Array with uniques in arr2: ");
PrintArray(arrUnique2);
