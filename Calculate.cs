using System.Data;

namespace ConsoleApp1
{
    internal class Calculate
    {
        public static void DoCalculate(List<string> history, string input_1)        // <--- Bring the List history, and the global input from user.
        {


            try
            {
                string value = new DataTable().Compute(input_1, null).ToString(); 
                
                if (!string.IsNullOrWhiteSpace(value))                                                       // Build a new string of the input made from user, after it being calculated by the Core.
                {
                    Console.WriteLine("Sorry, we are not equipped to handle 0-division.\n" +
                    "Taking you back to Main Menu\n");
                    Thread.Sleep(1500);
                    Program.Menu(history, input_1);
                }

                Console.Write("  =  " + value);                                               // <--- Print the Calulated Value
                Console.WriteLine("\n\n\n");
                history.Add(input_1 + " = " + value);                                   // <--- Add the Input from User and = Output to the history List
                Program.Menu(history, null);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Sorry, we are not equipped to handle 0-division.\n" +
                    "Taking you back to Main Menu\n");
                Thread.Sleep(1500);
                Program.Menu(history, input_1);
            }    
                 


        }
    }
}
