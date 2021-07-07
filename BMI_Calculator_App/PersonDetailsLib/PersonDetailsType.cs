using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDetailsLib
{
    public class PersonDetailsType
    {
        public static float GetHeight()
        {
            return InputValuesLib.InputValueType.SetHeight();

        }
        public static float GetWeight()
        {
            return InputValuesLib.InputValueType.SetWeight();
        }
    }
}
