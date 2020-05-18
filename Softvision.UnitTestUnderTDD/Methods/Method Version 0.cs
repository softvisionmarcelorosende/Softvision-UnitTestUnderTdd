using System;

namespace Softvision.UnitTestUnderTDD.Methods
{
    public static partial class MathUtils
    {
        //Version 0 (Initial Implementation)
        public static int Divide(string dividend, string divisor)
        {
            int result = 0;
            Console.WriteLine($"The result of {dividend} / {divisor} is {result} \n");
            return result;
        }
    }
}
