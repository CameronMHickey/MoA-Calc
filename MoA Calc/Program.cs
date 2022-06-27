namespace MoA_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Display title as the C# console calculator app.
            Console.WriteLine("Minute of Angle Conversion\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                // Declare variables and set to empty.
                string numInput1 = "";
                string numInput2 = "";
                string numInput3 = "";

                // Ask the user to type the first number.
                Console.Write("Enter Distance to target in yards: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("This is not valid input. Please enter an integer or double value: ");
                    numInput1 = Console.ReadLine();
                }

                // Ask the user to type the second number.
                Console.WriteLine("Enter number of inches of adjustment needed: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput2 = Console.ReadLine();
                }
                
                Console.Write("Enter number of clicks per 1 MOA on scope: ");
                numInput3 = Console.ReadLine();

                double cleanNum3 = 0;
                while (!double.TryParse(numInput3, out cleanNum3))
                {
                    Console.Write("This is not valid input. Please enter an integer or double value: ");
                    numInput3 = Console.ReadLine();
                }
                MoA.MoAMath(cleanNum1, cleanNum2, cleanNum3);
                

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
        }
    }
}