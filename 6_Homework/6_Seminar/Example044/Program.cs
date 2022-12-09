// Задача 44: Не исспользуя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int num;
string? userInput = string.Empty;
int fib1 = 0;
int fib2 = 1;
int temp = 0;

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

KeyboardNumberInput("Input quantity of Fibonacci numbers: ");

System.Console.WriteLine($"Fibonacci 0: {fib1}");
System.Console.WriteLine($"Fibonacci 1: {fib2}");

for (int i = 2; i <= num; i++)
{
    System.Console.WriteLine($"Fibonacci {i}: {fib1 + fib2}");
    temp = fib2;
    fib2 = fib1 + fib2;
    fib1 = temp;
}
