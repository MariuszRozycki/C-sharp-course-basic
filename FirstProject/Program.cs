using System;
using System.Globalization;

namespace FirstProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert your birthday (format: dd.MM.yyyy):");

            string dateOfBirthString = Console.ReadLine();

            if (DateTime.TryParseExact(
                    dateOfBirthString,
                    "dd.MM.yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime dateOfBirth))
            {
                TimeSpan timeSpan = DateTime.Now - dateOfBirth;
                Console.WriteLine($"You were born: {Math.Floor(timeSpan.TotalDays)} days ago.");
            }
            else
            {
                Console.WriteLine("Invalid date format! Please use the format: dd.MM.yyyy (e.g. 31.03.2025)");
            }
        }
    }
}
