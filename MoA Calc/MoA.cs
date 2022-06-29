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
        public double[] MoAMath(MoA moA) // Creates Array and computes the values for the MoA table
        {
            double holder = 100.0;
            double[] MinuteAngle = new double[] { moA.num1, moA.num2, moA.num3 };  // Create an Array to iterate through
            for (int i = 0; i < MinuteAngle.Length; i++)                           // For loop computes the values for the MoA
            {
               MinuteAngle[i] = MinuteAngle[i] / holder;
               holder = MinuteAngle[i];  
            }
            return MinuteAngle;
        }
        public static void PrintMoa(double[] Minute) // Prints the MoA table
        {       
            Console.WriteLine($"\t Inches per MOA at that distance : {Minute[0]} ");
            Console.WriteLine($"\t MOA adjustment : {Minute[1]} Degrees ");
            if (!(Minute[2] > 0) & !(Minute[2] < 0))
            {
                Console.WriteLine("No adjustment is needed.");     // Quick catch if adjustment is 0
            }
            else Console.WriteLine($"\t Adjustment in clicks on scope : {Minute[2]} Clicks ");
        } 
    }
}
