using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIUserInputLib
{
    public class ConsoleInputReader
    {

        public double GetUserHeight()
        {
            Console.WriteLine("Enter Height In Meters");
            double height = double.Parse(Console.ReadLine());
            return height;
        }

        public double GetUserWeight()
        {
            Console.WriteLine("Enter Weight In Kilos");
            double weight = double.Parse(Console.ReadLine());
            return weight;
        }
       

    }
}
