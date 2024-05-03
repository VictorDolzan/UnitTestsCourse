using NUnit.Framework;
using Utilities;

namespace UtilitiesTests;

[TestFixture]
public class EnumerableExtensionsTests
{
    [Test]
    public void Test1()
    {
        var input = Enumerable.Empty<int>();

        var result = input.SumOfEvenNumbers();
        
        Assert.AreEqual(0, result);
    }
}