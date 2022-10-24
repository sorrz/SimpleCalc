using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ListHistory
    {

        
        public static void PrintOut(List<string> history)
        {
            
            int j = 1;
            string a = " ";
            foreach (var item in history)
            {
                Console.WriteLine(j + ": " + item);
                j++;
            }
            Program.Menu(history, null);
        }
    }
}
