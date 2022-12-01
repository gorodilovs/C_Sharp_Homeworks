// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int N;
int result = 1;
string userInput = string.Empty;

while(!Int32.TryParse(userInput, out N))
{
    Console.WriteLine("Input number A: ");
    userInput = Console.ReadLine();

    if (Int32.TryParse(userInput, out N))
    {
        for (int i = 1; i <= N; i++)
        {
            result *= i;
        }
    }
    else
        Console.WriteLine("Input correct number!");
}
Console.WriteLine($"Result is: {result}");