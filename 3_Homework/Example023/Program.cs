// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int N;
string? userInput = "";
int result;

while(!Int32.TryParse(userInput, out N))
{
    Console.WriteLine("Input number N: ");
    userInput = Console.ReadLine();

    if (Int32.TryParse(userInput, out N))
    {
        for (int i = 1; i <= N; i++)
        {
            result = (int)Math.Pow(i, 3);
            Console.Write($"{result} ");
        }
    }
    else
    {
        Console.WriteLine("Input correct number!");
    }
}
