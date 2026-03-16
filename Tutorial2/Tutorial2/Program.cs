Console.WriteLine("Hello, World!");

static bool IsAdult(int age)
{
    return age >= 18;
}

static double CalculateCircleArea(double radius)
{
    if (radius < 0) return 0;
    return Math.PI * Math.Pow(radius, 2);
}

static double GetHypotenuse(double a, double b)
{
    return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
}

static double CelsiusToFahrenheit(double celsius)
{
    return (celsius * 9 / 5) + 32;
}

static double CalculateAverage(int[] values)
{
    if (values == null || values.Length == 0)
    {
        return 0; 
    }
    double sum = 0;
    foreach (int value in values)
    {
        sum += value;
    }
    return sum/values.Length;
}