using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float heightValue = PersonDetailsLib.PersonDetailsType.GetHeight();
            float weightValue = PersonDetailsLib.PersonDetailsType.GetWeight();

            float bmiValue = CalculatorLib.CalculatorType.Calculator(weightValue, heightValue);

            string consoleMessage = ValidatorLib.ValidatorType.Validate(bmiValue);
            ConsoleDisplayLib.ConsoleDisplayType.Display(consoleMessage);
            Console.ReadLine();
        }
    }
}
