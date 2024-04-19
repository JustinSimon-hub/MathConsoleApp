
using MathOperationsConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        List<double> results = new List<double>();

        Console.WriteLine("Please enter a digit for the desired operaton.");
        Console.WriteLine("--------------");
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Subtraction");
        Console.WriteLine("3.Multiplication");
        Console.WriteLine("4.Division");
        Console.WriteLine("--------------");
        var ans = Console.ReadLine();
        while (true)
        {
            switch (ans)
            {
                case "1":

                    Console.WriteLine("Enter in two integers to add.");
                    var a = Int32.Parse(Console.ReadLine());
                    var b = Int32.Parse(Console.ReadLine());
                    var sum = Operations.Add(a, b);
                    Console.WriteLine($"The answer to that is {sum}");
                    results.Add(sum);
                    break;


                case "2":
                    Console.WriteLine("Enter in two integers to subtract.");

                    var c = Int32.Parse(Console.ReadLine());
                    var d = Int32.Parse(Console.ReadLine());
                    var difference = Operations.Subtract(c, d);
                    Console.WriteLine($"The answer to that is {difference}");

                    results.Add(difference);
                    break;

                case "3":
                    Console.WriteLine("Enter in two integers to multiply.");
                    var e = Int32.Parse(Console.ReadLine());
                    var f = Int32.Parse(Console.ReadLine());
                    var product = Operations.Multiply(e, f);
                    results.Add(product);
                    Console.WriteLine($"The answer to that is {product}");

                    break;

                case "4":
                    Console.WriteLine("Enter in two integers to divide.");
                    var g = Int32.Parse(Console.ReadLine());
                    var h = Int32.Parse(Console.ReadLine());
                    var quotient = Operations.Divide(g, h);
                    results.Add(quotient);
                    Console.WriteLine($"The answer to that is {quotient}");

                    break;


                default:
                    Console.WriteLine("Please retry your selection of two integers");
                    break;
            }
            Console.WriteLine("----------------");
            foreach (int x in results)
            {
                Console.WriteLine($"The answers to each of the operations were {x}");
                Console.WriteLine();
            }

        }

    }
}
