// Chris Cascioli
// 1/28/26
// Example of a custom struct

namespace StructDemo
{
	internal struct PointStruct
	{
		// Fields
		private int x;
		private int y;

		// Properties
		public int X { get { return x; } set { x = value; } }
		public int Y { get { return y; } set { y = value; } }

		// Constructor
		public PointStruct(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		// Methods
		public override string ToString()
		{
			return $"Point ({x}, {y})";
		}
	}
}
