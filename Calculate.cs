using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculate
    {
        public static void DoCalculate(List<string> history, string input_1) // <--- Bring the List history, and the global input from user.
        {
            
            try
            {

                string value = new DataTable().Compute(input_1, null).ToString();       // Build a new string of the input made from user, after it being calculated by the Core.
                Console.WriteLine(value);                                               // <--- Print the Calulated Value
                history.Add(input_1 + " = " + value);                                   // <--- Add the Input from User and = Output to the history List
                Program.Menu(history, null);                                            // return to Menu
            }
            catch
            {
                Console.WriteLine("Sorry, we're not equipped to handle letters or Non-numeric Operators!\n" +
                    "Taking you back to Main Menu");   // Failed imput prompts a fault, and returns the user to Menu
                Thread.Sleep(2000);
                Program.Menu(history, null); 
            }
        }
    }
}
