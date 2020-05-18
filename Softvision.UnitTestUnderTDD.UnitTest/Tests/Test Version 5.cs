//using System;
//using Softvision.UnitTestUnderTDD.Methods;
//using Xunit;

//namespace Softvision.UnitTestUnderTDD.UnitTest.Tests
//{
//    public partial class ProgramTest
//    {
//        //Version 3 - Refactor
//        [Theory]
//        [InlineData("10", "2", 5)]
//        [InlineData("20", "2", 10)]
//        [InlineData("21", "3", 7)]
//        public void GivenDivideMethod_WhenValidInput_ShouldReturnQuotient(string dividend, string divisor, int expectedQuotient)
//        {
//            //Act
//            var actualQuotient = MathUtils.Divide(dividend, divisor);

//            //Assert
//            Assert.Equal(expectedQuotient, actualQuotient);
//        }

//        //Version 4
//        [Fact]
//        public void GivenDivideMethod_WhenInputIsNotANumber_ShouldThrowFormatException()
//        {
//            //Arrange
//            var dividend = "10";
//            var divisor = "a";

//            //Act
//            var ex = Assert.Throws<FormatException>(() => MathUtils.Divide(dividend, divisor));

//            //Assert
//            Assert.IsType<FormatException>(ex);
//            Assert.Equal("One or more of the argument provided are not numbers", ex.Message);
//        }

//        //Version 5
//        [Fact]
//        public void GivenDivideMethod_WhenInputIsZero_ShouldThrowDivideByZeroException()
//        {
//            //Arrange
//            var dividend = "10";
//            var divisor = "0";

//            //Act
//            var ex = Assert.Throws<DivideByZeroException>(() => MathUtils.Divide(dividend, divisor));

//            //Assert
//            Assert.IsType<DivideByZeroException>(ex);
//            Assert.Equal("Cannot divide by zero", ex.Message);
//        }
//    }
//}
