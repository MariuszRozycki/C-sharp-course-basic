using System;

namespace FirstProject

{

    class Program
    {

        static void Main()
        {
            Console.WriteLine("Insert bithday");
            Console.WriteLine("Insert the day: ");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert bithday");
            Console.WriteLine("Insert the month: ");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert bithday");
            Console.WriteLine("Insert the year: ");
            int year = int.Parse(Console.ReadLine());

            DateTime dateOfBirth = new DateTime(year, month, day);

            TimeSpan timeSpan = DateTime.Now - dateOfBirth;

            Console.WriteLine($"You were born: {timeSpan.TotalDays} days ago.");
        }
    }
}