// Chris Cascioli
// 1/14/26
// Example of reading and writing binary files

namespace BinaryFileIODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "../../../file.data";

            // Write the data to the file and then
            // read it back in to ensure it works
            WriteData(filepath);
            ReadData(filepath);
        }

        /// <summary>
        /// Writes a set of data in a particular
        /// order (the "file format") to a file
        /// </summary>
        /// <param name="filepath">File for writing</param>
        static void WriteData(string filepath)
        {
            try
            {
                // Open the file manually (File.OpenWrite) and
                // pass the resulting stream to a writer
                FileStream stream = File.OpenWrite(filepath);
                BinaryWriter output = new BinaryWriter(stream);

                // Write whatever data we want
                output.Write(12345);
                output.Write(3.14159);
                output.Write('x');
                output.Write(false);
                output.Write("Hello there");
                output.Write(-7);

                // Close the file when done
                // Closing the writer will also close the stream
                output.Close();
            }
            catch (Exception e)
            {
				Console.WriteLine("Error writing to file: " + e.Message);
            }
        }

        /// <summary>
        /// Reads data in a particular order (the file format)
        /// from a specified binary file
        /// </summary>
        /// <param name="filepath">File to read</param>
        static void ReadData(string filepath)
        {
            try
            {
                // Open the file and build a reader
                FileStream stream = File.OpenRead(filepath);
                BinaryReader input = new BinaryReader(stream);

                // Read the data into variables
                int numInt = input.ReadInt32();
                double numDouble = input.ReadDouble();
                char symbol = input.ReadChar();
                bool yesno = input.ReadBoolean();
                string words = input.ReadString();
                int numTwo = input.ReadInt32();

				// Print them out
				Console.WriteLine(numInt);
				Console.WriteLine(numDouble);
				Console.WriteLine(symbol);
				Console.WriteLine(yesno);
				Console.WriteLine(words);
				Console.WriteLine(numTwo);

                input.Close();
			}
            catch (Exception e)
            {
				Console.WriteLine("Error reading file: " + e.Message);
			}
		}
    }
}
