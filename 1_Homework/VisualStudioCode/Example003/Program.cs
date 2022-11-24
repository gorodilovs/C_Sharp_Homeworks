string userInput = "";
int numberOfTheDay;

Console.WriteLine("Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.");

while (!Int32.TryParse(userInput, out numberOfTheDay))
{
    Console.Write("Input number of the day from 1 to 7: ");
    userInput = Console.ReadLine();

    if (Int32.TryParse(userInput, out numberOfTheDay) & numberOfTheDay >= 1 & numberOfTheDay <= 7)
        numberOfTheDay = Convert.ToInt32(userInput);
    else
    {
        Console.WriteLine("Wrong format of number of the day!");
        userInput = "";
    }
}

switch (numberOfTheDay)
{
    case 1:
        Console.WriteLine("1 is a Monday");
        break;
    case 2:
        Console.WriteLine("2 is a Tuesday");
        break;
    case 3:
        Console.WriteLine("3 is a Wednesday");
        break;
    case 4:
        Console.WriteLine("4 is a Thursday");
        break;
    case 5:
        Console.WriteLine("5 ia a Friday");
        break;
    case 6:
        Console.WriteLine("6 is a Saturday");
        break;
    case 7:
        Console.WriteLine("7 is a Sunday");
        break;
}