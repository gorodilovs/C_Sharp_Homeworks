// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number;
string? userInput = "";

while (!Int32.TryParse(userInput, out number))
{
    Console.WriteLine("Input number from 10000 to 99999:");
    userInput = Console.ReadLine();
    if (Int32.TryParse(userInput, out number) && number > 9999 && number < 100000)
    {
        if (userInput.Substring(0,1) == userInput.Substring(4,1) && userInput.Substring(1,1) == userInput.Substring(3,1))       
            Console.WriteLine("Number is a palindrome");
        
        else
            Console.WriteLine("Number is not a palindrome");
    }
    else
    {
        Console.WriteLine("Input correct number from 10000 to 99999");
        userInput = "";
    }
}
