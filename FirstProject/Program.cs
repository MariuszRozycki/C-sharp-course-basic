using System;

namespace FirstProject

{

    class Program
    {

        static void Main()
        {
            Console.WriteLine("Type in your name:");

            string name = Console.ReadLine();

            Console.WriteLine("Hello");
            Console.WriteLine(name);

            string someText = "Some text";

            char jChar = 'j';
            char jCharUnicode = '\u006A';

            bool isUserReady = true;

            DateTime now = DateTime.Now;

            Console.WriteLine(now.ToString());
            DateTime dateOfBirth = new DateTime(1983, 4, 20);

            Console.WriteLine(dateOfBirth.ToString());

            byte byteNumber = 200;
            float floatNumber = 1.5F;
            decimal decimalNumber = 1.5M;
            double doubleNumber = 1.5;
    }
}
}