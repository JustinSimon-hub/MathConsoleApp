
using MathOperationsConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        // Call static methods directly on the class
        int sum = Operations.Add(5, 3);
        int difference = MathUtils.Subtract(10, 4);
        int product = MathUtils.Multiply(6, 2);
        double quotient = MathUtils.Divide(8, 2);

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quotient: {quotient}");

        Console.ReadKey();
    }
}
