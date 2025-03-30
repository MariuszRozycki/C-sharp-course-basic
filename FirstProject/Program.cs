using System;

namespace FirstProject
{
    class IteratingThroughInputData
    {
        static void Main()
        {
            Console.WriteLine("Insert numbers: ");

            int userInput = int.Parse(Console.ReadLine());

            int sum = 0;
            int? maxValue = null;

            while (userInput != 0)
            {
                if (maxValue == null || userInput > maxValue)
                {
                    maxValue = userInput;
                }
                sum += userInput;

                userInput = int.Parse(Console.ReadLine());

            }

            Console.WriteLine($"Sum of numbers: {sum}");

            if (maxValue != null)
            {
                Console.WriteLine($"Max value: {maxValue}");
            } else
            {
                Console.WriteLine("No values inserted!");
            }
            
        }
    }
}
