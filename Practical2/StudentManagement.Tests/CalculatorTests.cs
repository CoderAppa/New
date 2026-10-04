using Xunit;
using StudentManagement;

namespace StudentManagementTests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            Calculator c = new Calculator();
            int result = c.Add(10, 20);
            Assert.Equal(30, result);
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            Calculator c = new Calculator();
            int result = c.Multiply(5, 4);
            Assert.Equal(20, result);
        }

        [Theory]
        [InlineData(10, 20, 30)]
        [InlineData(5, 5, 10)]
        [InlineData(100, 50, 150)]
        public void Add_TestCases(int a, int b, int expected)
        {
            Calculator c = new Calculator();
            int result = c.Add(a, b);
            Assert.Equal(expected, result);
        }
    }
}
