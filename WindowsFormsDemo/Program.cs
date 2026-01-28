// Chris Cascioli
// 1/28/26
// Example of a windows forms project 
// Note that main should be VERY simple

namespace WindowsFormsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enable modern visual styles
            Application.EnableVisualStyles();

            // Tell the application which
            // window is the "primary" one
            // and get the background
            // app loop running
            Application.Run(new MyWindow());
        }
    }
}
