namespace Utilities;

public static class EnumerableExtensions
{
    public static int SumOfEvenNumbers(this IEnumerable<int> numbers)
    {
        return numbers
            .Where(number => number % 2 == 0)
            .Sum();
    }
}