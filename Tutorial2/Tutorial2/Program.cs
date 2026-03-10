// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

static long Factorial(int n)
{
    if (n < 0)
        throw new ArgumentException("Factorial is not defined for negative numbers.");
    long result = 1;
    for (int i = 2; i <= n; i++)
    {
        result *= i;
    }
    return result;
}


static bool IsPrime(int n)
{
    if (n <= 1)
        return false;
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
            return false;
    }
    return true;
}

static string ReverseString(string input)
{
    char[] chars = input.ToCharArray();
    Array.Reverse(chars);
    return new string(chars);
}

/// <summary>
/// Calculates the average value of an integer array.
/// </summary>
/// <param name="values">Array of integer values.</param>
/// <returns>The average of the values.</returns>
static double CalculateAverage(int[] values)
{
    if (values == null || values.Length == 0)
        throw new ArgumentException("Array must not be null or empty.");
    int sum = 0;
    
    foreach (int value in values)
    {
        sum += value;
    }
    return (double)sum / values.Length;
}


static int CalculateMax(int[] values)
{
    if (values == null || values.Length == 0)
        throw new ArgumentException("Array must not be null or empty.");

    int max = values[0];

    for (int i = 1; i < values.Length; i++)
    {
        if (values[i] > max)
        {
            max = values[i];
        }
    }

    return max;
}

static int CalculateMin(int[] values)
{
    return values.Min();
}