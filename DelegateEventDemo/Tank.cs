// Chris Cascioli
// 1/21/26
// Example of a class that contains an event

namespace DelegateEventDemo
{
	/// <summary>
	/// Represents a method that accepts a message and a 
	/// corresponding number
	/// </summary>
	delegate void ImportantMessage(string message, int number);

	internal class Tank
	{
		// Event
		/// <summary>
		/// An event that fires when the tank is low on health
		/// </summary>
		public event ImportantMessage LowHealth;

		// Fields
		private int health;

		// Constructor
		/// <summary>
		/// Creates a new tank at full health
		/// </summary>
		public Tank()
		{
			health = 100;
		}

		// Methods
		/// <summary>
		/// Applies damage to the tank and reports low health
		/// </summary>
		/// <param name="amount">Incoming damage</param>
		public void TakeDamage(int amount)
		{
			health -= amount;
			Console.WriteLine("Ouch!");

			// Detect when we're low on health
			// and tell anyone who cares
			if (health < 20 && LowHealth != null)
			{
				// Invoke the event as if it were a method
				LowHealth("I'm dyin' over here!", health);
			}
		}
	}
}
