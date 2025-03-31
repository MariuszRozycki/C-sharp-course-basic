using System;

namespace FirstProject

{

    class Program
    {

        static void Main()
        {
            int? favoriteNumber = default;

            Console.WriteLine("Favorite number: " + (favoriteNumber.HasValue ? favoriteNumber : ""));
    }
}
}