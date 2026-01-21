// Chris Cascioli
// 1/21/26
// Example of delegates and events

namespace DelegateEventDemo
{
    /// <summary>
    /// An example delegate that can represent
    /// any method that has a void return type
    /// and accepts a single integer
    /// </summary>
    /// <param name="x">The only param</param>
    delegate void MyFirstDelegate(int x);

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a variable of type "MyFirstDelegate"
            MyFirstDelegate iHoldAMethod = ExampleMethod;

            // Invoke the method we've stored
            iHoldAMethod(7);
			Console.WriteLine();

            // --------------------

            // Create the tank and deal some damage
            Tank tank = new Tank();
			tank.LowHealth += LowHealthCallback;

            tank.TakeDamage(10);
			tank.TakeDamage(30);
			tank.TakeDamage(14);
			tank.TakeDamage(7);
			tank.TakeDamage(19);
			tank.TakeDamage(2);
			tank.TakeDamage(5);
		}

        /// <summary>
        /// Method to call when a tank is low on health
        /// </summary>
        /// <param name="message">Tank's message</param>
        /// <param name="number">Remaining health</param>
		private static void LowHealthCallback(string message, int number)
		{
			Console.WriteLine("Teammate yells: " + message);
			Console.WriteLine("Remaining health: " + number);
		}

		static void ExampleMethod(int number)
        {
			Console.WriteLine("I am the example");
			Console.WriteLine("The number is " + number);
        }
    }
}
