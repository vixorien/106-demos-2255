// Chris Cascioli
// 2/18/26
// Demo of the singleton design pattern

namespace SingletonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get my one and only instance and initialize it
            SingletonExample.Instance.Initialize(5, "hello");

            // Later, use the instance like any other object
            SingletonExample.Instance.PrintData();
        }
    }
}
