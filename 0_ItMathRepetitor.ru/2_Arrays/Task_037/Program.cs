// Дан массив и число p. Найдите два различных числа в массиве, сумма которых наиболее близка к p.

int p = 500;
int n = 20;
int[] arr = new int[n];
Random rnd = new Random();
int rangeMin = 1;
int rangeMax = 1000;
int minCloseSum = rangeMin; 
int maxCloseSum = 2 * rangeMax;
int indexOfFirstMin = 0; 
int indexOfSecondMin = 0;
int indexOfFirstMax = 0; 
int indexOfSecondMax = 0;
int indexOfFirst; 
int indexOfSecond;
int closestSum;

for(int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(rangeMin, rangeMax);
}

for(int i = 0; i < arr.Length; i++)
{
    for(int j = 0; j < arr.Length; j++)
    {
        if (arr[i] + arr[j] > minCloseSum && arr[i] + arr[j] <= p)
        {
            minCloseSum = arr[i] + arr[j];
            indexOfFirstMin = i;
            indexOfSecondMin = j;
        }
            
        if (arr[i] + arr[j] < maxCloseSum && arr[i] + arr[j] >= p)
        {
            maxCloseSum = arr[i] + arr[j];
            indexOfFirstMax = i;
            indexOfSecondMax = j;
        }            
    }    
}

if (maxCloseSum - p < p - minCloseSum)
{
    closestSum = maxCloseSum;
    indexOfFirst = indexOfFirstMax;
    indexOfSecond = indexOfSecondMax;
}

else
{
    closestSum = minCloseSum;
    indexOfFirst = indexOfFirstMin;
    indexOfSecond = indexOfSecondMin;
}


for(int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}

Console.WriteLine();
Console.WriteLine($"Max close: {maxCloseSum}, Min close: {minCloseSum}");
Console.WriteLine($"Closest sum: {closestSum} Index 1: {indexOfFirst} Index 2: {indexOfSecond}");