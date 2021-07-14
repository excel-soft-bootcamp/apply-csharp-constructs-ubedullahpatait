using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class ValidateUserInput
    {

        public string CheckBmiValue(double bmiValue)
        {
            if (bmiValue < 18.5)
                return "underweight";
            else if (bmiValue >= 25)
                return "overweight";
            else
              return "healthy";
        }
    }
}
