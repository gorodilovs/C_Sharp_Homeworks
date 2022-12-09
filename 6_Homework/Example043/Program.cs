// Задача 43: Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
// задаются пользователем.

// k1 * x - y + b1 = 0 
// k2 * x - y + b2 = 0
// В данном случае коэффициент для "y" равен -1
// Решим задачу для общего случая с введением трех коэффициентов:
// a1 * x + b1 * y + c1 = 0
// a2 * x + b2 * y + c2 = 0



int num;
double[,] arr = new double[2, 3];
string? userInput = string.Empty;
double x;
double y;
string nameOfCoeff = string.Empty;

int KeyboardNumberInput(string name)
{
    userInput = string.Empty;
    while(!Int32.TryParse(userInput, out num))
    {       
        System.Console.WriteLine($"Input number {name}: ");
        userInput = Console.ReadLine();

        if (Int32.TryParse(userInput, out num))
            num = Convert.ToInt32(userInput);            

        else
            System.Console.WriteLine("Input correct number!");
    }
    return num;
}

string NameOfCoeff(int k)
{
    switch (k)
    {
        case 0:
            nameOfCoeff = "a";
            break;
        case 1:
            nameOfCoeff = "b";
            break;
        case 2:
            nameOfCoeff = "c";
            break;
        default:
            nameOfCoeff = "empty";
            break;
    }
    return nameOfCoeff;
}

System.Console.WriteLine("We have 2 lines pesented as a * x + b * y + c = 0");
System.Console.WriteLine("Input coefficients:");

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        KeyboardNumberInput($"{NameOfCoeff(j)}{i + 1}");
        arr[i, j] = num;
    }
}

// Kramer method

if (arr[0, 0] * arr[1, 1] - arr[1, 0] * arr[0, 1] == 0)
{
    if (arr[0, 0] * arr[1, 2] - arr[1, 0] * arr[0, 2] == 0 && arr[0, 1] * arr[1, 2] - arr[1, 1] * arr[0, 2] == 0)
    {
        System.Console.WriteLine("The lines are equial!");
    }
    else
        System.Console.WriteLine("The lines are parallel!");
}

else
{
    x = - (arr[0, 2] * arr[1, 1] - arr[1, 2] * arr[0, 1]) / (arr[0, 0] * arr[1, 1] - arr[1, 0] * arr[0, 1]);
    y = - (arr[0, 0] * arr[1, 2] - arr[1, 0] * arr[0, 2]) / (arr[0, 0] * arr[1, 1] - arr[1, 0] * arr[0, 1]);
    System.Console.WriteLine($"Lines are crossed in x = {x}, y = {y}");
}

