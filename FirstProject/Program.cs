using System;
using System.Text;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            byte byteValue = 100;
            int intValue = byteValue;

            byte byteValue2 = (byte)intValue;

            double doubleValue = 3.5; 
            int intValue2 = (int)doubleValue;

            string stringValue2 = intValue2.ToString(); 
 

            Console.WriteLine("Please enter your year of birth:");

            string userInput = Console.ReadLine();
            int yearOfBirth;
            int age;


            if (int.TryParse(userInput, out yearOfBirth))
                
            {
                age = DateTime.Now.Year - yearOfBirth;
                Console.WriteLine($"You are {age}");
            }
            else
            {
                
                Console.WriteLine($"Incorrect value");
            }
            
        }
    }
}