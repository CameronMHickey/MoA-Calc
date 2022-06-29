namespace MoA_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Display title.
            Console.WriteLine("Minute of Angle Conversion\r");
            Console.WriteLine();
            Console.WriteLine("For scope adjustment.");
            Console.WriteLine("------------------------\n");


            while (!endApp)
            {
                // Declare variables and set to empty.
                string numInput1 = "";
                string numInput2 = "";
                string numInput3 = "";

                // Ask the user to type Distance.
                Console.Write("Enter Distance to target in yards: ");
                numInput1 = Console.ReadLine();

                double testNum1 = 0;
                while (!double.TryParse(numInput1, out testNum1))
                {
                    Console.Write("This is not valid number. Please enter an integer or double value: ");
                    numInput1 = Console.ReadLine();
                }

                // Ask the user to type Inches of adjustment.
                Console.WriteLine("Enter number of inches of adjustment needed (Use Negative for left) : ");
                numInput2 = Console.ReadLine();

                double testNum2 = 0;
                while (!double.TryParse(numInput2, out testNum2))
                {
                    Console.Write("This is not valid number. Please enter an integer or double value: ");
                    numInput2 = Console.ReadLine();
                }
                // Ask user to input clicks per MOA on their scope
                Console.Write("Enter number of clicks per 1 MOA on scope: ");
                numInput3 = Console.ReadLine();

                double testNum3 = 0;
                while (!double.TryParse(numInput3, out testNum3))
                {
                    Console.Write("This is not valid number. Please enter an integer or double value: ");
                    numInput3 = Console.ReadLine();
                }
                MoA moA = new MoA(testNum1,testNum2,testNum3);
                MoA.PrintMoa(moA.MoAMath(moA));

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'Q' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "Q") endApp = true;
            }
            return;
        }
    }
}
