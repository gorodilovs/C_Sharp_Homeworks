// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int arrayCapacity;
string userInput = string.Empty;

while (!Int32.TryParse(userInput, out arrayCapacity))
{
    Console.WriteLine("Input array capacity: ");
    userInput = Console.ReadLine();

    if (Int32.TryParse(userInput, out arrayCapacity))
        arrayCapacity = Convert.ToInt32(userInput);
    else
        Console.WriteLine("Input correct number!");
}

int[] num = new int[arrayCapacity];
for (int i = 0; i < arrayCapacity; i++)
{
    userInput = string.Empty;
    while (!Int32.TryParse(userInput, out num[i]))
    {
        Console.WriteLine($"Input number num {i+1}:");
        userInput = Console.ReadLine();

        if (Int32.TryParse(userInput, out num[i]))
            num[i] = Convert.ToInt32(userInput);
        else
            Console.WriteLine("Input correct number!");
    }
}

for (int i = 0; i < arrayCapacity; i++)
{
    if (i == 0)
        Console.Write($"Array num is: [{num[i]} ");
    else if (i == arrayCapacity - 1)
        Console.Write(num[i] + "]");
    else
        Console.Write(num[i] + " ");
}


