using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            bool   validAnswer       = false;
            string inputTempType     = null;
            double inputTemperature  = 0;
            string outputTempType    = null;            
            double outputTemperature = 0;

            // Ask the user for what temperature to convert from (F/C).
            while (!validAnswer)
            {
                Console.Write("Enter what temperature type you want to convert from - (F/C): ");
                inputTempType = Console.ReadLine();

                // Validate user input
                validAnswer = inputTempType.Equals("F") || inputTempType.Equals("C");
                if (!validAnswer)
                {
                    Console.WriteLine(inputTempType + " is not a valid answer. Please try again");
                }
            }

            // Collect input temperature
            Console.Write("Enter the temperature in " + inputTempType + ": ");
            inputTemperature = double.Parse(Console.ReadLine());

            // Convert the temperature
            if (inputTempType.Equals("F"))
            {
                //convert to C
                outputTempType = "C";
                outputTemperature = F2C(inputTemperature);
            }
            else
            {
                //conver to F
                outputTempType = "F";
                outputTemperature = C2F(inputTemperature);
            }

            // Print the result
            Console.WriteLine("This temperature in " + outputTempType + " is: " + outputTemperature.ToString());
        }

        public static double C2F(double C)
        {
            double F;
            F = (C * 1.8 + 32);
            return F;
        }
        public static double F2C(double F)
        {
            double C;

            C = ((F - 32) / 1.8);
            return C;
        }
    }
}