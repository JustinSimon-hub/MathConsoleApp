using System;
namespace MathOperationsConsoleApp
{
	public  static class Operations
	{
        public static double Divide(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new ArgumentException("Divisor cannot be zero.");
            }

            return (double)dividend / divisor;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Add(int a, int b)
        {
            return a+  b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}

