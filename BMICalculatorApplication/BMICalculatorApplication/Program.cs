using Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidateUserInput;

namespace BMICalculatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput input = new UserInput();
            float showMessage = input._UserInput();

            Validate validateStatus = new Validate();
            String display = validateStatus.DisplayMessage(showMessage);
            Console.WriteLine( display);
        }
    }
}
