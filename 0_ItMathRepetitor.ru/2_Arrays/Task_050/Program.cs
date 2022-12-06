// Напишите программу, которая вводит с клавиатуры непустой массив целых чисел,
// и выводит число локальных максимумов (элемент является локальным максимумом,
// если он не имеет соседей, больших, чем он сам).

int n = 10;
int[] arr = new int[n];
string? userInput = string.Empty;
int number;
int counter = 0;

Console.WriteLine();

for (int i = 0; i < arr.Length; i++)
{
    userInput = string.Empty;
    while(!Int32.TryParse(userInput, out number))
    {
        Console.WriteLine($"Input number {i}:");
        userInput = Console.ReadLine();

        if (Int32.TryParse(userInput, out number))
        {
            arr[i] = Convert.ToInt32(userInput);
        }
        else
        {
            Console.WriteLine("Input correct number!");
        }    
    }
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}

Console.WriteLine();

for (int i = 1; i < arr.Length - 1; i++)
{
    if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
    {
        Console.WriteLine($"Number {arr[i]} with index {i} is local max.");
        counter++;
    }        
}

Console.WriteLine($"Number of local maxes: {counter}.");
