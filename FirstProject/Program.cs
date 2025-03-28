using System;
using System.Text;
using System.Threading.Channels;

namespace FirstProject
{
    public class GradeCalculator
    {
        public static string CalculateGreade(double percentage)
        {
            if (percentage >= 90)
            {
                return "A";
            }
            else if (percentage >= 80)
            {
                return "B";
            }
            else if (percentage >= 70)
            {
                return "C";
            }
            else if (percentage >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

    }

    class Program
    {

        static void Main()
        {
   
            string result = GradeCalculator.CalculateGreade(70);

            Console.WriteLine(result);
        }
           
    }
}
