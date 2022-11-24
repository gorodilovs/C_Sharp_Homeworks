namespace C_Homework_1
{
    //Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

    internal class Example5
    {
        public void Task()
        {
            int N;
            string userInput = "";

            Console.WriteLine("Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.");

            while (!Int32.TryParse(userInput, out N))
            {
                Console.Write("Input number N: ");
                userInput = Console.ReadLine();

                if (Int32.TryParse(userInput, out N))
                    N = Convert.ToInt32(userInput);
                else
                    Console.WriteLine("Wrong format of N!");
            }

            int row = -N;
            for (int i = row; i <= N; i++)
            {
                Console.Write(row + " ");
                row++;
            }
            Console.WriteLine();
        }
    }
}
