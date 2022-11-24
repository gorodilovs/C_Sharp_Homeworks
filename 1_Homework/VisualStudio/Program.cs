using System;

namespace C_Homework_1
{
    //Программа с домашними заданиями Семинар 1.

    class Program
    {

        static void Main()
        {
            int numberOfExample;
            string userInput;
            string stop = "";

            do
            {
                userInput = "";
                while (!Int32.TryParse(userInput, out numberOfExample))
                {
                    Console.Write("Input number of Example from 1 to 8: ");
                    userInput = Console.ReadLine();

                    if (Int32.TryParse(userInput, out numberOfExample)
                                                    & numberOfExample >= 1
                                                    & numberOfExample <= 8)
                        numberOfExample = Convert.ToInt32(userInput);

                    else
                    {
                        Console.WriteLine("Wrong number of Example!");
                        //userInput = "";
                    }
                }


                switch (numberOfExample)
                {
                    case 1:
                        var ex1 = new Example1();
                        ex1.Task();
                        break;
                    case 2:
                        var ex2 = new Example2();
                        ex2.Task();
                        break;
                    case 3:
                        var ex3 = new Example3();
                        ex3.Task();
                        break;
                    case 4:
                        var ex4 = new Example4();
                        ex4.Task();
                        break;
                    case 5:
                        var ex5 = new Example5();
                        ex5.Task();
                        break;
                    case 6:
                        var ex6 = new Example6();
                        ex6.Task();
                        break;
                    case 7:
                        var ex7 = new Example7();
                        ex7.Task();
                        break;
                    case 8:
                        var ex8 = new Example8();
                        ex8.Task();
                        break;
                }
                Console.WriteLine("Press any key to continiue... Or input STOP to exit.");
                stop = Console.ReadLine();
                Console.Clear();
            }
            while (stop.ToLower() != "stop");
        }
    }
}