using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class ConsoleInput
    {
        public double GetUserHeight()
        {
            Console.WriteLine("Enter Height In Meters");
            double height = Convert.ToDouble((Console.ReadLine()));
            return height;
        }

        public double GetUserWeight()
        {
            Console.WriteLine("Enter Weight In Kilos");
             double weight = Convert.ToDouble((Console.ReadLine()));
            return weight;
        }
    }
}
