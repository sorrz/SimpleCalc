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
        public static void DoCalculate(List<string> history, string input_1)
        {
            
            try
            {

                string value = new DataTable().Compute(input_1, null).ToString();
                Console.WriteLine(value);
                history.Add(input_1 + " = " + value);
                Program.Menu(history, null);
            }
            catch
            {
                Console.WriteLine("Sorry, we're not equipped to handle letters or Non-numeric Operators!");
                Program.Menu(history, null);
            }
        }
    }
}
