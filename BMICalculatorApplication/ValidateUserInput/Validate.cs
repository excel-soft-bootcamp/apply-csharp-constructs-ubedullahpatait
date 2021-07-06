﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateUserInput
{
    public class Validate
    {

        public String DisplayMessage(float bmi)
        {
            if (bmi < 18.5)
                return "underweight";
            else if (bmi >= 25)
                return "overweight";
            else
                return "healthy";

        }
    }
}
