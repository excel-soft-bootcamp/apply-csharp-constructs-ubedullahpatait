using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIResultDisplayLib
{
    public class MessageDisplay
    {

        public static void Display(string message)
        {

            Console.WriteLine(message);
        }

        public static double ReadFromConsole()
        {
            double value = Convert.ToDouble(Console.ReadLine());
            return value;
        }

    }
}
