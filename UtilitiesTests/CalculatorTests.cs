using NUnit.Framework;
using Utilities;

namespace UtilitiesTests;

[TestFixture]
public class CalculatorTests
{
    [TestCase(1, 2, 3)]
    [TestCase(1, -1, 0)]
    [TestCase(0, 0, 0)]
    [TestCase(100, -50, 50)]
    [TestCase(11, 12, 23)]
    public void Sum_ShallAddNumbersCorrectly(int num1, int num2, int expected)
    {
        var result = Calculator.Sum(num1, num2);
        Assert.AreEqual(expected, result, $"Adding {num1} to {num2} shall give {expected} but the result was {result}");
    }
}