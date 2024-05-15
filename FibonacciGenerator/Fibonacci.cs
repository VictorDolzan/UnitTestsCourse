namespace FibonacciGenerator;

public static class Fibonacci
{
    public static IEnumerable<int> Generate(int num)
    {
        if (num < 0)
        {
            throw new ArgumentException($"{nameof(num)} canno be smaller than 0.");
        }

        const int MaxValidNumber = 46;

        if (num > MaxValidNumber)
        {
            throw new ArgumentException(@$"{nameof(num)} cannot be larger than {MaxValidNumber}, as it will cause numeric overflow");
        }

        var result = new List<int>();

        int a = -1;
        int b = 1;

        for (int i = 0; i < num; i++)
        {
            int sum = a + b;
            result.Add(sum);
            a = b;
            b = sum;
        }
        
        return result;
    }
}