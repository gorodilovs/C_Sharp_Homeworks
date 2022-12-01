// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int A;
int result = 0;
string userInput = string.Empty;

while(!Int32.TryParse(userInput, out A))
{
    Console.WriteLine("Input number A: ");
    userInput = Console.ReadLine();

    if (Int32.TryParse(userInput, out A))
    {
        for (int i = 1; i <= A; i++)
        {
            result += i;
        }
    }
    else
        Console.WriteLine("Input correct number!");
}
Console.WriteLine($"Result is: {result}");