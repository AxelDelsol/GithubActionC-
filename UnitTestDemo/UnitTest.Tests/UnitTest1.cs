using System;
using Xunit;

namespace UnitTest.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.False(false);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(2)]
        [InlineData(4)]
        public void Test_IsEven(int number)
        {
            Assert.True(UnitTestDemo.Parity.IsEven(number));
        }


        [Theory]
        [InlineData(-1)]
        [InlineData(3)]
        [InlineData(25)]
        public void Test_IsOdd(int number)
        {
            Assert.True(UnitTestDemo.Parity.IsOdd(number));
        }
    }
}
