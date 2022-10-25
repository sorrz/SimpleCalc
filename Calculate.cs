using System.Data;

namespace ConsoleApp1
{
    internal class Calculate
    {
        public static void DoCalculate(List<string> history, string input_1)        // <--- Bring the List history, and the global input from user.
        {


            try
            {
                string value = new DataTable().Compute(input_1, null).ToString();       // Build a new string of the input made from user, after it being calculated by the Core.
                Console.WriteLine(value);                                               // <--- Print the Calulated Value
                Console.WriteLine("\n\n\n");
                history.Add(input_1 + " = " + value);                                   // <--- Add the Input from User and = Output to the history List
                Program.Menu(history, null);
            }
            catch (FormatException)
            {
                Console.WriteLine("Sorry, You've entered an invalid form of calculation.\n" +
                            "Please use digits and operators. No letters or whitespace.\n\n");
                Program.Menu(history, input_1);
            }    
                 


        }
    }
}
