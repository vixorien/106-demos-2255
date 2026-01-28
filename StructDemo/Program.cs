// Chris Cascioli
// 1/28/26
// Example of structs vs. classes

namespace StructDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create some points
            PointStruct pointA = new PointStruct(5, 7);
            PointStruct pointB = new PointStruct(12, -6);

			// Print them out
			Console.WriteLine(pointA);
			Console.WriteLine(pointB);
			Console.WriteLine();

            // Make a third
            PointStruct pointC = pointA;
            pointC.X = 99;

			// How many points do I have?!
			Console.WriteLine(pointA);
			Console.WriteLine(pointB);
			Console.WriteLine(pointC);
			Console.WriteLine();

            // Change the position of a point
            // - This won't work because a copy
            //   is passed in.  Instead, we'd need
            //   another way of handling a "helper"
            //   method like this (ref, or return the copy)
            ChangePoint(pointA);

			Console.WriteLine(pointA);
			Console.WriteLine(pointB);
			Console.WriteLine(pointC);
			Console.WriteLine();

            // Place the structs into a list
            List<PointStruct> pointList = new List<PointStruct>();
            pointList.Add(pointA);
			pointList.Add(pointB);
			pointList.Add(pointC);

            // Loop and print the list
            for(int i = 0; i < pointList.Count; i++)
				Console.WriteLine(pointList[i]);
			Console.WriteLine();

			// Print just the X value of the first point
			Console.WriteLine(pointList[0].X);

            // Change just the X of the first point
            // Won't work!
            //pointList[0].X += 50;

            // How do we fix this so it works?
            // 3 steps: COPY/ALTER/REPLACE
            PointStruct copy = pointList[0];
            copy.X += 50;
            pointList[0] = copy;
		}

        static void ChangePoint(PointStruct p)
        {
            p.X += 50;
            p.Y += 50;
        }
    }
}
