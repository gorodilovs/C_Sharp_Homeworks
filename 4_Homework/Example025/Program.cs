// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int A;
int B;
string? userInput = string.Empty;

while (!Int32.TryParse(userInput, out A))
{
    Console.WriteLine("Input number A: ");
    userInput = Console.ReadLine();

    if (Int32.TryParse(userInput, out A))
        A = Convert.ToInt32(userInput);
    else
        Console.WriteLine("Input correct number");
}
userInput = string.Empty;
while (!Int32.TryParse(userInput, out B))
{
    Console.WriteLine("Input number B: ");
    userInput = Console.ReadLine();

    if (Int32.TryParse(userInput, out B))
        B = Convert.ToInt32(userInput);       
    else
        Console.WriteLine("Input correct number");
}

Console.WriteLine($"Number A in B degree is {Math.Pow(A, B)}");