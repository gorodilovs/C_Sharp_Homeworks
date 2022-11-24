int a;
string userInput = "";

Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");

while (!Int32.TryParse(userInput, out a))
{
    Console.Write("Input number: ");
    userInput = Console.ReadLine();

    if (Int32.TryParse(userInput, out a))
        a = Convert.ToInt32(userInput);
    else
        Console.WriteLine("Wrong format!");
}

if (a % 2 == 0)
    Console.WriteLine("Number is even!");
else
    Console.WriteLine("Number is odd!");