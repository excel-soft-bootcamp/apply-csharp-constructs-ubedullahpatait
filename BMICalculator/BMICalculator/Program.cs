using System;
namespace BMICalculator
{
    class Program
    {
        static void Main()
        {


            ConsoleInput input = new ConsoleInput();
            double height = input.GetUserHeight();
            double weight = input.GetUserWeight();

            CalculateBMI calculateRef = new CalculateBMI();
            double bmiValue = calculateRef.BmiCalculation(height, weight);

            ValidateUserInput validatRef = new ValidateUserInput();
            string result = validatRef.CheckBmiValue(bmiValue);

            Display displayRef = new Display();
            displayRef.ConsoleDisplay(result);


            Console.ReadKey();
        }
    }
}

