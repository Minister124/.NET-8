using CalculatorLib; //To use Calculator

namespace CalculatorLibUnitTests;

public class CalculatorUniTests
{
    [Fact]
    public void TestAdding3And3()
    {
        //Arrange: Set up the inputs and the unit under test
        double a = 3;
        double b = 3;
        double expected = 6;
        Calculator calculator = new();

        //Act: Execute the unit under test
        double actual = calculator.Add(a, b);

        //Assert: Make assertions to compare expected to actual results.
        Assert.Equal(expected, actual);

    }

    [Fact]
    public void TestAdding4And5()
    {
        double a = 4;
        double b = 5;
        double expected = 9;
        Calculator calculator = new();

        double actual = calculator.Add(a, b);

        Assert.Equal(expected, actual);
    }
}