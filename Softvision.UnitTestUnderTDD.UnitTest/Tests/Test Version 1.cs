using Softvision.UnitTestUnderTDD.Methods;
using Xunit;

namespace Softvision.UnitTestUnderTDD.UnitTest.Tests
{
    public partial class ProgramTest
    {
        //Version 1
        [Fact]
        public void GivenDivideMethod_WhenValidInput_ShouldReturnQuotient()
        {
            //Arrange
            var dividend = "10";
            var divisor = "2";
            var expectedQuotient = 5;

            //Act
            var actualQuotient = MathUtils.Divide(dividend, divisor);

            //Assert
            Assert.Equal(expectedQuotient, actualQuotient);
        }
    }
}
