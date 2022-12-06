// Определите, есть ли в массиве повторяющиеся элементы.

int capacity =30;
int[] arr = new int[capacity];
int[] matches = new int[capacity]; //Matches array is ONE-first half of repeated numbers and SECOND-half is number of times that number appears.
Random rnd = new Random();
int counter1 = 0; //Counter of unique matches.
int counter2 = 1; //Starts from 1 to include searching number to total matches.
bool repeat = false; //Bool if number repeats existing number in matches array.
bool found = false; //Bool if number appears at least 2 times in the array.

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 50);
}

for (int i = 0; i < arr.Length; i++)
{
    repeat = false;
    found = false;
    counter2 = 1;

    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[i] == arr[j] && i != j) //If numbers the same but not on the same position 
        {
            found = true;
            for(int k = 0; k < matches.Length / 2; k++) //if number already in matches array
            {
                if (arr[i] == matches[k] && k < matches.Length/2)
                    repeat = true;
            }
            counter2++;            
        }
    }

    if (found && !repeat)
    {
        matches[counter1] = arr[i];
        matches[matches.Length / 2 + counter1] = counter2;
        counter1++;
    }
}


Console.WriteLine("Original array: ");
foreach (int n in arr)
{
    Console.Write(n + " ");
}
Console.WriteLine();


Console.WriteLine("Matches array: ");
foreach (int n in matches)
{
    Console.Write(n + " ");
}
Console.WriteLine();


for (int i = 0; i < counter1; i++)
{
    Console.WriteLine($"Matched number {matches[i]} appears {matches[matches.Length/2 + i]} times.");
}
