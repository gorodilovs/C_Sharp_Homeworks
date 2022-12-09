// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int num;
string? userInput = string.Empty;
int counter = 0;

int KeyboardNumberInput(string name)
{
    userInput = string.Empty;
    while(!Int32.TryParse(userInput, out num))
    {       
        System.Console.WriteLine($"Input number {name}: ");
        userInput = Console.ReadLine();

        if (Int32.TryParse(userInput, out num))
            num = Convert.ToInt32(userInput);            

        else
            System.Console.WriteLine("Input correct number!");
    }
    return num;
}

KeyboardNumberInput("M (quantity of numbers)");
int[] arr = new int[num];

System.Console.WriteLine("Counting starts from zero!");
for (int i = 0; i < arr.Length; i++)
{
    KeyboardNumberInput($"{i}");
    arr[i] = num;
    if (arr[i] > 0)
        counter++;
}

System.Console.WriteLine("Input array: ");
foreach (int n in arr)
{
    System.Console.Write(n + " ");
}
System.Console.WriteLine();

System.Console.WriteLine($"User input {counter} number(s) higher than 0!");
