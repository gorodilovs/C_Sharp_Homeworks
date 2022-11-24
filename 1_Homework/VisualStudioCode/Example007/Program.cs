int N;
string userInput = "";

Console.WriteLine("Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.");

while (!Int32.TryParse(userInput, out N))
{
    Console.Write("Input number N from 100 to 999: ");
    userInput = Console.ReadLine();

    if (Int32.TryParse(userInput, out N) & N > 99 & N < 1000)
        N = Convert.ToInt32(userInput);
    else
    {
        Console.WriteLine("Wrong format of N!");
        userInput = "";
    }
}

int result;
result = N % 10;
Console.WriteLine($"The last character of number is {result}.");