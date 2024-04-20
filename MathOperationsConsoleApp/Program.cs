
using MathOperationsConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        List<double> results = new List<double>();
        Console.WriteLine("Welcome to Math Roulette, you will be asked to select a math operation to practice then will be prompted 5 questions to test your ability");
        Console.WriteLine("Please enter a digit for the desired operaton.");
        Console.WriteLine("--------------");
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Subtraction");
        Console.WriteLine("3.Multiplication");
        Console.WriteLine("4.Division");
        Console.WriteLine("--------------");
        var ans = Console.ReadLine();
        var answersCorrect = 0;
        while (true)
        {
            switch (ans)
            {
                case "1":
                    Console.WriteLine("Please solve the 5 following problems.");
                    //use math.random to select two random ints then compare if it matches what the user selects if it does increment the win var
                    //loop to ask 5 questions
                    for(int i = 1; i <= 5; i++)
                    {
                        //score keeping var for the user 
                        int correctAnswers = 0;

                        //should generate two different numbers everytime
                        RandomNumbers.GenerateTwoRands(1, 100);

                        Console.WriteLine("What is the sum of the following numbers?");
                        Console.WriteLine($"{RandomNumbers.RandomNumber1} + {RandomNumbers.RandomNumber2}");

                        int userAnswer;
                        if (int.TryParse(Console.ReadLine(), out userAnswer))
                         {


                            int correctSum = RandomNumbers.RandomNumber1 + RandomNumbers.RandomNumber2;
                            if (userAnswer == correctSum)
                            {
                                Console.WriteLine("That was correct!");
                                correctAnswers++;
                                Console.WriteLine("--------------------");
                            }
                            else
                            {
                                Console.WriteLine($"That was incorrect, the answer was {correctSum}");
                                Console.WriteLine("--------------------");

                            }
                        }
                       
                        //for readability
                        Console.WriteLine();
                        
                    }

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
                Console.WriteLine();
                Console.WriteLine($"Congratulations! You answered {answersCorrect} correct.");
            }

        }

    }
}
