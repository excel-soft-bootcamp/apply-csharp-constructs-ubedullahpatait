using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateBMI
{
    public class BmiCalculate
    {

        public float Calculate(float height, float weight)
        {
            float BMI = weight / height;
            return BMI;
        }
    }
}
