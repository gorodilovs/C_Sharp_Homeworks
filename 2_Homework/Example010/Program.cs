int number;
string? userInput = "";
char[] result = new char[3];


while (!Int32.TryParse(userInput, out number))
{
    Console.WriteLine("Input number from 100 to 999: ");
    userInput = Console.ReadLine();

    if (Int32.TryParse(userInput, out number) & number > 99 & number < 1000)
    {
        result = userInput.ToCharArray();
        Console.WriteLine($"Second character of number {userInput} is {result[1]}");
    }

    else
    {
        Console.WriteLine("Number out of range.");
        userInput = "";
    }
}
