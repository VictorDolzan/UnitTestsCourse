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
    
    [Test]
    public void SumOfEvenNumbers_ShallReturnNonZeroResult_IfEvenNumbersArePresent()
    {
        var input = new int[] {3, 1, 4, 6, 7};

        var result = input.SumOfEvenNumbers();

        var expected = 10;
        var inputAsString = string.Join(", ", input);
        
        Assert.AreEqual(10, result, $"For input {inputAsString} the result shall be {expected} but it was {result}.");
    }
}