using System;
using System.Globalization;

namespace FirstProject

{
    public class BmiCalculator
    {
        public static string CalculateBmiCategory(double bmi)
        {
            if (bmi <= 18.5)
            {
                return "underweight";
            }
            else if (bmi <= 24.9)
            {
                return "normal weight";
            }
            else if (bmi <= 29.9)
            {
                return "overweight";
            }
            else if (bmi <= 34.9)
            {
                return "obesity";
            }
            else if (bmi >= 35)
            {
                return "massive obesity";
            }

            return "No values";
        }

        class Program
        {
            static void Main()
            {
                Console.WriteLine("Type your weight in kg");
                string userInputWeight = Console.ReadLine();
                userInputWeight = userInputWeight.Replace(",", ".");
                double userWeight;

                if (double.TryParse(userInputWeight, NumberStyles.Float, CultureInfo.InvariantCulture, out userWeight))
                {
                    Console.WriteLine($"User weight is {userWeight} in kg");
                }
                else
                {
                    Console.WriteLine("Incorrect value");
                    return;
                }

                Console.WriteLine("Type your height in meter");

                string userInputHeihgt = Console.ReadLine();
                userInputHeihgt = userInputHeihgt.Replace(",", ".");
                double userHeight;

                if (double.TryParse(userInputHeihgt, NumberStyles.Float, CultureInfo.InvariantCulture, out userHeight))
                {

                    if (userHeight > 3)
                    {
                        userHeight = userHeight / 100;
                        Console.WriteLine($"User height converted from cm: {userHeight} meters.");
                    }

                    Console.WriteLine($"User height is {userHeight} meter");
                }
                else
                {
                    Console.WriteLine("Incorrect height value.");
                }

                

                double bmi = userWeight / (userHeight * userHeight);
                Console.WriteLine($"Your BMI is {bmi}");

                string bmiDetailed = BmiCalculator.CalculateBmiCategory(bmi);
                Console.WriteLine($"User BMI is {bmi}. That means user has {bmiDetailed}.");

            }
        }
    }
}