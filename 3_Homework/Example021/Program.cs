// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double[] pointA = new double[3];
double[] pointB = new double[3];
double distance;
string? userInput = "";

for (int i = 0; i <= 2; i++)
{   
    userInput = "";
    while(!double.TryParse(userInput, out pointA[i]))
    {
        Console.WriteLine($"Input Point A{i+1}: ");
        userInput = Console.ReadLine();

        if (double.TryParse(userInput, out pointA[i]))
        {
            pointA[i] = Convert.ToSingle(userInput);            
        }

        else
        {
            Console.WriteLine("Input correct number!");
        }
    }       
}

Console.WriteLine($"{pointA[0]} {pointA[1]} {pointA[2]}");

for (int i = 0; i <= 2; i++)
{   
    userInput = "";
    while(!double.TryParse(userInput, out pointB[i]))
    {
        Console.WriteLine($"Input Point B{i+1}: ");
        userInput = Console.ReadLine();

        if (double.TryParse(userInput, out pointB[i]))
        {
            pointB[i] = Convert.ToSingle(userInput);            
        }

        else
        {
            Console.WriteLine("Input correct number!");
        }
    }
}  

distance = Math.Sqrt(Math.Pow(pointB[0] - pointA[0], 2) + Math.Pow(pointB[1] - pointA[1], 2) + Math.Pow(pointB[2] - pointA[2], 2));
Console.WriteLine($"Distance between points is {distance}");
