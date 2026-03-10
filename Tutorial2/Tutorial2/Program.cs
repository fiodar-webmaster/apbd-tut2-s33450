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