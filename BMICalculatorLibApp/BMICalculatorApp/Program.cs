using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BMICalculatorApp
{
    class Program
    {

        public enum Options
        {
            CONSOLEINPUT = 1, FILEINPUT
        }
        static void Main(string[] args)
        {


            int count = 3;
            Options _choice = default(Options);

            do
            {
                string message = string.Format("Enter Your Choice {0}->ConsoleInput , {1}->FileInput ", Options.CONSOLEINPUT, Options.FILEINPUT); 
                string displayMessage = $"Enter Your Choice {(int)Options.CONSOLEINPUT}->ConsoleInput,{(int)Options.FILEINPUT}->FileInput";
                Console.WriteLine(displayMessage);
                try
                {
                    int choice = (Options)Int32.Parse(Console.ReadLine());

                    if (choice < 1 || choice > 3)
                    {
                        Console.WriteLine("invalid option");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException ex )
                {
                    Console.WriteLine("choice should be number");
                }
                --count;

            }
            while (count > 0);


            switch (choice)
            {
                case Options.CONSOLEINPUT:

            BMIUserInputLib.ConsoleInputReader userInputs = new BMIUserInputLib.ConsoleInputReader();


            BMIValueCalculationLib.CalculateBMI value = new BMIValueCalculationLib.CalculateBMI();
            double BmiValue = value.BmiCalculation(userInputs.GetUserHeight(), userInputs.GetUserWeight());

            BMIValueValidationLib.BmiValueValidation validate = new BMIValueValidationLib.BmiValueValidation();
            string _message = validate.CheckBmiValue(BmiValue);

            BMIResultDisplayLib.MessageDisplay result = new BMIResultDisplayLib.MessageDisplay();
            result.Display(_message);
            Console.ReadKey();

              break;

                case Options.FILEINPUT:

                    string text = System.IO.File.ReadAllText(@"C:\Users\ubedullah.patait\source\repos\BMICalculatorApp\data");
                    Console.WriteLine(text);

                    break;

        }
            

        }
    }
}
