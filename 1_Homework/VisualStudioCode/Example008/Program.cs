int N;
string userInput = "";

Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа.");

while (!Int32.TryParse(userInput, out N))
{
    Console.Write("Input number: ");
    userInput = Console.ReadLine();

    if (Int32.TryParse(userInput, out N))
        N = Convert.ToInt32(userInput);
    else
        Console.WriteLine("Wrong format!");
}

for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0 & i != N - 1 & i != N)
        Console.Write($"{i}, ");
    if (i % 2 == 0 & (i == N - 1 || i == N))
        Console.Write($"{i}\n");
}