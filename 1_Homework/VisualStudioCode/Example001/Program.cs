int a;
int b;
string userInput = "";

Console.WriteLine("Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.");

while (!Int32.TryParse(userInput, out a))
{
    Console.Write("Input number a: ");
    userInput = Console.ReadLine();

    if (Int32.TryParse(userInput, out a))
        a = Convert.ToInt32(userInput);
    else
        Console.WriteLine("Wrong format of a!");
}

userInput = "";
while (!Int32.TryParse(userInput, out b))
{
    Console.Write("Input number b: ");
    userInput = Console.ReadLine();

    if (Int32.TryParse(userInput, out b))
        b = Convert.ToInt32(userInput);
    else
        Console.WriteLine("Wrong format of b!");

}

if (a == (int)Math.Pow(b, 2))
    Console.WriteLine("Number (a) is a square of (b).");
else
    Console.WriteLine("Number (a) is NOT a square of (b).");