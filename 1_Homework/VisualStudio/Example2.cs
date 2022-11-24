namespace C_Homework_1
{
    //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    
    internal class Example2
    {
        public void Task()
        {
            int a;
            int b;
            string userInput = "";

            Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");

            while (!Int32.TryParse(userInput, out a))
            {
                Console.Write("Input number a: ");
                userInput = Console.ReadLine();

                if (Int32.TryParse(userInput, out a))
                    a = Convert.ToInt32(userInput);
                else
                    Console.WriteLine("Wrong format of a!");
            }

            userInput = "";
            while (!Int32.TryParse(userInput, out b))
            {
                Console.Write("Input number b: ");
                userInput = Console.ReadLine();

                if (Int32.TryParse(userInput, out b))
                    b = Convert.ToInt32(userInput);
                else
                    Console.WriteLine("Wrong format of b!");

            }
            if (a > b)
                Console.WriteLine($"Max a = {a}");
            else
                Console.WriteLine($"Max b = {b}");
        }
    }
}
