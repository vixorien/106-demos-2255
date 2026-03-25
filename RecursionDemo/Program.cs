// Chris Cascioli
// 3/25/26
// Demo of an iterative (loop) and recursive
// implementation of factorial

namespace RecursionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
			// Testing various numbers
			Console.WriteLine("-- Iterative --");
			Console.WriteLine(" 5! = " + FactorialIterative(5));
			Console.WriteLine(" 1! = " + FactorialIterative(1));
			Console.WriteLine(" 0! = " + FactorialIterative(0));

			Console.WriteLine("-- Recursive --");
			Console.WriteLine(" 5! = " + FactorialRecursive(5));
			Console.WriteLine(" 1! = " + FactorialRecursive(1));
			Console.WriteLine(" 0! = " + FactorialRecursive(0));
		}

		/// <summary>
		/// Calculates the factorial of
		/// the given number using recursion
		/// </summary>
		/// <param name="num">Starting value</param>
		/// <returns>Factorial of starting value</returns>
		static int FactorialRecursive(int num)
        {
			// Check input validity
			if (num < 0)
				throw new InvalidOperationException("Negative factorials are undefined!");

            // Check for a base case vs. recursive case
            if (num == 0)
            {
                // Base case - no other possible value
                return 1;
            }
            else
            {
                // Recursive case
                return num * FactorialRecursive(num - 1);
			}
		}

		/// <summary>
		/// Calculates the factorial of
		/// the given number using a loop
		/// </summary>
		/// <param name="num">Starting value</param>
		/// <returns>Factorial of starting value</returns>
		static int FactorialIterative(int num)
        {
            // Check input validity
            if (num < 0)
                throw new InvalidOperationException("Negative factorials are undefined!");


            int result = 1;

            // One potential option
            //for (int i = num; i > 0; i--)
            //{
            //    result *= i;
            //}

            // Another option (fewer variables)
            while (num > 0)
            {
                result *= num;
                num--;
            }

            return result;
        }
    }
}
