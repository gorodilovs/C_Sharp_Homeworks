// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.

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

void FillAndPrintArray(int[,] arr)
{
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 10);
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

FillAndPrintArray(twoDimensionsArray);