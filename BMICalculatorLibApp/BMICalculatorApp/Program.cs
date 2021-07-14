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

            do
            {

                string displayMessage = $"Enter Your Choice {(int)Options.CONSOLEINPUT}->ConsoleInput,{(int)Options.FILEINPUT}-->FileInput";

                Console.WriteLine(displayMessage);

                try
                {

                    Options _choice = (Options)Convert.ToInt32(Console.ReadLine());
                    if (_choice == Options.CONSOLEINPUT || _choice == Options.FILEINPUT)
                    {


                        switch (_choice)
                        {
                            case Options.CONSOLEINPUT:

                                BMIUserInputLib.ConsoleInputReader userInputs = new BMIUserInputLib.ConsoleInputReader();


                                BMIValueCalculationLib.CalculateBMIType value = new BMIValueCalculationLib.CalculateBMIType();
                                double bmiValue = value.BmiCalculation(userInputs.GetUserHeight(), userInputs.GetUserWeight());

                                BMIValueValidationLib.BmiValueValidation validate = new BMIValueValidationLib.BmiValueValidation();
                                string _message = validate.CheckBmiValue(bmiValue);


                                BMIResultDisplayLib.MessageDisplay.Display(_message);
                                Console.ReadKey();


                                break;

                            case Options.FILEINPUT:
                                string line;
                                System.IO.StreamReader path= new System.IO.StreamReader(@"C:\Users\ubedullah.patait\source\repos\BMICalculatorApp\data.csv");


                                while ((line = path.ReadLine()) != null)
                                {
                                    string[] column = { };
                                    column = line.Split(',');
                                    string name = column[0];
                                    float height = float.Parse(column[1]);
                                    float weight = float.Parse(column[2]);

                                    BMIValueCalculationLib.CalculateBMIType value1 = new BMIValueCalculationLib.CalculateBMIType();
                                    double _bmiValue = value1.BmiCalculation(height, weight);


                                  BMIValueValidationLib.BmiValueValidation _validate = new BMIValueValidationLib.BmiValueValidation();
                                       

                                    String Result = _validate.CheckBmiValue(_bmiValue);
                                    Console.WriteLine("Name   Height   Weight             Result");
                                    Console.WriteLine(name + "    " + height + "          " + weight + "             " + Result);
                                }

                                break;
                                path.Close();



                        }

                    }
                    else
                    {
                        Console.WriteLine("invalid option");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("choice should be number");
                }
                --count;

            }
            while (count > 0);
            Console.ReadKey();
        }
    }
}

