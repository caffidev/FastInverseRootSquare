using System;
using Xunit;

namespace FastInverseRootSquare.Tests
{
    public class UnitTest1
    {
        private double dNumber1 = 4, dNumber2 = 1024, dNumber3 = 1;
        private float fNumber1 = 4, fNumber2 = 1024, fNumber3 = 1;

        [Theory]
        [InlineData(4d, .5d)]
        [InlineData(25d, .2d)]
        [InlineData(1d, 1d)]
        [InlineData(100d, .1d)]
        public void Double_UsualReverse1(double x, double expected)
        {
            var actual = Program.UsualInverseSquareRoot(x);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4f, .5f)]
        [InlineData(25f, .2f)]
        [InlineData(1f, 1f)]
        [InlineData(100f, .1f)]
        public void Float_UsualReverse(float x, float expected)
        {
            var actual = Program.UsualInverseSquareRoot(x);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4f, .5f)]
        [InlineData(25f, .2f)]
        [InlineData(1f, 1f)]
        [InlineData(100f, .1f)]
        public void Float_QuakeReverse(float x, float expected)
        {
            var actual = Program.QuakeInverseSquareRoot(x);

            actual = (float) Math.Round(actual, 1);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4f, .5f)]
        [InlineData(25f, .2f)]
        [InlineData(1f, 1f)]
        [InlineData(100f, .1f)]
        public void Float_FastReverse(float x, float expected)
        {
            var actual = Program.FastInverseSquareRoot(x);

            actual = (float)Math.Round(actual, 1);

            Assert.Equal(expected, actual);
        }
    }
}
