int rowCapacity;
string userInput = "";

Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.\nВ данном случае сделаем для N чисел.");

while (!Int32.TryParse(userInput, out rowCapacity))
{
    Console.Write("Input row capacity: ");
    userInput = Console.ReadLine();

    if (Int32.TryParse(userInput, out rowCapacity))
        rowCapacity = Convert.ToInt32(userInput);
    else
        Console.WriteLine("Wrong format of row capacity!");
}


int[] row = new int[rowCapacity];
userInput = "";
int max = row[0];
for (int i = 0; i < rowCapacity; i++)
{
    while (!Int32.TryParse(userInput, out row[i]))
    {
        Console.Write($"Input element {i + 1}: ");
        userInput = Console.ReadLine();

        if (Int32.TryParse(userInput, out row[i]))
            row[i] = Convert.ToInt32(userInput);

        else
            Console.WriteLine($"Wrong format of element {i + 1}!");
    }
    userInput = "";
    if (row[i] > max)
        max = row[i];
}
Console.WriteLine($"Max is {max}.");