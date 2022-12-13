// Задача 49: Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти элементы на
// их квадраты. 

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

void FillArray(int[,] arr)
{
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 10);
        }
    }
}


int m; // First dimension
int n; // Second dimension

m = KeyboardInput("Input dimension (m): ");
n = KeyboardInput("Input dimension (n): ");

int[,] twoDimensionsArray = new int[m, n];

System.Console.WriteLine("Original array: ");
FillArray(twoDimensionsArray);
PrintArray(twoDimensionsArray);

for (int i = 0; i < twoDimensionsArray.GetLength(0); i++)
{
    for (int j = 0; j < twoDimensionsArray.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
            twoDimensionsArray[i, j] = (int)Math.Pow(twoDimensionsArray[i, j], 2);
    }
}

System.Console.WriteLine("Replaced array: ");
PrintArray(twoDimensionsArray);