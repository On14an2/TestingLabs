public class Calculations
{
    public static double Multiply(double a, double b) => a * b;

    public static double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Division by zero is not allowed.");
        return a / b;
    }

    public static double Distance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    public static (double, double)? SolveQuadratic(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
            return null;
        double sqrtD = Math.Sqrt(discriminant);
        return ((-b + sqrtD) / (2 * a), (-b - sqrtD) / (2 * a));
    }

    public static double GeometricSum(double a, double r, int n)
    {
        if (r == 1)
            return a * n;
        return a * (1 - Math.Pow(r, n)) / (1 - r);
    }
    // Строковые функции
    public static int WordCount(string text) => text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

    public static bool Substring(string text, string sub) => text.Contains(sub);

    public static string ToUpperCase(string text) => text.ToUpper();
}