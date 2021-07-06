using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input
{
    public class UserInput
    {

        public float _UserInput()
        {
            Console.WriteLine("Enter height in meters ");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter weight in KG ");
            float weight = float.Parse(Console.ReadLine());

            BmiCalculate bmi = new BmiCalculate();
            float calculateHeightAndWeight = bmi.Calculate(height, weight);

            return calculateHeightAndWeight;
        }
    }
}
