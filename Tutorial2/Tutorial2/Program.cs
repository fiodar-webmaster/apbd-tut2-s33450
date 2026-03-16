Console.WriteLine("Hello, World!");
Console.WriteLine("This is a calculating program");

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

static int CalculateMax(int[] values)
{
    if (values == null || values.Length == 0)
    {
        throw new ArgumentException("Array must not be null or empty");
    }

    int max = values[0];
    foreach (int value in values)
    {
        if (value > max)
        {
            max = value;
        }
    }

    return max;
}

static int CalculateMin(int[] values)
{
    if (values == null || values.Length == 0)
    {
        throw new ArgumentException("Array must not be null or empty");
    }

    int min = values[0];
    foreach (int value in values)
    {
        if (value < min)
        {
            min = value;
        }
    }
    return min;
}

Console.Write("Please enter your age: ");
string? input = Console.ReadLine();

// We use int.TryParse to safely check if the user actually typed a number
if (int.TryParse(input, out int age))
{
    bool checkAdult = IsAdult(age);
    
    if (checkAdult)
    {
        Console.WriteLine("Result: You are an adult.");
    }
    else
    {
        Console.WriteLine("Result: You are not an adult yet.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid whole number for age.");
}

