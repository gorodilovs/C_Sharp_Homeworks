// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

long num;
string userInput = string.Empty;

while(!long.TryParse(userInput, out num))
{
    Console.WriteLine("Input number : ");
    userInput = Console.ReadLine();

    if (long.TryParse(userInput, out num))
    {
        Console.WriteLine($"Result is: {userInput.Length}");
    }
    else
        Console.WriteLine("Input correct number!");
}
