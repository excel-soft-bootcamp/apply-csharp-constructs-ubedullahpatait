using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputValuesLib
{
    public class InputValueType
    {
        public static float SetHeight()
        {
            ConsoleDisplayLib.ConsoleDisplayType.Display("Enter Height In Meters");
            float height = float.Parse(Console.ReadLine());
            return height;

        }
        public static float SetWeight()
        {
            ConsoleDisplayLib.ConsoleDisplayType.Display("Enter Weight In Kilos");
            float weight = float.Parse(Console.ReadLine());
            return weight;
        }
    }
}
