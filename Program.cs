using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Quit()
        {
            Environment.Exit(200);
        }// Quick and Simple Exit

        static void Main(string[] args) // Main, we setup the globally used Variables like the List and Input that needs to be sent and handeled elsewhere
        {
            List<string> history = new List<string>();
            string input_1 = " ";
            Menu(history, input_1);
        }

        public static void Menu(List<string> history, string input_1)
        {
            
            int choiceID;
            Console.WriteLine("Press Corresponding Key on your numpad: \n\n\n");
            Console.WriteLine(">> Perform a Calulation       >> 1 <<");
            Console.WriteLine(">> Print the History          >> 2 <<");
            Console.WriteLine(">> Exit the Program           >> 3 <<\n");
            
            while (true)
            {
                var keypress = Console.ReadKey(true);
                if (keypress.Key == ConsoleKey.D1)
                {
                    choiceID = 1;
                    break;
                }
                else if (keypress.Key == ConsoleKey.D2)
                {
                    choiceID = 2;
                    break;
                }
                else if (keypress.Key == ConsoleKey.D3)
                {
                    choiceID = 3;
                    break;
                }
                else if (keypress.Key == ConsoleKey.D4)
                {
                    choiceID = 4;
                    break;
                }
            }

            switch (choiceID)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Enter a Calculation tex.(123*24-2)!");
                    input_1 = Console.ReadLine();
                    Calculate.DoCalculate(history, input_1);
                    
                    break;
                case 2:
                    Console.Clear();
                    ListHistory.PrintOut(history);
                   
                    break;
                case 3:
                    Quit();
                    break;
            }



        }



        
    }
}