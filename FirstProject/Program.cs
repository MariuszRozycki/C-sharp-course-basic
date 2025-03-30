using System;

namespace FirstProject
{
    public class IteratingThroughInputData
    {
        public static void Run()
        {
            Console.WriteLine("Podawaj liczby (0 kończy działanie):");

            int sum = 0;
            int max = int.MinValue;

            int userInput;

            do
            {
                Console.Write("Liczba: ");
                string input = Console.ReadLine();

                // Próbujemy zamienić wpisany tekst na liczbę
                if (int.TryParse(input, out userInput))
                {
                    if (userInput != 0)
                    {
                        sum += userInput;

                        if (userInput > max)
                        {
                            max = userInput;
                        }

                        Console.WriteLine($"Echo: {userInput}");
                    }
                }
                else
                {
                    Console.WriteLine("To nie jest liczba. Spróbuj ponownie.");
                }

            } while (userInput != 0);

            Console.WriteLine("--------------------------");
            Console.WriteLine($"Suma: {sum}");
            Console.WriteLine($"Największa liczba: {max}");
        }

        static void Main()
        {
            Run();
        }
    }
}
