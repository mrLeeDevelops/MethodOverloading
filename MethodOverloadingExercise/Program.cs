using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool a)
        {
            var total = x + y;
            if(a == true && total > 1)
            {
                return $"{total} dollars.";
            }
            else if(a == true && total == 1) 
            {
                return $"{total} dollar.";
            }
            else
            {
                return total.ToString();
            }
        }

        static void Main(string[] args)
        {
            var a = 31;
            var b = 32;
            var dollarAmount = Add(a, b);

            var c = 55.50m;
            var d = 65.00m;
            var decimalDollarAmount = Add(c, d);

            var lastMethodAns = Add(0, 1, true);

            Console.WriteLine($"Amount  = ${dollarAmount}");
            Console.WriteLine($"Amount =  ${decimalDollarAmount}");
            Console.WriteLine($"Amount = ${lastMethodAns}");
        }
    }
}
