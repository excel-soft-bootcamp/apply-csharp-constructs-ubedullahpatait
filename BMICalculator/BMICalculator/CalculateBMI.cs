using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class CalculateBMI
    {
        public double BmiCalculation(double height, double weight)
        {
            double bmiValue = weight / height;
            return bmiValue;
        }
    }
}
