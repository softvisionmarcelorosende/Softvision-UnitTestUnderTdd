//using System;

//namespace Softvision.UnitTestUnderTDD.Methods
//{
//    public static partial class MathUtils
//    {
//        //Version 6
//        public static decimal Divide(string dividend, string divisor)
//        {
//            decimal result = 0;

//            try
//            {
//                result = decimal.Parse(dividend) / decimal.Parse(divisor);
//                Console.WriteLine($"The result of {dividend} / {divisor} is {result} \n");
//            }

//            catch (FormatException)
//            {
//                throw new FormatException("One or more of the argument provided are not numbers");
//            }

//            catch (DivideByZeroException)
//            {
//                throw new DivideByZeroException("Cannot divide by zero");
//            }

//            return result;
//        }
//    }
//}
