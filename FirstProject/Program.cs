using System;

namespace FirstProject

{

    class Program
    {

        static void Main()
        {
            switch(DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("It's Monday - first day of week...");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("It's Friday - the last day of the work week!");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("It's a weekend!");
                    break;
                default:
                    Console.WriteLine("The middle of the week");
                    break;
            }
        }        
    }
}
