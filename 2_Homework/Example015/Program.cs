int number;
string? userInput = "";



while (!Int32.TryParse(userInput, out number))
{
    Console.WriteLine("Input number of the day in the week: ");
    userInput = Console.ReadLine();

    if (Int32.TryParse(userInput, out number) && number >=1 && number <= 7)
    {

    // Short Version
        if (number >=6 && number <=7)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");

    // Long Version        
        switch(number)
        {
            case 1:
                Console.WriteLine("No, this is Monday");
                break;
            case 2:
                Console.WriteLine("No, this is Tuesday");
                break;
            case 3:
                Console.WriteLine("No, this is Wednesday");
                break;
            case 4:
                Console.WriteLine("No, this is Thursday");
                break;
            case 5:
                Console.WriteLine("No, this is Friday");
                break;
            case 6:
                Console.WriteLine("Yes, this is Saturday");
                break;
            case 7:
                Console.WriteLine("Yes, this is Sunday");
                break;

        }         
    }

    else
    {
        Console.WriteLine("Input correct number from 1 to 7.");
        userInput = "";
    }
}
