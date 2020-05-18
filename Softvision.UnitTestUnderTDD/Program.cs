using System;
using Softvision.UnitTestUnderTDD.Methods;

namespace Softvision.UnitTestUnderTDD
{
    public static partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! \nplease choose a dividend");
            var dividend = Console.ReadLine();
            Console.WriteLine("Now choose a divisor");
            var divisor = Console.ReadLine();
            MathUtils.Divide(dividend, divisor);
        }
    }
}
