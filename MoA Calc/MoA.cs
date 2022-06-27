using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoA_Calc
{
    class MoA
    {
        public static void MoAMath(double num1, double num2, double num3)
        {
            double moainch = num1 / (100);
            double moaAdjust = num2 / moainch;
            double moaScope = num3 / moaAdjust;

            Console.WriteLine($"Inches per MOA at {num1} is {moainch} inches.");
            Console.WriteLine($"MOA adjustment is {moaAdjust}");
            Console.WriteLine($"Number of clicks for scope adjustment is {moaScope}");

        }
    }
}
