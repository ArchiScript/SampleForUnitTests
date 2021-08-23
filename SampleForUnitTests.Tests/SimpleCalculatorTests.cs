using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SampleForUnitTests.Tests
{
    public class SimpleCalculatorTests
    {
        [Fact]
        public void GetSum_2_Plus_5_Eq_7()
        {
            //Arrange
            SimpleCalculator calculator = new SimpleCalculator();
            //Act 
            var result = calculator.GetSum(2, 5);

            //Assert;
            Assert.Equal(7, result);
        }
        [Fact]

        public void GetSubstruct_5_Min_2_Eq_3() {
        // Arrange
            SimpleCalculator calculator = new SimpleCalculator();
            //Act 
            var result = calculator.GetSubstract(2, 5);

            //Assert;
            Assert.Equal(7, result);
        }
    }
}
