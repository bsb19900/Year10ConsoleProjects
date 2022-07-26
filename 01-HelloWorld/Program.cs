using System;

namespace _01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Output 'Hello World!' to the console screen by using 'Console.WriteLine();'

            // Declare variables and then initialize to zero.;


            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Blue;

            int num1 = 0; int num2 = 0;

            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");
            
            // Ask the user to type the first number.
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Beep(4000, 1000);

            // Ask the user to type the second number.
            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Beep(4000, 1000);

            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
           
            Console.Write("Your option? ");

            

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
                   

            }
            Console.Beep(4000, 1000);
            Console.Beep(4000, 1000);
            Console.Beep(4000, 1000);
            Console.Beep(4000, 1000);
            Console.Beep(4000, 1000);
            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();

            // 2. Make the program wait for input by using 'Console.ReadLine();'

        }
    }
}


/* ------------------------------------------------------------------------------------------ /

EXTENSION TASKS:

1. Output another message/pause after the ReadLine
2. Research online how to change the colour and/or make the console beep


QUESTIONS:
        
1. What is the difference between input and output?




WHEN FINISHED:

1. Click the Save All button
2. Go to http://www.peergrade.io to submit this Program.cs file
3. Give feedback to two of your classmates, and review the feedback you have received
4. If the feedback suggests that there is room for improvement, you may come back and modify your code / answers

/ ------------------------------------------------------------------------------------------ */