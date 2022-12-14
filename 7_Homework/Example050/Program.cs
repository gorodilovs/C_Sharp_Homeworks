// Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого
// элемента или же указание, что такого элемента нет.

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
            arr[i, j] = rnd.Next(1, 100);
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] arr = new int[5, 5];
FillAndPrintArray(arr);

int index1 = KeyboardInput("Input first index: ");
int index2 = KeyboardInput("Input second index: ");

if (index1 > arr.GetLength(0) - 1
     || index2 > arr.GetLength(1) - 1
     || index1 < 0
     || index2 < 0)
{
    System.Console.WriteLine("Index out of range!");
}
else
    System.Console.WriteLine($"Number arr[{index1}, {index2}] is {arr[index1, index2]}");
