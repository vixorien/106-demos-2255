// Chris Cascioli
// 2/18/26
// Implementation of a class that uses the singleton pattern

namespace SingletonDemo
{
	internal class SingletonExample
	{
		// Fields
		private int number;
		private string word;

		// The one and only instance of
		// the class should be static
		private static SingletonExample instance = null!;

		/// <summary>
		/// Gets the one and only instance of this class
		/// </summary>
		public static SingletonExample Instance
		{
			get
			{
				if (instance == null)
					instance = new SingletonExample();

				return instance;
			}
		}

		/// <summary>
		/// Private constructor can only be called INSIDE the class
		/// </summary>
		private SingletonExample() { }

		/// <summary>
		/// Initializes (sets up) the object
		/// </summary>
		public void Initialize(int startNum, string startWord)
		{
			this.number = startNum;
			this.word = startWord;
		}

		/// <summary>
		/// Example of using data via methods
		/// </summary>
		public void PrintData()
		{
			Console.WriteLine("Singleton data: " + number + " " + word);
		}
	}
}
