// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со
// сторонами такой длины.

int[] triangle = new int[3];
int num;
string? userInput = string.Empty;
int counter = 0;
int sum = 0;

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

for (int i = 0; i < triangle.Length; i++)
{
    KeyboardNumberInput($"Input triangle side number {i + 1}: ");
    triangle[i] = num;
}

for (int i = 0; i < triangle.Length; i++)
{
    sum = 0;
    for (int j = 0; j < triangle.Length; j++)
    {
        if (i != j)
            sum += triangle[j];
    }
    if (triangle[i] <= sum)
        counter++;
}

if (counter == 3)
    System.Console.WriteLine("Triangle is REAL!");
else
    System.Console.WriteLine("Triangle is not real.");