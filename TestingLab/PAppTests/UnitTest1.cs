
public class CalculationsTests
{
    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(0, 5, 0)]
    [InlineData(-5, 3, -15)]
    [InlineData(10, 10, 100)]
    public void TestMultiply(double a, double b, double expected)
    {
        Assert.Equal(expected, Calculations.Multiply(a, b));
    }

    [Theory]
    [InlineData(6, 3, 2)]
    [InlineData(10, 5, 2)]
    [InlineData(5, 2, 2.5)]
    [InlineData(1, 2, 0.5)]
    public void TestDivide(double a, double b, double expected)
    {
        if (b == 0)
        {
            Assert.Throws<DivideByZeroException>(() => Calculations.Divide(a, b));
        }
        else
        {
            Assert.Equal(expected, Calculations.Divide(a, b));
        }
    }

    [Theory]
    [InlineData(0, 0, 3, 4, 5)]
    [InlineData(2, 2, 2, 2, 0)]
    [InlineData(1, 1, 3, 3, 2.828)]
    public void TestDistance(double x1, double y1, double x2, double y2, double expected)
    {
        Assert.Equal(expected, Calculations.Distance(x1, y1, x2, y2), 3);
    }

    [Theory]
    [InlineData(1, 2, 3, 7)]
    [InlineData(1, 1, 3, 3)]
    [InlineData(1, 2, 5, 31)]
    public void TestGeometricSum(double a, double r, int n, double expected)
    {
        Assert.Equal(expected, Calculations.GeometricSum(a, r, n));
    }
}