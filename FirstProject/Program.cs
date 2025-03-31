using System;

namespace FirstProject

{

    class Program
    {

        static void Main()
        {
            string[] cars = { "Volvo", "BMW", "Mazada" };

            try
            {
                Console.WriteLine("Inside try - 1");
                cars[4] = "Tesla";   // code that might thrown exeption
                Console.WriteLine("Inside try - 2");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("HandlingIndexOutOfRangeException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Handling any exception");
            }
            finally
            {
                Console.WriteLine("CleanUp");
            }
            Console.WriteLine("Outside of try-catch");
        }
    }
}