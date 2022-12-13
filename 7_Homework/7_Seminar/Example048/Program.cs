// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.

int KeyboardInput(string name)
{
    int num;
    string? userInput = string.Empty;

    while (!Int32.TryParse(userInput, out num))
    {
        userInput = string.Empty;
        System.Console.WriteLine(name);
        userInput = Console.ReadLine();

        if (Int32.TryParse(userInput, out num))
            num = Convert.ToInt32(userInput);
        else
            System.Console.WriteLine("Input correct number!");
    }
    return num;
}

void PrintArray(int[,] arr)
{
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int m; // First dimension
int n; // Second dimension

m = KeyboardInput("Input dimension (m): ");
n = KeyboardInput("Input dimension (n): ");

int[,] twoDimensionsArray = new int[m, n];

for (int i = 0; i < twoDimensionsArray.GetLength(0); i++)
{
    for (int j = 0; j < twoDimensionsArray.GetLength(1); j++)
    {
        twoDimensionsArray[i, j] = i + j;
    }
}

PrintArray(twoDimensionsArray);