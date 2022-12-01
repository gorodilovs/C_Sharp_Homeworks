// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int num;
int result = 0;
string userInput = string.Empty;

while (!Int32.TryParse(userInput, out num))
{
    Console.WriteLine("Input number: ");
    userInput = Console.ReadLine();

    if (Int32.TryParse(userInput, out num))
        num = Convert.ToInt32(userInput);      
    else
        Console.WriteLine("Input correct number");
}

for (int i = 0; i < userInput.Length; i++)
{
    result += num % 10;
    num = num / 10;
}
Console.WriteLine($"Result is: {result}");