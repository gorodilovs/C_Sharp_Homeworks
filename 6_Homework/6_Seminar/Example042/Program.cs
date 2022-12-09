// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное. (решить методом математической
// функции, без склевивания строк!)

long binaryNum = 0;
int num;
string? userInput = string.Empty;


int KeyboardNumberInput(string name)
{
    userInput = string.Empty;
    while(!Int32.TryParse(userInput, out num))
    {       
        System.Console.WriteLine($"{name}");
        userInput = Console.ReadLine();

        if (Int32.TryParse(userInput, out num))
            num = Convert.ToInt32(userInput);            

        else
            System.Console.WriteLine("Input correct number!");
    }
    return num;
}

KeyboardNumberInput("Input decimal number: ");
System.Console.WriteLine($"Number is {num}");

for (int j = 0; num != 0; j++)
{

    if (num < (int)Math.Pow(2, j))
    {
        num = num - (int)Math.Pow(2, j - 1);
        binaryNum += (long)Math.Pow(10, j - 1);
        j = 0;
    }
    if (num == (int)Math.Pow(2, j))
    {
        num = num - (int)Math.Pow(2, j);
        binaryNum += (long)Math.Pow(10, j);
    }
}

System.Console.WriteLine($"Answer in binary is {binaryNum}.");