using NUnit.Framework;
using Utilities;

namespace UtilitiesTests;

[TestFixture]
public class EnumerableExtensionsTests
{
    [Test]
    public void SumOfEvenNumbers_ShallReturnZero_ForEmptyCollection()
    {
        var input = Enumerable.Empty<int>();

        var result = input.SumOfEvenNumbers();
        
        Assert.AreEqual(0, result);
    }
    
    // [TestCase(new int[] {3, 1, 4, 6, 7}, 10)]
    // [TestCase(new List<int>() {100, 200, 1}, 300)]
    [TestCaseSource(nameof(GetSumOfEvenNumberTestCase))]
    public void SumOfEvenNumbers_ShallReturnNonZeroResult_IfEvenNumbersArePresent(IEnumerable<int> input, int expected)
    {
        //arrange
        
        //act
        var result = input.SumOfEvenNumbers();

        //assert
        var inputAsString = string.Join(", ", input);
        Assert.AreEqual(expected, result, $"For input {inputAsString} the result shall be {expected} but it was {result}.");
    }

    private static IEnumerable<object> GetSumOfEvenNumberTestCase()
    {
        return new[]
        {
            new object[]{new int[] {3, 1, 4, 6, 7}, 10},
            new object[] {new List<int>() {100, 200, 1}, 300},
            new object[] {new List<int>() {-3, -5, 0}, 0},
            new object[] {new List<int>() {-4, -8}, -12}
        };
    }
    
    [TestCase(8, 8)]
    [TestCase(-8, -8)]
    [TestCase(6, 6)]
    [TestCase(0, 0)]
    public void SumOfEvenNumbers_ShallReturnValueOfTheOnlyItem_IfItIsEven(int number, int expectedResult)
    {
        //arrange
        var input = new int[] { number };

        //act
        var result = input.SumOfEvenNumbers();

        //assert
        Assert.AreEqual(expectedResult, result, $"For input {number} the result shall be {expectedResult} but it was {result}.");
    }
    
    [TestCase(1)]
    [TestCase(-7)]
    [TestCase(33)]
    public void SumOfEvenNumbers_ShallReturnZero_IfOnlyNumberInInputIsOdd(int number, int expectedResult = 0)
    {
        //arrange
        var input = new int[] { number };

        //act
        var result = input.SumOfEvenNumbers();

        //assert
        Assert.AreEqual(expectedResult, result, $"For input {number} the result shall be {expectedResult} but it was {result}.");
    }
}