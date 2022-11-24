int number;
string? userInput = "";



while (!Int32.TryParse(userInput, out number))
{
    Console.WriteLine("Input number: ");
    userInput = Console.ReadLine();

    if (Int32.TryParse(userInput, out number))
    {
        if (userInput.Length >= 3)
            Console.WriteLine($"Third character of number {userInput} is {userInput.Substring(2, 1)}");

        else
            Console.WriteLine("Third character is missing.");        
    }

    else
    {
        Console.WriteLine("Input correct number.");
        userInput = "";
    }
}
