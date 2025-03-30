using System;
using System.Text;

namespace FirstProject
{
    public class TemperatureAnalyzer
    {
        public static int FindHighestTemperature(int[] temperatures)
        {
            int highestTemperature = temperatures[temperatures.Length - 1];
            foreach (int temperature in temperatures)
            {
                if (temperature > highestTemperature)
                {
                    highestTemperature = temperature;
                }
            }
            return highestTemperature;
        }

        public static int FindLowestTemperature(int[] temperatures)
        {
            int lowestTemperature = temperatures[0];
            foreach (int temperature in temperatures)
            {
                if (temperature < lowestTemperature)
                {
                    lowestTemperature = temperature;
                }
            }
            return lowestTemperature;
        }
    
    
    
 
    
        static void Main(string[] args)
        {
            int[] temperatures = { 50, 220, 30, 25, 21 };
            
        int resultHighest = TemperatureAnalyzer.FindHighestTemperature(temperatures);

            Console.WriteLine($"Highest temperatur: {resultHighest}");

            Console.WriteLine("**************");

        int resultLowest = TemperatureAnalyzer.FindLowestTemperature(temperatures);

            Console.WriteLine($"Lowest temperatur: {resultLowest}");
        }
    }
}
