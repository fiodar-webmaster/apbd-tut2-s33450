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