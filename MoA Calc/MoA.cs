using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoA_Calc
{
    class MoA
    {
        double num1, num2, num3;
        public MoA() // Default Constructor
        {
            double num1 = 0.0;
            double num2 = 0.0;
            double num3 = 0.0;
        }
        public MoA(double num1, double num2, double num3) // Parametric Constructor
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }
        public double[] MoAMath(double num1, double num2, double num3) // Math operators for inches per MOA, MOA Degree Adjustment, Clicks required on scope 
        {
            double moainch = num1 / (100);
            double moaAdjust = num2 / moainch;

            double moaScope = num3 / moaAdjust;

            double[] MinuteAngle = new double[3];
            MinuteAngle[0] = moainch;
            MinuteAngle[1] = moaAdjust;
            MinuteAngle[2] = moaScope;

            return MinuteAngle;
        }
        public static void PrintMoa(double[] Minute) // Prints the MoA table
        {       
            Console.WriteLine($"\t Inches per MOA at that distance : {Minute[0]} ");
            Console.WriteLine($"\t MOA adjustment : {Minute[1]} Inches");
            if (!(Minute[2] > 0) & !(Minute[2] < 0))
            {
                Console.WriteLine("No adjustment is needed.");     // Quick catch case if adjustment is 0
            }
            else Console.WriteLine($"\t Adjustment in clicks on scope : {Minute[2]} Clicks");
        }
        
    }
}
