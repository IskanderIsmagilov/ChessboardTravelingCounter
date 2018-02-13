using System;
//string input represents start and finish points. For example "(1 1)(3 3)".
namespace Namespace1
{
    class MainClass
    {
        public static int ChessboardTraveling(string str)
        {
            int firstOpen = str.IndexOf('(');
            int firstSpace = str.IndexOf(' ');
            int firstClosed = str.IndexOf(')');
            int secondOpen = str.LastIndexOf('(');
            int secondSpace = str.LastIndexOf(' ');
            int secondClosed = str.LastIndexOf(')');

            long xFactorial, yFactorial, sumXYFactorial;

            int x = int.Parse(str.Substring(firstOpen + 1, firstSpace - (firstOpen + 1)));
            int y = int.Parse(str.Substring(firstSpace + 1, firstClosed - (firstSpace + 1)));
            int a = int.Parse(str.Substring(secondOpen + 1, secondSpace - (secondOpen + 1)));
            int b = int.Parse(str.Substring(secondSpace + 1, secondClosed - (secondSpace + 1)));

            x = Math.Abs(a - x);
            y = Math.Abs(b - y);

            xFactorial = factorial_Recursion(Convert.ToInt64(x));
            yFactorial = factorial_Recursion(Convert.ToInt64(y));
            sumXYFactorial = factorial_Recursion(Convert.ToInt64(x + y));

            return Convert.ToInt32(sumXYFactorial / (xFactorial * yFactorial));
        }

        public static long factorial_Recursion(long number)
        {
            if (number == 1)
                return 1;
            else
                return number * factorial_Recursion(number - 1);
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(ChessboardTraveling(Console.ReadLine()));
        }
    }
}
