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

static double CelsiusToFahrenheit(double celsius)
{
    return (celsius * 9 / 5) + 32;
}