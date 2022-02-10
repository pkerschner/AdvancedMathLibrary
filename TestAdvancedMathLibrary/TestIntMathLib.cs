
using AdvancedMathLibrary;
using Xunit;

namespace TestAdvancedMathLibrary {
    public class TestIntMathLib {

        [Fact]
        public void TestDivideByZero() {
            System.Action ZeroDenominator = () => Math.Divide(1, 0);
            Assert.Throws<System.DivideByZeroException>(ZeroDenominator);
        }

        [Theory]
        [InlineData(-10, 10, 20)]
        [InlineData(10, 20, 10)]
        [InlineData(10, 10, 0)]
        public void TestSubtract(int expected, int a, int b) {
            Assert.Equal(expected, Math.Subtract(a, b));
        }
        
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 5, -5)]
        [InlineData(-10, 15, -25)]
        public void TestAdd(int expected, int a, int b) {
            Assert.Equal(expected, Math.Add(a, b));
        }
        
        [Theory]
        [InlineData(-3, 3)]
        [InlineData(3, 3)]
        [InlineData(0, 0)]
        public void TestAbsoluteValue(int input, int expected) {
            Assert.Equal(expected, Math.AbsoluteValue(input));
        }
        [Fact]
        public void TestZeroConstant() {
            Assert.Equal(0, Math.Zero);
        }
    }
}
