using System;
using System.Text;
using System.Threading.Channels;

namespace FirstProject

{

    class Program
    {
        public class ParkingCalculator
        {
            public static double CalculateParkingFee(int hours)
            {
                double result = 0;

                switch (hours)
                {
                    case 0:
                        result = 0;
                        break;

                    case 1:
                        result = 5;
                        break;

                    default:
                        result = 5 + (hours - 1) * 3;
                        break;
                }

                
             
                return result;
            }
        }

        static void Main()
        {
            int hours = 3;
            double result = ParkingCalculator.CalculateParkingFee(hours);

            Console.WriteLine($"You have to pay {result} PLN for {hours} hours.");
        }
}
}