using FibonacciGenerator;
using NUnit.Framework;

namespace FibonacciGeneratorTests;

[TestFixture]
public class FibonacciGeneratorTests
{
    [TestCase(-1)]
    [TestCase(-5)]
    [TestCase(-100)]
    public void Generate_ShallThrowException_IfNumIsSmallerThanZero(int num)
    {
        Assert.Throws<ArgumentException>(() => Fibonacci.Generate(num));
    }
    
    [TestCase(47)]
    [TestCase(52)]
    [TestCase(90)]
    public void Generate_ShallThrowException_IfNumIsLargerThan46(int num)
    {
        Assert.Throws<ArgumentException>(() => Fibonacci.Generate(num));
    }
    
    [Test]
    public void Generate_ShallProduceEmptySequence_ForNumEqualTo0()
    {
        var result = Fibonacci.Generate(0);
        Assert.IsEmpty(result);
    }

    [Test]
    public void Generate_ShallProduceSequenceWith_0_ForNumEqualTo1()
    {
        var result = Fibonacci.Generate(1);
        Assert.AreEqual(new int[] { 0 }, result);
    }
    
    [Test]
    public void Generate_ShallProduceSequenceWith_0_1_ForNumEqualTo2()
    {
        var result = Fibonacci.Generate(2);
        Assert.AreEqual(new int[] { 0, 1 }, result);
    }

    [TestCase(3, new int[] { 0, 1, 1 })]
    [TestCase(5, new int[] { 0, 1, 1, 2, 3 })]
    [TestCase(10, new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 })]
    public void Generate_ShallProduceValidFibonacciSequence(int num, int[] expected)
    {
        var result = Fibonacci.Generate(num);
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Generate_ShallProduceSequenceWithLastNumber_1134903170_ForNumEqualTo46()
    {
        var result = Fibonacci.Generate(46);
        const int FibonacciNumber46 = 1134903170;
        Assert.AreEqual(FibonacciNumber46, result.Last());
    }
}